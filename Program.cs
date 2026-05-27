using System;

using System;
using Verduleria.Controllers;
using Verduleria.Models;
using Verduleria.Views;

namespace Verduleria
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductoController productoController =
                new ProductoController();

            MenuView menuView =
                new MenuView();

            int opcion;

            do
            {
                menuView.MostrarMenu();

                Console.Write("Seleccione opcion: ");

                opcion =
                    int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.WriteLine(
                            "Seleccione tipo de producto");

                        Console.WriteLine(
                            "1 - Fruta");

                        Console.WriteLine(
                            "2 - Verdura");

                        Console.WriteLine(
                            "3 - Producto almacen");

                        int tipo =
                            int.Parse(Console.ReadLine());

                        Console.Write("ID: ");
                        int id =
                            int.Parse(Console.ReadLine());

                        Console.Write("Nombre: ");
                        string nombre =
                            Console.ReadLine();

                        Console.Write("Precio: ");
                        double precio =
                            double.Parse(Console.ReadLine());

                        Console.Write("Peso KG: ");
                        double peso =
                            double.Parse(Console.ReadLine());

                        Console.Write("Lote: ");
                        string lote =
                            Console.ReadLine();

                        Producto producto;

                        if (tipo == 1)
                        {
                            Fruta fruta =
                                new Fruta();

                            Console.Write(
                                "Es citrica (true/false): ");

                            fruta.EsCitrica =
                                bool.Parse(
                                    Console.ReadLine());

                            producto = fruta;
                        }

                        else if (tipo == 2)
                        {
                            Verdura verdura =
                                new Verdura();

                            Console.Write(
                                "Es hoja verde (true/false): ");

                            verdura.EsHojaVerde =
                                bool.Parse(
                                    Console.ReadLine());

                            producto = verdura;
                        }

                        else
                        {
                            ProductoAlmacen almacen =
                                new ProductoAlmacen();

                            Console.Write(
                                "Marca: ");

                            almacen.Marca =
                                Console.ReadLine();

                            Console.Write(
                                "Cantidad stock: ");

                            almacen.CantidadStock =
                                int.Parse(
                                    Console.ReadLine());

                            Console.Write(
                                "Fecha vencimiento: ");

                            almacen.FechaVencimiento =
                                DateTime.Parse(
                                    Console.ReadLine());

                            producto = almacen;
                        }

                        producto.Id = id;
                        producto.Nombre = nombre;
                        producto.Precio = precio;
                        producto.PesoKg = peso;
                        producto.Lote = lote;
                        producto.Estacion = "Verano";
                        producto.FechaIngreso =
                            DateTime.Now;

                        productoController
                            .AgregarProducto(producto);

                        Console.WriteLine(
                            "Producto agregado");

                        break;

                    case 2:

                        Console.WriteLine(
                            "===== PRODUCTOS =====");

                        foreach (Producto p in
                            productoController
                            .ObtenerProductos())
                        {
                            Console.WriteLine(
                                p.Id +
                                " - " +
                                p.Nombre +
                                " - $" +
                                p.Precio +
                                " - Lote: " +
                                p.Lote +
                                " - " +
                                p.ObtenerTipo());
                        }

                        break;

                    case 3:

                        Console.Write(
                            "Ingrese ID: ");

                        int buscarId =
                            int.Parse(
                                Console.ReadLine());

                        Producto encontrado =
                            productoController
                            .BuscarProducto(
                                buscarId);

                        if (encontrado != null)
                        {
                            Console.WriteLine(
                                encontrado.Nombre +
                                " - $" +
                                encontrado.Precio);
                        }
                        else
                        {
                            Console.WriteLine(
                                "Producto no encontrado");
                        }

                        break;

                    case 4:

                        Console.Write(
                            "Ingrese ID eliminar: ");

                        int eliminarId =
                            int.Parse(
                                Console.ReadLine());

                        bool eliminado =
                            productoController
                            .EliminarProducto(
                                eliminarId);

                        if (eliminado)
                        {
                            Console.WriteLine(
                                "Producto eliminado");
                        }
                        else
                        {
                            Console.WriteLine(
                                "Producto no encontrado");
                        }

                        break;

                    case 6:

                        var vencimientos =
                            productoController
                            .ObtenerProductosVencimiento();

                        Console.WriteLine(
                            "===== VENCIMIENTOS =====");

                        foreach (
                            ProductoAlmacen p
                            in vencimientos)
                        {
                            Console.WriteLine(
                                p.Nombre +
                                " | Marca: " +
                                p.Marca +
                                " | Vence: " +
                                p.FechaVencimiento
                                .ToShortDateString());
                        }

                        break;

                    case 0:

                        Console.WriteLine(
                            "Saliendo...");
                        break;

                    default:

                        Console.WriteLine(
                            "Opcion incorrecta");
                        break;
                }

                Console.WriteLine();

            } while (opcion != 0);
        }
    }
}