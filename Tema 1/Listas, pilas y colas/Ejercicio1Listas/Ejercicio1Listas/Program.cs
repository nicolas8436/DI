namespace Ejercicio1Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nombrePersona = new List<string>();
            List<int> longitudNombre = new List<int>();

            String nombre; int longitud = 0;

            

            do
            {
                Console.WriteLine("introduzca el nombre(fin para salir)");
                nombre = Console.ReadLine();


                if (nombre == "fin" || nombre == "Fin")
                {
                    Console.WriteLine("Saliendo del programa");
                }
                else
                {
                    nombrePersona.Add(nombre);
                    longitudNombre.Add(nombre.Length);

                }


            } while (nombre != "fin" && nombre != "Fin");

            for (int i = 0; i < nombrePersona.Count; i++)
            {
                Console.WriteLine(nombrePersona[i] + " "+ longitudNombre[i]);
            }
        }
    }
}
