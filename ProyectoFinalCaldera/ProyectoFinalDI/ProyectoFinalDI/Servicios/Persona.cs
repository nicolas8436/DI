
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDI.Servicios
{

    /// <summary>
    /// Singeltone para el rol de la persona registrada
    /// </summary>
    internal class Persona
    {
        /// <summary>
        /// Almacena la instancia del Singeltone
        /// </summary>
        private static Persona _instance;

        /// <summary>
        /// Obtiene la instancia del singeltone
        /// </summary>
        public static Persona Instance => _instance ??= new Persona();

        /// <summary>
        /// Informacion a cerca del rol del usuario actual
        /// </summary>
        private int id_rol;

        /// <summary>
        /// Constructor de la clase persona
        /// </summary>
        public Persona() {}


        /// <summary>
        /// Metodo para cambiar el rol
        /// </summary>
        /// <param name="rol">Introduccion de un nuevo rol</param>
        public void SetRol(int rol) {
            id_rol = rol;        
        }

        /// <summary>
        /// Metodo que devuelve el rol actual 
        /// </summary>
        /// <returns>Numero entero que indica el nivel de permiso</returns>
        public int GetRol() {
            return id_rol;
        }

        }
}
