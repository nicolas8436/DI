using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioListas2
{
    internal class Persona
    {
        public String nombre { get; set; }
        public int longitudNombre { get; set; }

        public Persona() { }
        public Persona(String nombre, int longitudNombre) {
            this.nombre = nombre;
            this.longitudNombre = longitudNombre;
                
                }
 
    }
}
