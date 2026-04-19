using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDI.Servicios
{
    public class ApiWheather
    {
        public TempHumedad Main { get; set; }
        public List<InfoExtra> Weather { get; set; }
        public string Name { get; set; }
    }

    public class TempHumedad
    {
        public double Temp { get; set; }
        public int Humidity { get; set; }
    }

    public class InfoExtra
    {
        public string Icon { get; set; }
    }
}
