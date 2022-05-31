using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    internal class Ejes: Vehiculo
    {
        int cantidad;

        public int Cantidad { get => cantidad; set => cantidad = value; }

        public double FuerzaMotor (double caballos)
        {
            return caballos;
        }

        public double TraccionRuedas(double fuerza)
        {
            return fuerza;
        }
    }
}
