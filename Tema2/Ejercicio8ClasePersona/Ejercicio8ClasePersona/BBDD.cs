using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio8ClasePersona;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace Ejercicio7Clase
{
    public class BBDD
    {
        private MySqlConnection conexion;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private DataSet dataSet;

        public void CerrarConexion() 
        { 
                conexion.Close();
        }

        public void AbrirConexion()
        {
            if (conexion != null)
            {
                conexion.Close();
            }
            conexion.Open();
        }

        public bool Conectar(string servidor, string puerto, string usuario, string passwd)
        {
            try
            {
                string cadenaConexion = $"server={servidor}; port={puerto}; user id = {usuario}; password={passwd};database=person; Allow Zero Datetime = True; CHARSET = UTF8";
                conexion = new MySqlConnection(cadenaConexion) ;

                AbrirConexion();
                CerrarConexion();
                
                return true;
            }
            catch(MySqlException e)
            {
                Console.WriteLine("Error al conectar a la base de datos");
                return false;
            }

        }

        public List<Persona> LeerBBDD()
        {

            List<Persona> listaPersonas = new List<Persona>();
            MySqlCommand command = new MySqlCommand("Select * FROM persona", conexion);
            MySqlDataReader lector;

            AbrirConexion();
            lector = command.ExecuteReader();
            

            while (lector.Read())
            {
                Persona nuevaPers = new Persona(lector[0].ToString(), lector[1].ToString(), lector[2].ToString());
                listaPersonas.Add( nuevaPers );
            }
            lector.Close();
            CerrarConexion();

            return listaPersonas ;
        }





    }
}
