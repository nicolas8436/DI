namespace EjercicioListas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listaPersona = new List<Persona>();

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
                    
                    listaPersona.Add(new Persona(nombre, nombre.Length));


                }


            } while (nombre != "fin" && nombre != "Fin");

            for (int i = 0; i < listaPersona.Count; i++)
            {
                Persona persona = listaPersona[i];
                Console.WriteLine(persona.nombre + " " + persona.longitudNombre);
            }
        }
    }
}
