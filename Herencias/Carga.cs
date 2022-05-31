using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    internal class Carga: Vehiculo
    {
        int capacidadcabina;
        double capacidadcarga;
        string tipocarga;

        public int Capacidadcabina { get => capacidadcabina; set => capacidadcabina = value; }
        public double Capacidadcarga { get => capacidadcarga; set => capacidadcarga = value; }
        public string Tipocarga { get => tipocarga; set => tipocarga = value; }

        public bool Cargar (bool carga)
        {
            return carga;
        }
    }
}
