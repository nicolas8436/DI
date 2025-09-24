namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dado; int contador = 0;
            Random numero = new Random();
            for(int i = 0 ; i < 50 ; i++)
            {
                int aleatorio = numero.Next(1,7);
                if (aleatorio == 1)
                {
                    contador++;
                }
            }
            Console.WriteLine(contador);
        }
    }
}
