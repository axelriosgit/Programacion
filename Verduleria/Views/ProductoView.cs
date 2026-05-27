using System;
using System.Collections.Generic;
using Verduleria.Models;

namespace Verduleria.Views
{
    public class ProductoView
    {
        public void MostrarProductos(
            List<Producto> productos)
        {
            Console.WriteLine(
                "===== PRODUCTOS =====");

            foreach (Producto p in productos)
            {
                Console.WriteLine(
                    p.Id + " - " +
                    p.Nombre + " - $" +
                    p.Precio + " - " +
                    p.ObtenerTipo());
            }
        }

        public void MostrarProducto(
            Producto p)
        {
            if (p != null)
            {
                Console.WriteLine(
                    p.Nombre + " - $" +
                    p.Precio);
            }
            else
            {
                Console.WriteLine(
                    "Producto no encontrado");
            }
        }
    }
}