using System;
namespace Verduleria.Models
{
    public class Verdura : Producto
    {
        public bool EsHojaVerde { get; set; }

        public string TipoVerdura { get; set; }

        public override string ObtenerTipo()
        {
            return "Verdura";
        }
    }
}
