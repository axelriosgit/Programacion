using System.Collections.Generic;
using System.Linq;

namespace Verduleria.Models
{
    public class Venta : IDescuento
    {
        public List<Producto> Productos
        {
            get;
            set;
        }

        public Cliente Cliente
        {
            get;
            set;
        }

        public Venta()
        {
            Productos =
                new List<Producto>();
        }

        public double CalcularTotal()
        {
            return Productos.Sum(
                p => p.Precio * p.PesoKg);
        }

        public double AplicarDescuento(
            double total)
        {
            return total * 0.90;
        }
    }
}