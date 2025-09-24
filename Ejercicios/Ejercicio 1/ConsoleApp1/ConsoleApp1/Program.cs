class Program

{

    static void Main(string[] args)

    {

        int numero; int cont = 0; int contpositivos = 0;

            try

            {
                do
                {
                    Console.WriteLine("Introduce un numero");

                    numero = Int32.Parse(Console.ReadLine());
                    if (numero >= 0)
                    {
                        contpositivos++;
                    }

                    cont++;


                } while (numero != 0);


                Console.WriteLine("Has introducido un total de " + cont + " y son positivos " + contpositivos);
                Console.WriteLine("Has introducido un total de {0} y son positivos {1}", cont, contpositivos);
            }
            catch (FormatException)

            {

                Console.WriteLine("No has introducido un numero");
                
            }
        

    }

}
