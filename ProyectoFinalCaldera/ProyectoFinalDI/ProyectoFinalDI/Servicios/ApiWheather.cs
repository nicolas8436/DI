using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDI.Servicios
{
    /// <summary>
    /// Clase para almacenar los datos que leemos de la Api
    /// </summary>
    public class ApiWheather
    {
        /// <summary>
        /// Informacion Principal
        /// </summary>
        public TempHumedad Main { get; set; }

        /// <summary>
        /// Icono
        /// </summary>
        public List<InfoExtra> Weather { get; set; }

        /// <summary>
        /// Nombre de la ubicacion en este caso Cuenca
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// Case que almacena la temperatura y la humedad hambiente
    /// </summary>
    public class TempHumedad
    {
        public double Temp { get; set; }
        public int Humidity { get; set; }
    }

    /// <summary>
    /// Clase para el icono
    /// </summary>
    public class InfoExtra
    {
        public string Icon { get; set; }
    }
}
