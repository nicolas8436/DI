using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
                string cadenaConexion = $"server={servidor}; port={puerto}; user id = {usuario}; password={passwd}; database=world; Allow Zero Datetime = True; CHARSET = UTF8";
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

        public DataTable ObtenerGrid()
        {
            try {

                DataSet dataSet = new DataSet();

                
                using (var command = new MySqlCommand("SELECT * FROM country", conexion))
                using (var adapter = new MySqlDataAdapter(command))
                {
                    AbrirConexion();
                    adapter.Fill(dataSet, "country");
                    CerrarConexion();

                    return dataSet.Tables["country"];
                }

            } catch (MySqlException e) 
            {
                Console.WriteLine("Error al obtener el grid");
                return null;

            }
        }

        public DataTable obtenerDatos(String codigo)
        {
            try
            {
                DataSet dataSet = new DataSet();

                string query = @"SELECT 
                            CountryCode as 'Código País',
                            Name as 'Nombre',
                            District as 'Distrito',
                            Population as 'Población'
                         FROM city 
                         WHERE CountryCode = @codigoPais";

                using (var command = new MySqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@codigoPais", codigo);

                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        AbrirConexion();
                        adapter.Fill(dataSet, "city");
                        CerrarConexion();

                        return dataSet.Tables["city"];
                    }
                }
            }
            catch (MySqlException e)
            {
                return null;
            }
        }

        public bool AgregarCiudad(string nombre, string codigoPais, string distrito, int poblacion)
        {
            try
            {
                string query = @"INSERT INTO city 
                       (Name, CountryCode, District, Population) 
                       VALUES 
                       (@Nombre, @CodigoPais, @Distrito, @Poblacion)";

                using (var command = new MySqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@CodigoPais", codigoPais);
                    command.Parameters.AddWithValue("@Distrito", distrito);
                    command.Parameters.AddWithValue("@Poblacion", poblacion);

                    AbrirConexion();
                    int filasAfectadas = command.ExecuteNonQuery();
                    CerrarConexion();

                    return filasAfectadas > 0;
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al agregar la ciudad: " + e.Message);
                return false;
            }
        }

    }
}
