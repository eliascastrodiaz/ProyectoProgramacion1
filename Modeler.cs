using System.Collections;

namespace Modelo.pf
{
    public class Modeler
    {
        public string Producto { get; set; }
        public string Existencia { get; set; }
        public string IDProducto { get; set; }
        public int precio { get; set; }
        public string Marca { get; set; }

        public Modeler(string producto, string existencia, string idProducto, int precio, string marca)
        {
            this.Producto = producto;
            this.Existencia = existencia;
            this.IDProducto = idProducto;
            this.precio = precio;
            this.Marca = marca;
        }

        public Modeler() { }
    }
}