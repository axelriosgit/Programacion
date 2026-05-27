using System;

namespace Verduleria.Models
{
    public interface IDescuento
    {
        double AplicarDescuento(double total);
    }
}