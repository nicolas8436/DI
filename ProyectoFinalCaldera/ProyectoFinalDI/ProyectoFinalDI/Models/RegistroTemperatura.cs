namespace ProyectoFinalDI.Models
{
    public class RegistroTemperatura
    {
        public double TEMP_ACT { get; set; }
        public int HORA { get; set; }
        public int MINUT { get; set; }
        public string COD_EST { get; set; }
        public DateTime FECHA { get; set; }
        public string FechaHoraFormateada => $"{FECHA:dd/MM} {HORA:D2}:{MINUT:D2}";
    }
}