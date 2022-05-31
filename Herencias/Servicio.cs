using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    internal class Servicio
    {
        Automovil automovil = new Automovil();

        string tipo;

        public string Tipo { get => tipo; set => tipo = value; }

        public bool PrestacionServicio(bool en_servicio)
        {
            return en_servicio;
        }

        public bool UsoDiario(bool afirmacion)
        {
            return afirmacion;
        }
    }
}
