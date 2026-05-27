using System;

namespace Verduleria.Models
{
    public class Ticket : IMostrable
    {
        public int Numero { get; set; }

        public DateTime Fecha
        {
            get;
            set;
        }

        public void Mostrar()
        {
            Console.WriteLine(
                "Ticket N° " + Numero);

            Console.WriteLine(
                "Fecha: " + Fecha);
        }
    }
}