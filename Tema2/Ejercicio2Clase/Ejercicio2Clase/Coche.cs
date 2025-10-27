using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Clase
{
    internal class Coche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Coche(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }

        public override string ToString()
        {   
            return Marca + ", " + Modelo;
        }
    }
}