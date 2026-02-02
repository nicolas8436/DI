using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Maui_PruebasAPI.Servicios
{
    class Geolocalizacion
    {
        public Geolocalizacion() { }

        public async Task<List<Modelos.Localidad>> ObtenerLocalidades(string localidadBuscar)
        {
            List<Modelos.Localidad> listaCiudadesEncontradas = new List<Modelos.Localidad>();
            JsonDocument jsonRespuesta;

            var direccion = new Uri("https://nominatim.openstreetmap.org/");
            using (var httpClient = new HttpClient { BaseAddress = direccion })
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "ProyectoWeather/1.0");
                string consulta = $"search?q={localidadBuscar}&format=json";
                try
                {
                    using (var response = await httpClient.GetAsync(consulta))
                    {
                        string respuesta = await response.Content.ReadAsStringAsync();
                        jsonRespuesta = JsonDocument.Parse(respuesta);
                        for (int i = 0; i < jsonRespuesta.RootElement.GetArrayLength(); i++)
                        {
                            /*Modelos.Localidad nuevaLocalidad = new Modelos.Localidad(//Hay q crear localidad
                                jsonRespuesta.RootElement[i].GetProperty("lat").ToString(),
                                jsonRespuesta.RootElement[i].GetProperty("lon").ToString(),
                                jsonRespuesta.RootElement[i].GetProperty("name").ToString(),
                                jsonRespuesta.RootElement[i].GetProperty("type").ToString(),
                                jsonRespuesta.RootElement[i].GetProperty("display_name").ToString());
                            listaCiudadesEncontradas.Add(nuevaLocalidad);*/

                        }
                        return listaCiudadesEncontradas;
                    }
                }
                catch (Exception ex)
                {
                    return listaCiudadesEncontradas;

                }


            }
        }
    }
}
