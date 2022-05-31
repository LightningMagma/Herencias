using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    internal class Automovil
    {
        Transporte transporte = new Transporte();

        string carroceria;

        public string Carroceria { get => carroceria; set => carroceria = value; }

        public bool Conducir(bool conduce)
        {
            return conduce;
        }
    }
}
