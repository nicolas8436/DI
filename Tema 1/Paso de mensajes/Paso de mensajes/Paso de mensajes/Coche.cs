using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Paso_de_mensajes
{
    public class Coche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Persona Propietario { get; set; }
        public string Color { get; set; }

        public Coche(string Marca, string Modelo, string Color, Persona Propietario)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Color = Color;
            this.Propietario = Propietario;
        }

        public override string ToString()//Sobre escribimos el metodo para q ToString devuelva el mnsaje que le digamos
        {
            return "El coche es un " + Marca + " " + Modelo + " de color "+ Color + " y su propietario es "+ Propietario.Nombre;
        }

        public void CambioProp (Persona p)//Le indicamos q le llega un objeto persona por el que le vamos a sustituir
        {
            Propietario = p;
        }

    }
}
