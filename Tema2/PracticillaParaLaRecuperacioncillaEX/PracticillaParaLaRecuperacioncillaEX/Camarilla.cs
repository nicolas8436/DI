using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticillaParaLaRecuperacioncillaEX
{
    internal class Camarilla
    {
        public List<Tesoro> listaTesoros;

        public Camarilla()
        {
            listaTesoros = new List<Tesoro>();
        }

        public void agregarTesorillo(string descripcion) {
            Tesoro t = new Tesoro(descripcion);

            listaTesoros.Add(t);
            Console.WriteLine("Tu tesorillo ha sido agregado");
        }

        public Tesoro MayorTesorillo() {
            if (listaTesoros.Count == 0) { Console.WriteLine("Primero debes añadir tesoros"); return null; }

            Tesoro mayor = listaTesoros[0];
            foreach (Tesoro t in listaTesoros)
            {
                if(t.mayorQue(t, mayor))
                {
                    mayor = t;
                }
            }

            return mayor;
        }

        public List<Tesoro> TeorilloOrdenado() {
            if (listaTesoros.Count == 0) { Console.WriteLine("Primero debes añadir tesoros"); return null; }

            List<Tesoro> listaOrdenada = new List<Tesoro>(listaTesoros);
            Tesoro Cambio;

            for (int i = 0; i < listaTesoros.Count-1; i++) {
                for (int j = 0; j < (listaTesoros.Count-i-1); j++)
                {
                    if (listaTesoros[j].mayorQue(listaTesoros[j], listaTesoros[j+1])) {
                        
                        Cambio = listaTesoros[j];
                        listaTesoros[j] = listaTesoros[j + 1];
                        listaTesoros[j + 1] = Cambio;

                    }
                }
            }

            return listaOrdenada;

        }

        public override string ToString()
        {
            string info = "";
            foreach (Tesoro t in listaTesoros) {
                info = info + t.descripcion + ", " + t.pesoUd + ", " + t.numeroUd + ", " + t.volumenUd + "\n";
            }
            return info;

            {
                
            }
        }
    }
}
