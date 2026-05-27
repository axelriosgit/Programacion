using System;
using Verduleria.Models;

namespace Verduleria.Controllers
{
    public class VentaController
    {
        public Venta CrearVenta()
        {
            return new Venta();
        }

        public void AgregarProductoVenta(
            Venta venta,
            Producto producto)
        {
            venta.Productos.Add(producto);
        }
    }
}