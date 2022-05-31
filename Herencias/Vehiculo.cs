using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    internal class Vehiculo
    {
        string placa;
        string color;
        string marca;
        string transmision;
        string traccion;
        string frenos;
        string propietario;
        string numerodemotor;
        string numerodechasis;
        double largo;
        double ancho;
        double cilindraje;
        double peso;
        int ruedas;
        int espejos;
        int luces;
        int claxon;
        DateOnly modelo;

        public string Placa { get => placa; set => placa = value; }
        public string Color { get => color; set => color = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Transmision { get => transmision; set => transmision = value; }
        public string Traccion { get => traccion; set => traccion = value; }
        public string Frenos { get => frenos; set => frenos = value; }
        public string Propietario { get => propietario; set => propietario = value; }
        public string Numerodemotor { get => numerodemotor; set => numerodemotor = value; }
        public string Numerodechasis { get => numerodechasis; set => numerodechasis = value; }
        public double Largo { get => largo; set => largo = value; }
        public double Ancho { get => ancho; set => ancho = value; }
        public double Cilindraje { get => cilindraje; set => cilindraje = value; }
        public double Peso { get => peso; set => peso = value; }
        public int Ruedas { get => ruedas; set => ruedas = value; }
        public int Espejos { get => espejos; set => espejos = value; }
        public int Luces { get => luces; set => luces = value; }
        public int Claxon { get => claxon; set => claxon = value; }
        public DateOnly Modelo { get => modelo; set => modelo = value; }

        public bool Encender (bool enciende)
        {
            return enciende;
        }

        public bool Acelerar(bool acelera)
        {
            return acelera;
        }

        public bool Frenar(bool frena)
        {
            return frena;
        }

        public bool Detener(bool detiene)
        {
            return detiene;
        }

        public int Girar(int girar)
        {
            return girar;
        }
    }
}
