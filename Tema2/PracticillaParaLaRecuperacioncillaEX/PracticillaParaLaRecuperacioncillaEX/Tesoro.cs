using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticillaParaLaRecuperacioncillaEX
{
    public class Tesoro
    {
        private int peso;

        public string descripcion { get; set; }
        public int pesoUd {  get; set; }
        public int numeroUd {  get; set; }
        public int volumenUd { get; set; }

        public Tesoro(string descripcion) {
            this.descripcion = descripcion;
            this.peso = MetodillosSueltacillos.random(1, 100);
            this.numeroUd = MetodillosSueltacillos.random(1, 10);
            this.volumenUd = MetodillosSueltacillos.random(5, 50);
        }

        public bool mayorQue(Tesoro actual, Tesoro comparar) {
            if (actual.numeroUd * actual.volumenUd > comparar.numeroUd * comparar.volumenUd) {
                Console.WriteLine("El actual pesa mas");
                return true;
            } else if (actual.numeroUd * actual.volumenUd < comparar.numeroUd * comparar.volumenUd)
            {
                Console.WriteLine("El actual pesa menos");
                return false;
            } else if (actual.numeroUd * actual.volumenUd == comparar.numeroUd * comparar.volumenUd) {

                if (actual.numeroUd * actual.pesoUd > comparar.numeroUd * comparar.pesoUd)
                {
                    Console.WriteLine("El actual pesa mas");
                    return true;
                }
                else if (actual.numeroUd * actual.pesoUd < comparar.numeroUd * comparar.pesoUd)
                {
                    Console.WriteLine("El actual pesa menos");
                    return false;
                }

            }
            Console.WriteLine("Parece q pesan lo mismo, se colocara el actual como mayor");
            return true;
        }

    }
}
