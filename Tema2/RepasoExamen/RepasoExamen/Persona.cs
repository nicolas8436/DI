using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Ap1 { get; set; }
        public string Ap2 { get; set; }
        public int Telefono { get; set; }

        public Persona(string Nombre, string Ap1, string Ap2, int Telefono) {
            this.Nombre = Nombre;
            this.Ap1 = Ap1;
            this.Ap2 = Ap2; 
            this.Telefono = Telefono;
        }
    }
}
