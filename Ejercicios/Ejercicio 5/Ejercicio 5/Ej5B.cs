using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Ej5B
    {
             try{
                
                Console.WriteLine("Inserte un numero: ");
                numero = int.Parse(Console.ReadLine());
                
                if (m5.Multiplo5(numero))
                {
                    Console.WriteLine("Es multiplo de 5");
                }
                else
                {
                    Console.WriteLine("No es multiplo de 5");
                }
                



            }
            catch (Exception ex)
            {
                Console.WriteLine("No es valido");
            }

    }
}
