using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Boleto
    {
        private int[] Numboleto;

        private int numeroAleatorio()
        {
            return new Random().Next(1, 50);
        }
        public Boleto()
        {
            Numboleto = new int[6];
        }

        public int ObtenerPosicion(int indice)
        {
            return Numboleto[indice];
        }

    }
}

//Mirar si se puede concatenar para hacer las comprobaciones

//No puede haber dos numeros iguales en el mismo boleto
//No puede habeer un boleto con los 6 mismos numeros es decir 1 al 6 y lg otro q cambie minimo un numero 