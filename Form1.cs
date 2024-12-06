namespace Almacén_Virtual_Proyect
{
    public partial class Form1 : Form
    {
        Controlador.pf.Controller cl = new Controlador.pf.Controller();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cl.Activar(txtProducto, txtPrecio, txtIDproducto, txtCantidad, txtMarca, btnRegistro);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (!ValidarSoloLetras(txtProducto.Text))
            {
                MessageBox.Show("El nombre del producto solo debe contener letras y espacios.");
                return;
            }

            if (!ValidarSoloLetras(txtMarca.Text))
            {
                MessageBox.Show("La marca solo debe contener letras.");
                return;
            }

            if (!ValidarSoloNumeros(txtIDproducto.Text))
            {
                MessageBox.Show("El ID del producto debe ser un número.");
                return;
            }

            if (!ValidarSoloNumeros(txtPrecio.Text))
            {
                MessageBox.Show("El precio debe ser un número.");
                return;
            }

            if (!ValidarSoloNumeros(txtCantidad.Text))
            {
                MessageBox.Show("La cantidad debe ser un número.");
                return;
            }

            cl.AgregaraLista(txtProducto, txtPrecio, txtIDproducto, txtCantidad, txtMarca, dgvProducAlmacenados, epAdvertencia);
            cl.VaciarRegresar(txtProducto, txtPrecio, txtIDproducto, txtCantidad, txtMarca);
        }

        private void tsBoorartodo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            cl.EliminarunProduc(dgvProducAlmacenados);
        }

        private void tsBorrartodo_Click(object sender, EventArgs e)
        {
            cl.LimpiarLista(dgvProducAlmacenados);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Focus();

            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de producto para buscar.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreProducto = txtBuscar.Text.Trim();
            bool productoEncontrado = false;

            List<DataGridViewRow> filasReordenadas = new List<DataGridViewRow>();

            foreach (DataGridViewRow fila in dgvProducAlmacenados.Rows)
            {
                if (fila.Cells["Nombre del producto"].Value != null)
                {
                    string nombreFila = fila.Cells["Nombre del producto"].Value.ToString();
                    if (string.Equals(nombreFila, nombreProducto, StringComparison.OrdinalIgnoreCase))
                    {
                        filasReordenadas.Insert(0, fila);
                        productoEncontrado = true;
                    }
                    else
                    {
                        filasReordenadas.Add(fila);
                    }
                }
            }

            if (productoEncontrado)
            {
                dgvProducAlmacenados.Rows.Clear();
                foreach (var fila in filasReordenadas)
                {
                    dgvProducAlmacenados.Rows.Add(fila.Cells.Cast<DataGridViewCell>().Select(c => c.Value).ToArray());
                }

                dgvProducAlmacenados.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show($"El producto \"{nombreProducto}\" no existe en el almacén.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tlbReservar_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void dgvProducAlmacenados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvProducAlmacenados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lbProductosDeComparacion_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (rbMenores.Checked == true)
            {
                cl.MostrarConsultaMenor(dgvConsculta, txtConsultao);
            }

            if (rbMayores.Checked == true)
            {
                cl.MostrarConsultaMayor(dgvConsculta, txtConsultao);
            }
        }

        private void tpRegistro_Click(object sender, EventArgs e)
        {
        }

        private void lblProducto_Click(object sender, EventArgs e)
        {
        }

        private void tpRegistro_Click_1(object sender, EventArgs e)
        {
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
        }

        private bool ValidarSoloLetras(string texto)
        {
            return texto.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool ValidarSoloNumeros(string texto)
        {
            return int.TryParse(texto, out _);
        }

        private void dgvConsculta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void rbMenores_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbMayores_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void tpConsulta_Click(object sender, EventArgs e)
        {
        }

        private void tpAlmacen_Click(object sender, EventArgs e)
        {
        }

        private void dgvProducAlmacenados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        private void tpRegistro_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;    
        }
    }
}

