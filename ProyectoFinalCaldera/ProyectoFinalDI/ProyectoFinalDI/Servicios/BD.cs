using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace ProyectoFinalDI.Servicios
{
    public class BD
    {
        private static BD _instance;
        public static BD Instance => _instance ??= new BD();

        private MySqlConnection conector;
        private MySqlCommand comando;
        private string cadConexion = "Server=127.0.0.1;Database=DI_AULA;User=nicolas;Password=nicolas;";


        private BD() { }
        public bool AbrirConexion(Page page) {//Abrir conexion ======================================================
        try{
                conector = new MySqlConnection(cadConexion);
                conector.ConnectionString = cadConexion;
                conector.Open();
                return true;

        }catch(MySqlException e){
                page.DisplayAlert("Error", "Error al conectarse al servidor", "OK");
                return false;
            }
        }//Abrir Conexion ===========================================================================================

        public bool CerrarConexion(Page page)//Cerrar conexion ======================================================
        {
            try
            {
                if (conector != null) { 

                conector.Close();
                page.DisplayAlert("Exito", "Conexion cerrada correctamente", "OK");
                return true;

                } else {

                    page.DisplayAlert("Error", "Primero abre una conexion", "OK");

                }
                return false;
            }
            catch (MySqlException e)
            {
                page.DisplayAlert("Error", "Error al cerrar la conexion", "OK");
                return false;
            }
        }//Cerrar conexion ============================================================================================

        public bool InicioS(Page p, String usuario, String contraseña)//Inicio de sesion =================================================================
        {
            try {
                int count;
                using (var comando = new MySqlCommand("SELECT COUNT(*) FROM USUARIOS WHERE EMAIL = @usuario AND PASSWORD = @pass", conector)) { 
                
                    //Parametros
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@pass", contraseña);

                    //Convertir a numero para ver si hay alguno
                    count = Convert.ToInt32(comando.ExecuteScalar());
                }
                    return count > 0;

            }catch (MySqlException e) {

                p.DisplayAlert("Error", "Error al Iniciar la sesion", "OK");
                return false; 
            }
            
        }//Inicio de sesion ==============================================================================================================================

        public bool Registro(Page p, String usuario, String contraseña, String nombre, String apellidos)//Registro =================================================================
        {
            int filas;
            try
            {
                
                using (var comando = new MySqlCommand("SELECT COUNT(*) FROM USUARIOS WHERE EMAIL = @usuario", conector)) { 

                    //Parametros
                    comando.Parameters.AddWithValue("@usuario", usuario);

                    //Convertir a numero para ver si hay alguno
                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    if (count != 0)
                    {
                        p.DisplayAlert("Error", "Ese usuario ya existe", "OK");
                        return false;
                    }

                }
                    using (var comando = new MySqlCommand("INSERT INTO USUARIOS (EMAIL, NOMBRE, APELLIDOS, PASSWORD, ID_ROL) VALUES (@usuario, @nombre, @apellidos, @pass, 3)", conector)) { 

                        //Parametros
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@pass", contraseña);
                        comando.Parameters.AddWithValue("@apellidos", apellidos);
                        comando.Parameters.AddWithValue("@nombre", nombre);

                        filas = comando.ExecuteNonQuery();
                    }

                    if (filas > 0)  // ← Verificar que insertó
                    {
                        p.DisplayAlert("Usuario Registrado", "Usuario registrado correctamente", "OK");
                        return true;
                    }
                    else
                    {
                        p.DisplayAlert("Error", "No se pudo registrar el usuario", "OK");
                        return false;
                    }


            }
            catch (MySqlException e)
            {

                p.DisplayAlert("Error", "Error al Iniciar la sesion", "OK");
                return false;
            }
        }//Registro ==============================================================================================================================


        //TEMPERATURAS************************************************************************************************************************

        //Confort=============================================================================================================================
        public String Temp_Conf(String aula, Page p)
        {
            try
            {
                using (var comando = new MySqlCommand("SELECT TEMP FROM TEMP_PROG WHERE COD_EST = @aula ORDER BY FECHA DESC, HORA DESC, MINUT DESC LIMIT 1;", conector))
                {

                    //Parametros
                    comando.Parameters.AddWithValue("@aula", aula);
                   

                    //Convertir a String
                    String temp = comando.ExecuteScalar().ToString();

                    if (temp == null)
                    {
                        p.DisplayAlert("Error", "Error al buscar el aula seleccionada", "OK");
                    }
                    return temp;
                }
            }
            catch (MySqlException e) {
                p.DisplayAlert("Error", e.Message, "OK");
                return null;
            }
        }
        //Confort=============================================================================================================================

        //Actual==============================================================================================================================
        public String Temp_Act(String aula, Page p)
        {
            try
            {
                using (var comando = new MySqlCommand("SELECT TEMP_ACT FROM LECTURAS WHERE COD_EST = @aula ORDER BY FECHA DESC, HORA DESC, MINUT DESC LIMIT 1;", conector))
                {

                    //Parametros
                    comando.Parameters.AddWithValue("@aula", aula);


                    //Convertir a String
                    String temp = comando.ExecuteScalar().ToString();

                    if (temp == null)
                    {
                        p.DisplayAlert("Error", "Error al buscar el aula seleccionada", "OK");
                    }
                    return temp;
                }
            }
            catch (MySqlException e) {
                p.DisplayAlert("Error", e.Message, "OK");
                return null;
            }
        }
        //Actual==============================================================================================================================

        //Cambio confort =====================================================================================================================
        public bool Cambio_Conf(String aula, Page p, String temp)//Registro =================================================================
        {
            int filas;
            try
            {
                using (var comando = new MySqlCommand("INSERT INTO TEMP_PROG (TEMP, FECHA, HORA, MINUT, SEG, COD_EST) VALUES (@Temp, CURDATE(), HOUR(NOW()), MINUTE(NOW()), SECOND(NOW()), @aula);", conector))
                {

                    //Parametros
                    comando.Parameters.AddWithValue("@aula", aula);
                    comando.Parameters.AddWithValue("@Temp", temp);

                    filas = comando.ExecuteNonQuery();
                }

                if (filas == 1)
                {
                    
                    return true;
                }
                else
                {
                    return false;
                }



            }
            catch (MySqlException e)
            {

                p.DisplayAlert("Error", "Error al modificar la temperatura de confort", "OK");
                return false;
            }
        }
        //Cambio confort =====================================================================================================================

        //TEMPERATURAS************************************************************************************************************************

        // Sacar Aulas ===========================================================================================================================
        public List<string> SacarAulas(Page p)
        {
            var lista = new List<string>();
            try
            {
                using (var comando = new MySqlCommand("SELECT COD_EST FROM ESTANCIAS", conector))
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                        lista.Add(reader.GetString(0));
                }
            }
            catch (MySqlException e)
            {
                p.DisplayAlert("Error", "Error al cargar las aulas", "OK");
            }
            return lista;
        }
        // Sacar Aulas ===========================================================================================================================
    }
}
