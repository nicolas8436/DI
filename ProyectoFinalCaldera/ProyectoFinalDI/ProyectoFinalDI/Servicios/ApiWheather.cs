using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

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

    /// <summary>
    /// Servicio para gestionar las peticiones de clima a la API
    /// </summary>
    public class ClimaServicio
    {
        public async Task<ApiWheather> ObtenerClimaAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://api.openweathermap.org/data/2.5/weather?q=Cuenca,es&appid=c64a0e8b3e404ede2c9ee219f5719c7c&lang=es&units=metric";

                var peticion = await client.GetAsync(url);

                if (peticion.IsSuccessStatusCode)
                {
                    return await peticion.Content.ReadAsAsync<ApiWheather>();
                }

                return null;
            }
        }
    }
}

