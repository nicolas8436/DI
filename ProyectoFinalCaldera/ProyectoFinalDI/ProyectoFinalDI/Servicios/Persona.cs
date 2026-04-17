
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDI.Servicios
{
    internal class Persona
    {
        private static Persona _instance;
        public static Persona Instance => _instance ??= new Persona();


        private String nombre;
        private int id_rol;

        public Persona() {}

        public void SetRol(int rol) {
            id_rol = rol;        
        }

        public int GetRol() {
            return id_rol;
        }

        }
}
