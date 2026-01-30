using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_PruebasAPI.BaseDatos
{
    public class BBDD
    {   
        MySqlConnection conn;
        MySqlCommand cmm;
        MySqlDataReader reader;


        public void CerrarConexion()
        {
            conn.Close();
        }

        public void AbrirConexion()
        {
            if (conn != null)
            {
                conn.Close();
            }
            conn.Open();
        }

        public bool Conectar(string servidor, string puerto, string usuario, string passwd)
        {
            try
            {
                string cadenaConexion = $"server=192.168.0.200; port=3386; user id = Nicolas; password=1234;database=world; Allow Zero Datetime = True; CHARSET = UTF8";
                conn = new MySqlConnection(cadenaConexion);

                AbrirConexion();
                CerrarConexion();

                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al conectar a la base de datos");
                return false;
            }

        }
    }
}
