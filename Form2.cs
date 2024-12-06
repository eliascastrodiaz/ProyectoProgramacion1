using System;
using System.IO;
using System.Windows.Forms;

namespace Almacén_Virtual_Proyect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus(); 
        }

    
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContraseña.Text))
            {
              
                string rutaArchivo = "usuarios.txt";

                
                if (File.Exists(rutaArchivo))
                {
                    
                    string[] usuariosExistentes = File.ReadAllLines(rutaArchivo);
                    bool usuarioValido = false;

                    
                    foreach (string linea in usuariosExistentes)
                    {
                        
                        string[] datos = linea.Split(',');

                        
                        if (datos[0] == txtUsuario.Text && datos[1] == txtContraseña.Text)
                        {
                            
                            MessageBox.Show("Inicio de sesión exitoso!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                            usuarioValido = true;
                            break;
                        }
                    }

                    
                    if (!usuarioValido)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                        txtUsuario.Clear();
                        txtContraseña.Clear();
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("El archivo de usuarios no existe.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un usuario y contraseña.");
            }
        }

        
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        
        private void btnRegistro_Click(object sender, EventArgs e)
        {

          
            FormRegistro formRegistro = new FormRegistro();

            
            formRegistro.ShowDialog();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}

