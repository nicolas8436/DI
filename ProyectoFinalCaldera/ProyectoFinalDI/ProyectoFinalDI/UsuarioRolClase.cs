using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDI
{

    /// <summary>
    /// Clase para almacenar la informacion de los usuarios, almacenarlos en lista para la ListaUsr o para saber el usuario seleccionado en RegistroSuperADmin
    /// </summary>
    public class UsuarioRolClase
    {
        /// <summary>
        /// Propiedad para almacenar el email de un usuario
        /// </summary>
        public string email {  get; set; }

        /// <summary>
        /// Propiedad para almacenar el nombre de un usuario
        /// </summary>
        public string nombre { get; set; }

        /// <summary>
        /// Propiedad para almacenar el apellido de un usuario
        /// </summary>
        public string apellido { get; set;}

        /// <summary>
        /// Propiedad que se usa para almacenar el rol de un usuario
        /// </summary>
        public string rol { get; set; }
    }
}
