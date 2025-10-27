using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Clase
{
    internal class Forestal
    {
        public String Nombre {  get; set; }
        public String Ape1 {  get; set; }
        public String Ape2 {  get; set; }
        public String tlf { get; set; }

        public Forestal(string nombre, string ape1, string ape2, string tlf)
        {
            Nombre = nombre;
            Ape1 = ape1;
            Ape2 = ape2;
            this.tlf = tlf;
        }

    }
}
