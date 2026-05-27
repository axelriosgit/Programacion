using System.Collections.Generic;
using System.Linq;
using Verduleria.Models;

namespace Verduleria.Controllers
{
    public class ProductoController
    {
        private List<Producto> productos;

        public ProductoController()
        {
            productos =
                new List<Producto>();
        }

        public void AgregarProducto(
            Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto>
            ObtenerProductos()
        {
            return productos;
        }

        public List<ProductoAlmacen>
            ObtenerProductosVencimiento()
        {
            return productos
                .OfType<ProductoAlmacen>()
                .OrderBy(
                    p => p.FechaVencimiento)
                .ToList();
        }

        public Producto BuscarProducto(
            int id)
        {
            return productos
                .FirstOrDefault(
                    p => p.Id == id);
        }

        public bool EliminarProducto(
            int id)
        {
            Producto producto =
                BuscarProducto(id);

            if (producto != null)
            {
                productos.Remove(producto);

                return true;
            }

            return false;
        }
    }
}