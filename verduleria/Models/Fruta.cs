using System;
namespace Verduleria.Models
{
    public class Fruta : Producto
    {
        public bool EsCitrica { get; set; }

        public string TipoFruta { get; set; }

        public override string ObtenerTipo()
        {
            return "Fruta";
        }
    }
}