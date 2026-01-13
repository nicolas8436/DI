using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8ClasePersona
{
    public class Persona
    {   
        public string id {  get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public Persona(string id, string n, string a)
        {
            this.id = id;
            nombre = n;
            apellido = a;
        }
    }
}
