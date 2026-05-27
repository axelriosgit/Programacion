namespace Verduleria.Models
{
    public class Verdura : Producto
    {
        public bool EsHojaVerde
        {
            get;
            set;
        }

        public override string ObtenerTipo()
        {
            return "Verdura";
        }
    }
}