using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDI
{

    /// <summary>
    /// Clase que almacena distintos datos de la caldera/Aula para mostrar la configuracion de un aula
    /// </summary>
    public class AulaClase
    {
        /// <summary>
        /// Propiedad para almacenar el nombre de un aula
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Propiedad que almacena la temperatura de un aula
        /// </summary>
        public string TempActual { get; set; }

        /// <summary>
        /// Propiedad que alamacena la teperatura de confort de un aula
        /// </summary>
        public string TempConfort { get; set; }

        /// <summary>
        /// Propiedad que almacena el estado de la caldera
        /// </summary>
        public string EstadoCaldera { get; set; }
    }
}
