using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paso_de_mensajes
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string Nombre, int Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
        }

        public override string ToString()//Sobre escribimos el metodo para q ToString devuelva el mnsaje que le digamos
        {
            return "Mi nombre es  " + Nombre + " y mi edad es " + Edad;
        }

        public void CambioEdad(int e)
        {
            Edad = e;
        }
    }
}