namespace Ejercicio1Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> listaColores = new List<string>();

            Console.WriteLine(listaColores.Count);//Igual q el length

            listaColores.Add("Amarillo");
            listaColores.Add("Azul");
            listaColores.Add("Rojo");
            listaColores.Add("Negro");

            Console.WriteLine(listaColores.Count);
            Console.WriteLine(listaColores.IndexOf("Azul"));//Devuelve la primera posicion del string
                                                            //Para devolver la ultima usar lastIndexOf
            Console.WriteLine(listaColores[listaColores.IndexOf("Azul")]);
            Console.WriteLine(listaColores[1]);


            for (int i = 0; i < listaColores.Count; i++) {
                Console.WriteLine(listaColores[i]);
            }


            Console.ReadLine();
        }
    }
}
//.Remove elimina objetos
//.RemoveAt elimina posiciones de la lista
//.Clear limpia la lista entera
