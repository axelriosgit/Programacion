using System;

namespace Verduleria.Views
{
    public class MenuView
    {
        public void MostrarMenu()
        {
            Console.WriteLine(
                "===== VERDULERIA MVC =====");

            Console.WriteLine(
                "1 - Agregar producto");

            Console.WriteLine(
                "2 - Listar productos");

            Console.WriteLine(
                "3 - Buscar producto");

            Console.WriteLine(
                "4 - Eliminar producto");

            Console.WriteLine(
                "6 - Listar vencimientos");

            Console.WriteLine(
                "0 - Salir");
        }
    }
}