using System;

namespace Verduleria.Models
{
    public class ProductoAlmacen : Producto
    {
        public string Marca { get; set; }

        public DateTime FechaVencimiento
        {
            get;
            set;
        }

        public int CantidadStock
        {
            get;
            set;
        }

        public override string ObtenerTipo()
        {
            return "Producto almacen";
        }
    }
}