using System.Xml.Serialization;
using System.Collections.Generic;

namespace Ejercicio3Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cola = tamañoCola();


            Queue<Persona> colaEspera = new Queue<Persona>();

            for (int i = 0; i < cola; i++) 
            {
                Persona persona = new Persona(); 
                persona.setEdad();               
                colaEspera.Enqueue(persona);
            }

            int cont = 1; int de5A10 = 0; int de11A17 = 0; int mas18 = 0;
            while (colaEspera.Count > 0)
            {
                

                Persona perAtendida = colaEspera.Dequeue(); 
                int edadPerAt = perAtendida.getEdad();

                Console.WriteLine("Espectador " + cont );
                Console.WriteLine("Edad de la persona atendida: " + edadPerAt);
                Console.WriteLine();
                if (edadPerAt >= 5 && edadPerAt <= 10)
                {
                    de5A10++;
                }
                else if (edadPerAt >= 11 && edadPerAt <= 17)
                {
                    de11A17++;
                }
                else
                {
                    mas18++;
                }

                

                    cont++;
            }
            int Total =(de5A10 * 3) +(de11A17 * 5)+(mas18 * 7) ;

            Console.WriteLine("Hay " + de5A10 + " personas entre 5 y 10 años");
            Console.WriteLine("Hay " + de11A17 + " personas entre 11 y 17 años");
            Console.WriteLine("Hay " + mas18 + " personas con mas de 18 años");
            Console.WriteLine("Se han recaudado "+ Total +" euros");
        }
    
   
 
        public static int tamañoCola()
        {
            Random rnd = new Random();
            int tamañoCola = rnd.Next(0, 51);
            return tamañoCola;

        } 
    }
}