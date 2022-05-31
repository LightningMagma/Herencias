using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    internal class Transporte: Vehiculo
    {
        int cantidadpasajeros;

        public int Cantidadpasajeros { get => cantidadpasajeros; set => cantidadpasajeros = value; }

        public int CargarPasajeros(int cantidadpasajeros)
        {
            return cantidadpasajeros;
        }

        public int DescargarPasajeros(int cantidadpasajeros)
        {
            return cantidadpasajeros;
        }
    }
}
