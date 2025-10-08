namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Boleto[] ListaBoletos = new Boleto[100];
            bool salir = true; 
            for (int i = 0; i < ListaBoletos.Length; i++)
            {
                do
                {
                    salir = false;
                    ListaBoletos[i] = new Boleto();
                    for (int j = 0; j < i; j++)
                    {
                        if (ListaBoletos[i].Equals(ListaBoletos[j]))//Si coinciden
                        {
                            salir = true;
                        }
         

                        
                    }
                } while (salir == true);



            }

            for (int i = 0; i < ListaBoletos.Length; i++)
            {
                Console.WriteLine(string.Join(" ", ListaBoletos[i].ObtenerNumeros()));
            }

        }
    }
}
