namespace ProyectoFinalDI.Models
{
    /// <summary>
    /// Clase con la informacion con la que se hara el informe
    /// </summary>
    public class RegistroTemperatura
    {
        /// <summary>
        /// Almacena la temperatura de la medicion 
        /// </summary>
        public double TEMP_ACT { get; set; }

        /// <summary>
        /// Almacena la hora de la medicion
        /// </summary>
        public int HORA { get; set; }

        /// <summary>
        /// Almacena el minuto de la medicion
        /// </summary>
        public int MINUT { get; set; }

        /// <summary>
        /// Almacena la estancia en la que se ha medido la temperatura
        /// </summary>
        public string COD_EST { get; set; }

        /// <summary>
        /// Almacena la fecha de la medicion
        /// </summary>
        public DateTime FECHA { get; set; }

        /// <summary>
        /// Almacena el string completo de la fecha de la medicion
        /// </summary>
        public string FechaHoraFormateada => $"{FECHA:dd/MM} {HORA:D2}:{MINUT:D2}";//Mezcla texto Coge campo y lo formatea {CAMPO:FORMATO}
    }
}