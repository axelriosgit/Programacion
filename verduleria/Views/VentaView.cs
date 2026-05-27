using System;
using Verduleria.Models;

namespace Verduleria.Views
{
    public class VentaView
    {
        public void MostrarTicket(
            Venta venta)
        {
            Console.WriteLine();
            Console.WriteLine(
                "========= TICKET =========");

            Console.WriteLine(
                "Cliente: " +
                venta.Cliente.Nombre);

            Console.WriteLine(
                "DNI: " +
                venta.Cliente.DNI);

            Console.WriteLine();

            foreach (Producto p
                in venta.Productos)
            {
                double subtotal =
                    p.Precio * p.PesoKg;

                Console.WriteLine(
                    p.Nombre +
                    " " +
                    p.PesoKg +
                    "kg .... $" +
                    subtotal);
            }

            double total =
                venta.CalcularTotal();

            Console.WriteLine();

            Console.WriteLine(
                "Subtotal: $" + total);

            double totalFinal =
                venta.AplicarDescuento(total);

            Console.WriteLine(
                "Descuento 10%");

            Console.WriteLine(
                "TOTAL: $" + totalFinal);

            Console.WriteLine(
                "==========================");
        }
    }
}