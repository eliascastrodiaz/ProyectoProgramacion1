using System;
using System.IO;
using System.Windows.Forms;

namespace Almacén_Virtual_Proyect
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
          
            string rutaArchivo = "usuarios.txt";

            if (!File.Exists(rutaArchivo))
            {
              
                File.Create(rutaArchivo).Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string confirmarContraseña = txtConfirmarContraseña.Text.Trim();

            
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(confirmarContraseña))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (contraseña != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            string rutaArchivo = "usuarios.txt";

            
            if (File.Exists(rutaArchivo))
            {
                string[] usuariosExistentes = File.ReadAllLines(rutaArchivo);
                foreach (string linea in usuariosExistentes)
                {
                    string[] datos = linea.Split(',');
                    if (datos[0] == usuario)
                    {
                        MessageBox.Show("El usuario ya existe. Elige otro nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

           
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                sw.WriteLine($"{usuario},{contraseña}");
            }

            MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtConfirmarContraseña.Text = "";

            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}

