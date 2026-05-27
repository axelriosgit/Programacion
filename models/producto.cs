namespace Verduleria.Models
{
    public abstract class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public double Precio { get; set; }

        public double PesoKg { get; set; }

        public string Estacion { get; set; }

        public string Lote { get; set; }

        public System.DateTime FechaIngreso
        {
            get;
            set;
        }

        public abstract string ObtenerTipo();
    }
}