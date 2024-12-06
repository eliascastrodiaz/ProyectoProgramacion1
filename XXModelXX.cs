using System.Collections.Generic;
using System.Linq;

namespace Modelo.pf
{
    public class XXModelXX
    {
        private List<Modeler> Productoss = new List<Modeler>();

        // Agregar un producto
        public void Agregar(Modeler produ)
        {
            Productoss.Add(produ);
        }

        // Eliminar un producto por índice
        public void Eliminar(int p)
        {
            if (p >= 0 && p < Productoss.Count)
            {
                Productoss.RemoveAt(p);
            }
        }

        // Obtener todos los productos
        public List<Modeler> ObtenerProductos()
        {
            return new List<Modeler>(Productoss);
        }

        // Limpiar la lista de productos
        public void LimpiarProductos()
        {
            Productoss.Clear();
        }

        // Consulta: productos con precio menor que el parámetro
        public IEnumerable<Modeler> Lin(double parametro)
        {
            return from P in Productoss where P.precio < parametro select P;
        }

        // Consulta: productos con precio mayor que el parámetro
        public IEnumerable<Modeler> Lin1(double parametro)
        {
            return from P in Productoss where P.precio > parametro select P;
        }
    }
}