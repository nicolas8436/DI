using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Colas
{
    public class Producto
    {
        private int cantidad;
        private double precio;

        public Producto(int cantidad, double precio)
        {
            this.cantidad = cantidad;
            this.precio = precio;
        }
        public int getCantidad()
        {
            return cantidad;
        }
        public double getPrecio()
        {
            return precio;
        }
        public double precioFinal()
        {
            return Convert.ToDouble(this.precio * this.cantidad);
        }
    }
}
