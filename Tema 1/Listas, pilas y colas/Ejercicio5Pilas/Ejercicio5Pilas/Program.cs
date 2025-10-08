namespace Ejercicio5Pilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Informe> pilaInformes = new Stack<Informe>();
            Random rnd = new Random();

            int codigo = 0; int tarea = 0;
            

            for (int i = 0; i < 10; i++)
            {
                codigo++; tarea = rnd.Next(0, 3);
                Informe informe = new Informe(codigo, tarea);

                pilaInformes.Push(informe);
            }

            for (int i = 0; i < 3; i++)
            {
                Informe informe = pilaInformes.Pop();
                Console.WriteLine(informe.ToString());
                

            }

            for (int i = 0; i < 5; i++)
            {
                codigo++; tarea = rnd.Next(0, 3);
                Informe informe = new Informe(codigo, tarea);

                pilaInformes.Push(informe);
            }

            while (pilaInformes.Count > 0)
            {
                Informe informe = pilaInformes.Pop();
                Console.WriteLine(informe.ToString());
            }
        }
    }
}
