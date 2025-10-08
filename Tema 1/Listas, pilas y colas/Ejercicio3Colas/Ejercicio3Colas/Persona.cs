using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Colas
{
    public class Persona
    {
        private int edad;

        public Persona(){}
        public Persona(int edad)
        {
            this.edad = edad;
        }
        public int getEdad()
        {
            return edad;
        }
        public void setEdad()
        {
            int edad;
            Random rnd = new Random();

            this.edad = rnd.Next(5, 61);
        }
    }

}
