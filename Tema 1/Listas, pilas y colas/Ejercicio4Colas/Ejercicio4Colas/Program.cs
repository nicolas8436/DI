namespace Ejercicio4Colas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<Producto> colaCaja = new Queue<Producto>();
            int cantidad = 0; double precio = 0;  int cola = numAleatorio(1, 9);



            for (int i = 0; i < cola; i++)
            {

                cantidad = numAleatorio(1, 11);
                precio = precioProducto();

                Producto producto = new Producto(cantidad, precio);
               
                colaCaja.Enqueue(producto);
            }

            int cont = 0;
            Console.WriteLine("***********Cantidad********Precio*******Total");
            while (colaCaja.Count > 0)
            {

                cont++;
                Producto producto = colaCaja.Dequeue();
                int CantidadDeQ = producto.getCantidad();
                double precioDeQ = producto.getPrecio();
                double precioTotal = producto.precioFinal();
                
                Console.WriteLine("Producto"+ cont +". "+ CantidadDeQ +"               "+precioDeQ.ToString("N2")+"        "+ precioTotal.ToString("N2"));

            }

        }



        public static int numAleatorio (int min, int max) 
        {
            Random rnd = new Random();
            int aleatorio = rnd.Next(min, max);
            return aleatorio;
        }

        public static double precioProducto()
        {
            
            double precioProducto = numAleatorio(100, 5000)/100.0;
            return precioProducto;
        }
    }
}
