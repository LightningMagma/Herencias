using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    internal class Alimentacion
    {
        Automovil automovil = new Automovil();

        string Tipo;

        public string Tipo1 { get => Tipo; set => Tipo = value; }

        public int MovimientoSistemaArrastre(int acelera)
        {
            return acelera;
        }

        public void ConversionTipoEnergia()
        {
            
        }
    }
}
