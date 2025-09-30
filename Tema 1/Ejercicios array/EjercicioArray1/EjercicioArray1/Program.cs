using System.Collections;

namespace EjercicioArray1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int[] numeros = new int[20];

            for (int i = 0; i < numeros.Length; i++){
                numeros[i] = rnd.Next(0, 21);
            }
            
            for (int x = 0; x < numeros.Length; x++)
            {
                for (int i = 0; i < numeros[x]; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" - " + numeros[x] );
            }
        }
    }
}