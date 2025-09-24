class Program
{
    static void Main(string[] args)
    {
        int edad;
        string nombre;
        Console.WriteLine("Introduce tu nombre: ");
        nombre = Console.ReadLine();
        Console.WriteLine("Introduce tu edad: ");
        // Converted string to int
        edad = Convert.ToInt32(Console.ReadLine());
        if (edad >= 18)
        {
            Console.WriteLine("Hola " + nombre + "!" + " Tu puedes votar");
        }
        else
        {
            Console.WriteLine("Hola {0} lo siento, pero no puedes votar con {1} años ", nombre, edad);
        }
    }

}