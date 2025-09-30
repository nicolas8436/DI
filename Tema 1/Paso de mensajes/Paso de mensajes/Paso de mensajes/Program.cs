using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Paso_de_mensajes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Pepe", 18);
            Persona persona2 = new Persona("Paco", 20);
            Persona persona3 = new Persona("Antonio", 22);
            Persona persona4 = new Persona("Aurora", 24);
            Persona persona5 = new Persona("Maria", 26);

            Coche coche1 = new Coche("Opel", "Astra", "Amarillo", persona1);

            Console.WriteLine(persona1.ToString());
            Console.WriteLine(coche1.ToString());

            persona1.CambioEdad(19);
            Console.WriteLine(persona1.ToString());

            coche1.CambioProp(persona2);//Le pasamos el nuevo propietario 
            Console.WriteLine(coche1.ToString());



            Console.ReadLine();

     

        }
    }
}

/*
 Se puede hacer que en el constructor de coche se cree el objeto lo que cambia
es q al declarar el objeto coche en lugar de persona1 hay q poner los valores en su lugar 
Para eso hay q cambiar "this.Propietario = Propietario" por "this.propietario = new Persona (nombre,edad)" 
*/
