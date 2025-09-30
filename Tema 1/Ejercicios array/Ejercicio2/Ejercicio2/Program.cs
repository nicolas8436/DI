namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10000];
            Random rnd = new Random();

            int Cont1 = 0; int Cont2 = 0; int Cont3 = 0; int Cont4 = 0; int Cont5 = 0;
            int Cont6 = 0; int Cont7 = 0; int Cont8 = 0; int Cont9 = 0; int Cont10 = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(1, 11);
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 1){
                    Cont1++;
                }

                if (numeros[i] == 2)
                {
                    Cont2++;
                }

                if (numeros[i] == 3)
                {
                    Cont3++;
                }


                if (numeros[i] == 4)
                {
                    Cont4++;
                }

                if (numeros[i] == 5)
                {
                    Cont5++;
                }

                if (numeros[i] == 6)
                {
                    Cont6++;
                }

                if (numeros[i] == 7)
                {
                    Cont7++;
                }

                if (numeros[i] == 8)
                {
                    Cont8++;
                }

                if (numeros[i] == 9)
                {
                    Cont9++;
                }

                if (numeros[i] == 10)
                {
                    Cont10++;
                }
            }


            Console.WriteLine("Numeros 1: " + Cont1);
            Console.WriteLine("Numeros 2: " + Cont2);
            Console.WriteLine("Numeros 3: " + Cont3);
            Console.WriteLine("Numeros 4: " + Cont4);
            Console.WriteLine("Numeros 5: " + Cont5);
            Console.WriteLine("Numeros 6: " + Cont6);
            Console.WriteLine("Numeros 7: " + Cont7);
            Console.WriteLine("Numeros 8: " + Cont8);
            Console.WriteLine("Numeros 9: " + Cont9);
            Console.WriteLine("Numeros 10: " + Cont10);

        }
    }
}
