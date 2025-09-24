namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EsMultiplo5 m5 = new EsMultiplo5();
            int numero;
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
        public class EsMultiplo5 { 
        public bool Multiplo5(int num) { 
            if (num%5 == 0) 
            {return true;
            }
            else { return false; }
        }
        }
    }
}
