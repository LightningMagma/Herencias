using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    internal class Superclase
    {
        private string nombre;
        private string apellido;

        public Superclase(){}
        public Superclase(string nombre , string apellido) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string getNombre() 
        { 
            return nombre; 
        }

        public void setNombre(string nombre)
        { 
            this.nombre = nombre; 
        }
        public string getApellido() 
        { 
            return apellido; 
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }


    }
}
