using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    internal class TipoVehiculo: Automovil
    {
        string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        public bool AbrirMaletero(bool abierto)
        {
            return abierto;
        }
    }
}
