using Modelo.pf;
using System.Collections;
using System.Diagnostics.Contracts;
using System.Drawing.Imaging;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Controlador.pf
{


    public class Controller
    {
        Modelo.pf.Modeler m = new Modelo.pf.Modeler();
        Modelo.pf.XXModelXX x = new Modelo.pf.XXModelXX();

        //...#
        //...Ver los Productos agaregados y agregar.....
        public void Agregados(DataGridView dgvPro)
        {
            dgvPro.Rows.Add(m.Producto, m.precio, m.IDProducto, m.Existencia, m.Marca);
        }


        //...###
        //...Eliminaciones...
        public void EliminarunProduc(DataGridView dgvpro)
        {
            int n = 0;
            dgvpro.Rows.RemoveAt(n);

            x.Eliminar(n);
            MessageBox.Show("Se elimino el producto seleccionado");
        }



        public void LimpiarLista(DataGridView dgvpro)
        {
            DialogResult t = MessageBox.Show("Se eliminaran todos los datos", "Advertencia", MessageBoxButtons.OKCancel);
            if (t == DialogResult.OK)
            {
                dgvpro.Rows.Clear();

            }

            if (t == DialogResult.Cancel)
            {
                MessageBox.Show("Cancelada correctamente");
            }


        }

        //..##
        //...Guardar la informacion en la lista
        public void AgregaraLista(TextBox prod, TextBox Valor, TextBox IDp, TextBox Exis, TextBox Marca, DataGridView dgvpro, ErrorProvider error)
        {
            bool i = AdvertenciaVacios(prod, Valor, IDp, Exis, Marca, error);


            if (i)
            {
                QuitarAdvertencias(prod, Valor, IDp, Exis, Marca, error);
                string Prod = prod.Text;
                int Valo = Convert.ToInt16(Valor.Text);
                string Idp = IDp.Text;
                string exis = Exis.Text;
                string marca = Marca.Text;

                m.Producto = Prod;
                m.precio = Valo;
                m.IDProducto = Idp;
                m.Existencia = exis;
                m.Marca = marca;

                x.Agregar(m);
                Agregados(dgvpro);
                MessageBox.Show("Producto Agregado");



            }
        }






        //...##
        //...Validar los campos que esten vacios...
        public bool AdvertenciaVacios(TextBox prod, TextBox prec, TextBox IDp, TextBox Exis, TextBox Marca, ErrorProvider error)
        {
            bool i = true;
            if (prod.Text == "")
            {
                i = false;
                error.SetError(prod, "El cuadro no tiene información");
                prod.Focus();
            }

            if (prec.Text == "")
            {
                i = false;
                error.SetError(prec, "El cuadro no tiene información");
                prec.Focus();
            }

            if (IDp.Text == "")
            {
                i = false;
                error.SetError(IDp, "El cuadro no tiene informacion");
                IDp.Focus();
            }

            if (Exis.Text == "")
            {
                i = false;
                error.SetError(Exis, "El cuadro no tiene informacion");
                Exis.Focus();
            }

            if (Marca.Text == "")
            {
                i = false;
                error.SetError(Marca, "El cuadro no tiene informacion");
                Marca.Focus();
            }
            return i;
        }




        //....."""
        //....Quitar el errorProvider
        public void QuitarAdvertencias(TextBox prod, TextBox prec, TextBox IDp, TextBox Exis, TextBox Marca, ErrorProvider error)
        {
            error.SetError(prod, "");
            error.SetError(prec, "");
            error.SetError(IDp, "");
            error.SetError(Exis, "");
            error.SetError(Marca, "");
        }



        //....###
        //...Activar Botones

        public void Activar(TextBox prod, TextBox prec, TextBox IDp, TextBox Exis, TextBox Marca, Button add)
        {
            add.Enabled = true;
            prod.Enabled = true;
            prec.Enabled = true;
            IDp.Enabled = true;
            Exis.Enabled = true;
            Marca.Enabled = true;

            prod.Focus();
        }

        public void ActivarBusqueda(TextBox busqueda, Button buscar)
        {

            busqueda.Enabled = true;

            busqueda.Focus();

        }

        public void VaciarRegresar(TextBox prod, TextBox prec, TextBox IDp, TextBox Exis, TextBox Marca)
        {
            prod.Text = "";
            prec.Text = "";
            IDp.Text = "";
            Exis.Text = "";
            Marca.Text = "";

            prod.Focus();

        }



        //...###
        //...Busqueda...

        public void BuscarEnLista(TextBox Buscar, DataGridView result)
        {
            if (Buscar.Text != "")
            {
                result.CurrentCell = null;
                foreach (DataGridViewRow r in result.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in result.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if (c.Value.ToString().ToUpper().IndexOf(Buscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }

                    }

                }

            }
            else
            {
                foreach (DataGridViewRow r in result.Rows)
                {
                    r.Visible = true;
                }
            }

        }



        //...Linq

        public void MostrarConsultaMenor(DataGridView dgv, TextBox C)
        {
            double P = double.Parse(C.Text);
            List<Modeler> s = x.Lin(P).ToList();

            dgv.DataSource = null;
            dgv.DataSource = s;

        }

        public void MostrarConsultaMayor(DataGridView dgv, TextBox C)
        {
            double S = double.Parse(C.Text);
            List<Modeler> s = x.Lin1(S).ToList();

            dgv.DataSource = null;
            dgv.DataSource = s;

        }






    }
}