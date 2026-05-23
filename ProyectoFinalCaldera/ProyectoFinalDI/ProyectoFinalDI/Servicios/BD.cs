using MySqlConnector;
using ProyectoFinalDI.Models;
using ProyectoFinalDI.ViewModel;
using ProyectoFinalDI.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDI.Servicios
{
    /// <summary>
    /// Singletone de la Base de Datos
    /// </summary>
    public class BD
    {

        /// <summary>
        /// Almacena la instancia del Singeltone
        /// </summary>
        private static BD _instance;

        /// <summary>
        /// Obtiene la instancia del singeltone
        /// </summary>
        public static BD Instance => _instance ??= new BD();

        /// <summary>
        /// Conexion a la BD
        /// </summary>
        private MySqlConnection conector;

        /// <summary>
        /// Reperesentacion de la sentencia query que se envia a la BD
        /// </summary>
        private MySqlCommand comando;

        /// <summary>
        /// Reperesenta el email(Clave principal) del usuario registrado 
        /// </summary>
        private String actual;

        /// <summary>
        /// Cadena de conexion a la BD
        /// </summary>
        private string cadConexion = "Server=192.168.0.200;Database=BBIoT_Nicolas;User=Nicolas;Password=1234;"; //Usr y Contraseña clase nicolas
        //private string cadConexion = "Server=127.0.0.1;Database=DI_AULA;User=nicolas;Password=nicolas;"; //Usr y Contraseña local nicolas

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        private BD() { }

        /// <summary>
        /// Sirve para actualizar la informacion referente al usuario registrado
        /// </summary>
        /// <param name="act">email del usuario registrado</param>
        public void setActual(String act)
        {
            actual = act;
        }

        /// <summary>
        /// Abre la conexion con la BD 
        /// </summary>
        /// <param name="page">Pagina desde la que se abre la conexion</param>
        /// <returns>Devuelve si la conexion se ha abierto correctamente (True) o no (False)</returns>
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

        /// <summary>
        /// Cierra la conexion con la base de datos
        /// </summary>
        /// <param name="page">Representa la pagina desde la que se cierra la conexion</param>
        /// <returns>Devuelve true si la conexion se ha cerrado correctamente o false si ha ocurrido algun problema +</returns>
        public bool CerrarConexion(Page page)//Cerrar conexion ======================================================
        {
            try
            {
                if (conector != null) { 

                conector.Close();
                //page.DisplayAlert("Exito", "Conexion cerrada correctamente", "OK");
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

        /// <summary>
        /// Inicia sesion en la aplicacion comprueba si las credenciales son validas y estan en la BD
        /// </summary>
        /// <param name="p">Pagina desde la que se inicia sesion</param>
        /// <param name="usuario">Email con el que se quiere iniciar sesion</param>
        /// <param name="contraseña">Contraseña con el que se quiere iniciar sesion</param>
        /// <returns>Devuelve true si existe en la BD o false en caso de que no exista u ocurra algun error </returns>
        public bool InicioS(Page p, String usuario, String contraseña)//Inicio de sesion =================================================================
        {
            try {
                int count;
                using (var comando = new MySqlCommand("SELECT COUNT(*) FROM USUARIOS WHERE EMAIL = @usuario AND PASSWORD = @pass", conector)) { 
                
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@pass", contraseña);

                    count = Convert.ToInt32(comando.ExecuteScalar());
                }

                this.actual = usuario;
                    return count > 0;

            }catch (MySqlException e) {

                p.DisplayAlert("Error", "Error al Iniciar la sesion", "OK");
                return false; 
            }
            
        }//Inicio de sesion ==============================================================================================================================

        /// <summary>
        /// Metodo para registrar a un nuevo usuario en la BD
        /// </summary>
        /// <param name="p">Pagina actual</param>
        /// <param name="usuario">Nuevo email de usuario</param>
        /// <param name="contraseña">Contraseña del usuario</param>
        /// <param name="nombre">Nombre del usuario</param>
        /// <param name="apellidos">Aoellidos del usuario</param>
        /// <returns>Devuelve true si se ha podido registrar con exito false en caso de que ocurra algun problema o las credenciales no sean validas</returns>
        public bool Registro(Page p, String usuario, String contraseña, String nombre, String apellidos)//Registro =================================================================
        {
            int filas;
            try
            {
                
                using (var comando = new MySqlCommand("SELECT COUNT(*) FROM USUARIOS WHERE EMAIL = @usuario", conector)) { 

                    comando.Parameters.AddWithValue("@usuario", usuario);

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

                    if (filas > 0)  // Verificar que insertó
                    {
                        p.DisplayAlert("Usuario Registrado", "Usuario registrado correctamente", "OK");
                        this.actual = usuario;
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


        //Datos************************************************************************************************************************

        //Confort=============================================================================================================================

        /// <summary>
        /// Metodo para sacar la temperatura de confort de un aula
        /// </summary>
        /// <param name="aula">Aula sobre la que se quiere conocer la temperatura de confort</param>
        /// <param name="p">Pagina actual</param>
        /// <returns>Devuelve un string con la temperatura de confort</returns>
        public String Temp_Conf(String aula, Page p)
        {
            try
            {
                using (var comando = new MySqlCommand("SELECT TEMP FROM TEMP_PROG WHERE COD_EST = @aula ORDER BY FECHA DESC, HORA DESC, MINUT DESC LIMIT 1;", conector))
                {

                    //Parametros
                    comando.Parameters.AddWithValue("@aula", aula);


                    //Convertir a String
                    var temp = comando.ExecuteScalar();

                    if (temp == null)
                    {
                        return "0";
                    }

                    return temp.ToString();
                }
            }
            catch (MySqlException e) {
                p.DisplayAlert("Error", e.Message, "OK");
                return null;
            }
        }
        //Confort=============================================================================================================================

        //Actual==============================================================================================================================
        /// <summary>
        /// Metodo para sacar la temperatura actual de un aula
        /// </summary>
        /// <param name="aula">Aula sobre la que queremos saber la temperatura actual</param>
        /// <param name="p">Pagina actual</param>
        /// <returns>Devuelve un string con la temperatura actual</returns>
        public String Temp_Act(String aula, Page p)
        {
            try
            {
                using (var comando = new MySqlCommand("SELECT TEMP_ACT FROM LECTURAS WHERE COD_EST = @aula ORDER BY FECHA DESC, HORA DESC, MINUT DESC LIMIT 1;", conector))
                {

                    comando.Parameters.AddWithValue("@aula", aula);


                    var result = comando.ExecuteScalar();

                    if (result == null)
                    {
                        return "0"; 
                    }
                   
                    return result.ToString();
                }
            }
            catch (MySqlException e) {
                p.DisplayAlert("Error", e.Message, "OK");
                return null;
            }
        }
        //Actual==============================================================================================================================

        //Actual==============================================================================================================================

        /// <summary>
        /// Metodo para sacar el estado de la valvula de un aula concreta
        /// </summary>
        /// <param name="aula">Aula de la que queremos saber el estado de la valvula</param>
        /// <param name="p">Pagina actual</param>
        /// <returns>Nos devuelve un string con el estado de la valvula</returns>
        public String EstadoCal(String aula, Page p)
        {
            try
            {
                using (var comando = new MySqlCommand(
                    "SELECT EST_VALVULA FROM ESTADOS_VAL WHERE COD_EST = @aula ORDER BY FECHA_INI DESC, HORA DESC, MINUT DESC, SEG DESC LIMIT 1;",
                    conector))
                {
                    comando.Parameters.AddWithValue("@aula", aula);

                    var result = comando.ExecuteScalar();

                    if (result == null)
                        return "Sin datos";

                    string estado = result.ToString();

                    if (estado == "C")
                        return "Cerrado";
                    else if (estado == "O")
                        return "Abierto";
                    else
                        return estado;
                }
            }
            catch (MySqlException e)
            {
                p.DisplayAlert("Error", e.Message, "OK");
                return null;
            }
        }
        //Actual==============================================================================================================================

        //Cambio confort =====================================================================================================================

        /// <summary>
        /// Metodo para actualizar la temperatura de confort de un aula concreta
        /// </summary>
        /// <param name="aula">Aula sobre la que se quiere actualizar la temperatura de confort</param>
        /// <param name="p">Pagina actual</param>
        /// <param name="temp">Nueva temp de confort</param>
        /// <returns>Devuelve true en caso de cambiar la temperatura de confort false en caso de que no se haya podido cambiar</returns>
        public bool Cambio_Conf(String aula, Page p, String temp)
        {
            int filas;
            try
            {
                using (var comando = new MySqlCommand("INSERT INTO TEMP_PROG (TEMP, FECHA, HORA, MINUT, SEG, COD_EST) VALUES (@Temp, CURDATE(), HOUR(NOW()), MINUTE(NOW()), SECOND(NOW()), @aula);", conector))
                {

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

        //Datos ************************************************************************************************************************

        // Obtener Aulas ===========================================================================================================================

        /// <summary>
        /// Metodo que nos da una lista con las distintas aulas del centro
        /// </summary>
        /// <param name="p">Pagina actul</param>
        /// <returns>Devuelve una lista con las aulas</returns>
        public List<AulaClase> ObtenerAulas(Page p)
        {
            var lista = new List<AulaClase>();
            var aulas = new List<string>();

            try
            {
                using (var comando = new MySqlCommand("SELECT COD_EST FROM ESTANCIAS", conector))
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        aulas.Add(reader.GetString(0));
                    }
                }

                foreach (var aula in aulas)
                {
                    lista.Add(new AulaClase
                    {
                        Nombre = aula,
                        TempActual = Temp_Act(aula, p) + "°C",
                        TempConfort = Temp_Conf(aula, p) + "°C",
                        EstadoCaldera = EstadoCal(aula, p)
                    });
                }
            }
            catch (MySqlException)
            {
                p.DisplayAlert("Error", "Error al cargar las aulas", "OK");
            }

            return lista;
        }
        // Obtener Aulas ===========================================================================================================================

        // Obtener Rol ===========================================================================================================================
        /// <summary>
        /// Metodo que nos da el rol del usuario que le pasemos
        /// </summary>
        /// <param name="p">Pagina actual</param>
        /// <param name="email">usuario del que queremos obtener el rol</param>
        /// <returns>Devuelve un entero con el rol del usuario</returns>
        public int ObtenerRol(Page p, String email)
        {
            int Rol = 3;
            try {
                int count;
                using (var comando = new MySqlCommand("SELECT ID_ROL FROM USUARIOS WHERE EMAIL = @email", conector))
                {

                    //Parametros
                    comando.Parameters.AddWithValue("@email", email);

                    //Convertir a numero para ver si hay alguno
                    count = Convert.ToInt32(comando.ExecuteScalar());
                }
                return count;

            } catch (MySqlException e) 
            {
                p.DisplayAlert("Error", "Error al obtener el rol, por seguridad se le dara el nivel mas bajo", "OK");
                return 3;
            }
            
        }
        // Obtener Rol ===========================================================================================================================


        // ObtenerUsuarios (y rol) ===============================================================================================================
        /// <summary>
        /// Metodo para obtener la lista de los uusarios en la BD
        /// </summary>
        /// <param name="p">Pagina actual </param>
        /// <returns>Devuelve una lista con los usuarios registrados</returns>
        public List<UsuarioRolClase> ObtenerUsuarios(Page p)
        {
            var lista = new List<UsuarioRolClase>();

            try
            {
                using (var comando = new MySqlCommand(
                    "SELECT NOMBRE, ID_ROL, EMAIL, APELLIDOS FROM USUARIOS",
                    conector))
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        int rol = reader.GetByte(1);
                        String tipoRol = "";
                        switch (rol)
                        {
                            case 1:
                                tipoRol = "SuperAdmin";
                                break;


                            case 2:
                                tipoRol = "Admin";
                                break;

                                
                            case 3:
                                tipoRol = "Usuario";
                                break;
                        }//Switch

                        lista.Add(new UsuarioRolClase
                        {
                            email = reader.GetString(2),
                            nombre = reader.GetString(0),
                            rol = tipoRol,
                            apellido = reader.GetString(3),
                        });
                    }
                }
            }
            catch (MySqlException)
            {
                p.DisplayAlert("Error", "Error al cargar usuarios", "OK");
            }

            return lista;
        }


        // ObtenerUsuarios (y rol) ===============================================================================================================

        // BorrarUsr ===============================================================================================================

        /// <summary>
        /// Metodo para eliminar usuarios de la BD
        /// </summary>
        /// <param name="p">Pagina actual</param>
        /// <param name="usuarioSeleccionado">Usuario seleccionado para eliminar a traves de su email (Clave primaria)</param>
        public void BorrarUsr(Page p, UsuarioRolClase usuarioSeleccionado){
            try
            {
                using (var comando = new MySqlCommand("DELETE FROM USUARIOS WHERE EMAIL = @email", conector))
                {

                    //Parametros
                    comando.Parameters.AddWithValue("@email", usuarioSeleccionado.email);

                    int filas = comando.ExecuteNonQuery();
                }

            }
            catch (MySqlException e)
            {
                p.DisplayAlert("Error", "Error al eliminar al usuario", "OK");
            }

        }

        // BorrarUsr ===============================================================================================================

        //Registro SuperAdmin =================================================================
        /// <summary>
        /// Metodo para registrar un usuario nuevo en la BD con un rol en especifico
        /// </summary>
        /// <param name="p">Pagina actual</param>
        /// <param name="usuario">Indica el email del nuevo usuario</param>
        /// <param name="contraseña">Indica la contraseña del nuevo usuario</param>
        /// <param name="nombre">Indica el nombre del nuevo usuario</param>
        /// <param name="apellidos">Indica los apellidos del nuevo usuario</param>
        /// <param name="rol">Indica el rol del nuevo usuario</param>
        /// <returns>Devuevle true en caso de que el usuario se haya guardado correctamente y false en caso contrario</returns>
        public bool Registro(Page p, String usuario, String contraseña, String nombre, String apellidos, int rol)
        {
            int filas;
            try
            {

                using (var comando = new MySqlCommand("SELECT COUNT(*) FROM USUARIOS WHERE EMAIL = @usuario", conector))
                {

                    comando.Parameters.AddWithValue("@usuario", usuario);

                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    if (count != 0)
                    {
                        p.DisplayAlert("Error", "Ese usuario ya existe", "OK");
                        return false;
                    }

                }
                using (var comando = new MySqlCommand("INSERT INTO USUARIOS (EMAIL, NOMBRE, APELLIDOS, PASSWORD, ID_ROL) VALUES (@usuario, @nombre, @apellidos, @pass, @rol)", conector))
                {

                    //Parametros
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@pass", contraseña);
                    comando.Parameters.AddWithValue("@apellidos", apellidos);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@rol", rol);

                    filas = comando.ExecuteNonQuery();
                }

                if (filas > 0)  //Verificar que insertó
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
        }//Registro SuperAdmin ==============================================================================================================================

        //Actualizacion SuperAdmin ==============================================================================================================================

        /// <summary>
        /// Metodo que actualiza un usuario en la BD
        /// </summary>
        /// <param name="p">Pagina actual</param>
        /// <param name="Usr">Indica el nuevo email usuario</param>
        /// <param name="Contra">Indica la nueva contraseña del usuario</param>
        /// <param name="Nombre">Indica el nuevo nombre del usuario</param>
        /// <param name="Apellidos">Indica los apellidos nuevos del usuario</param>
        /// <param name="rol">Indica el nuevo rol del usuario</param>
        public void Actualizacion(Page p, UsuarioRolClase seleccionado, string Usr, string Contra, string Nombre, string Apellidos, int rol)
        {
            int filas;
            try
            {

                using (var comando = new MySqlCommand("SELECT COUNT(*) FROM USUARIOS WHERE EMAIL = @usuario AND EMAIL != @usuarioAntiguo", conector))
                {

                    comando.Parameters.AddWithValue("@usuario", Usr);
                    comando.Parameters.AddWithValue("@usuarioAntiguo", seleccionado.email);

                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    if (count != 0)
                    {
                        p.DisplayAlert("Error", "Ese usuario ya existe", "OK");
                        return;
                    }

                }
                using (var comando = new MySqlCommand("UPDATE USUARIOS SET EMAIL = @usuario,NOMBRE = @nombre , APELLIDOS = @apellidos , PASSWORD = @pass , ID_ROL = @rol WHERE EMAIL = @usuarioAntiguo", conector))
                {

                    comando.Parameters.AddWithValue("@usuario", Usr);
                    comando.Parameters.AddWithValue("@pass", Contra);
                    comando.Parameters.AddWithValue("@apellidos", Apellidos);
                    comando.Parameters.AddWithValue("@nombre", Nombre);
                    comando.Parameters.AddWithValue("@rol", rol);
                    comando.Parameters.AddWithValue("@usuarioAntiguo", seleccionado.email);

                    filas = comando.ExecuteNonQuery();
                }

                if (filas > 0)  //Verificar que insertó
                {
                    p.DisplayAlert("Usuario Actualizado", "Usuario actualizado correctamente", "OK");
                    return;
                }
                else
                {
                    p.DisplayAlert("Error", "No se pudo actualizar el usuario", "OK");
                    return;
                }


            }
            catch (MySqlException e)
            {

                p.DisplayAlert("Error", "Error al Iniciar la sesion", "OK");
                return;
            }
        }


        //No cambiamos contraseña -------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Metodo que actualiza un usuario en la BD sin tocar la contraseña
        /// </summary>
        /// <param name="p">Pagina actual</param>
        /// <param name="Usr">Indica el nuevo email usuario</param>
        /// <param name="Nombre">Indica el nuevo nombre del usuario</param>
        /// <param name="Apellidos">Indica los apellidos nuevos del usuario</param>
        /// <param name="rol">Indica el nuevo rol del usuario</param>
        public void Actualizacion(Page p, UsuarioRolClase seleccionado, string Usr, string Nombre, string Apellidos, int rol)
        {
            int filas;
            try
            {

                using (var comando = new MySqlCommand("SELECT COUNT(*) FROM USUARIOS WHERE EMAIL = @usuario AND EMAIL != @usuarioAntiguo", conector))
                {

                    comando.Parameters.AddWithValue("@usuario", Usr);
                    comando.Parameters.AddWithValue("@usuarioAntiguo", seleccionado.email);

                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    if (count != 0)
                    {
                        p.DisplayAlert("Error", "Ese usuario ya existe", "OK");
                        return;
                    }

                }
                using (var comando = new MySqlCommand("UPDATE USUARIOS SET EMAIL = @usuario, NOMBRE = @nombre , APELLIDOS = @apellidos, ID_ROL = @rol WHERE EMAIL = @usuarioAntiguo", conector))
                {

                    comando.Parameters.AddWithValue("@usuario", Usr);
                    comando.Parameters.AddWithValue("@apellidos", Apellidos);
                    comando.Parameters.AddWithValue("@nombre", Nombre);
                    comando.Parameters.AddWithValue("@rol", rol);
                    comando.Parameters.AddWithValue("@usuarioAntiguo", seleccionado.email);


                    filas = comando.ExecuteNonQuery();
                }

                if (filas > 0)  //Verificar que insertó
                {
                    p.DisplayAlert("Usuario Actualizado", "Usuario actualizado correctamente", "OK");
                    return;
                }
                else
                {
                    p.DisplayAlert("Error", "No se pudo actualizar el usuario", "OK");
                    return;
                }


            }
            catch (MySqlException e)
            {

                p.DisplayAlert("Error", "Error al Iniciar la sesion", "OK");
                return;
            }
        }

        //Actualizacion SuperAdmin ==============================================================================================================================

        //Operaciones con el actual -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        //Obtener rol ==============================================================================================================================

        /// <summary>
        /// Metodo para obtener el rol del usuario actual
        /// </summary>
        /// <param name="p">Pagina actual</param>
        /// <returns>Devuelve un numero entero que indica el rol del usuario</returns>
        public int ObtenerRol(Page p)
        {
            try
            {
                int rol;
                using (var comando = new MySqlCommand("SELECT ID_ROL FROM USUARIOS WHERE EMAIL = @usuario", conector))
                {

                    //Parametros
                    comando.Parameters.AddWithValue("@usuario", actual);


                    rol = Convert.ToInt32(comando.ExecuteScalar());


                }
                return rol;
            }
            catch(MySqlException e)
            {
                p.DisplayAlert("Error", "Error eliminar su cuenta", "OK");
                return 3;
            }
        }

        //Obtener rol ==============================================================================================================================

        //Eliminar Cuenta ==============================================================================================================================

        /// <summary>
        /// Metodo para elimnar una cuenta propia de usuario
        /// </summary>
        /// <param name="p">Pagina acual</param>
        /// <returns>Devuelve true en caso de que el usuario se borre satisfactoriamente</returns>
        public bool EliminarActual(Page p)
        {
            try
            {
                int filas;
                using (var comando = new MySqlCommand("DELETE FROM USUARIOS WHERE EMAIL = @usuario", conector))
                {

                    //Parametros
                    comando.Parameters.AddWithValue("@usuario", actual);


                    filas = comando.ExecuteNonQuery();

                    if (filas == 1)
                    {
                        return true;
                    }
                }
                return false;
                
            }
            catch (MySqlException e)
            {
                p.DisplayAlert("Error", "Error al eliminar la cuenta", "OK");
                return false;
            }
        }

        //Eliminar Cuenta ==============================================================================================================================

        //Cambiar contraseña ==============================================================================================================================

        /// <summary>
        /// Metodo para que un usuario cambie su propia contrasea
        /// </summary>
        /// <param name="p">Pagina actual</param>
        /// <param name="contraseña">Nueva contraseña</param>
        /// <returns>Devuelve true en caso de que el cambio de contraseña haya ocurrido</returns>
        public bool ContraseñaActual(Page p, String contraseña)
        {
            try
            {
                int filas;
                using (var comando = new MySqlCommand("UPDATE USUARIOS SET PASSWORD = @pass WHERE EMAIL = @usuario", conector))
                {

                    //Parametros
                    comando.Parameters.AddWithValue("@usuario", actual);
                    comando.Parameters.AddWithValue("@pass", contraseña);


                    filas = comando.ExecuteNonQuery();

                    if (filas == 1)
                    {
                        return true;
                    }
                }
                p.DisplayAlert("Error", "No ha sido posible actualizar su contraseña", "OK");
                return false;

            }
            catch (MySqlException e)
            {
                p.DisplayAlert("Error", "Error al cambiar la contraseña", "OK");
                return false;
            }
        }

        //Cambiar contraseña ==============================================================================================================================
        //Operaciones con el actual -*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

        /// <summary>
        /// Metodo para eliminar un aula de la Base de datos
        /// </summary>
        /// <param name="aula">Aula que vamos a eliminar</param>
        internal bool EliminarAula(String aula)
        {
            try 
            {
                int filas;
                using (var comando = new MySqlCommand("DELETE FROM ESTANCIAS WHERE COD_EST = @aula", conector)) {
                    comando.Parameters.AddWithValue("@aula", aula);

                    filas = comando.ExecuteNonQuery();

                    if (filas == 1)
                    {
                        return true;
                    }
                }

                return false;
            } catch (Exception e) 
            {
                return false;
            }
        }

        /// <summary>
        /// Comprueba si el aula que estamos intentando insertar existe o no
        /// </summary>
        /// <param name="Cod_Est">Codigo de la estancia que vamos a añadir</param>
        /// <returns>Devuelve false en caso de que no exista y true si ya existe la estancia</returns>
        internal bool ExisteAula(String Cod_Est)
        {
            try
            {
                int count;
                using (var comando = new MySqlCommand("SELECT COUNT(*) FROM ESTANCIAS WHERE COD_EST = @estancia ", conector))
                {

                    comando.Parameters.AddWithValue("@estancia", Cod_Est);

                    count = Convert.ToInt32(comando.ExecuteScalar());
                }

                return count > 0;
            }
            catch (Exception e)
            {
                return true;
            }
        }

        /// <summary>
        /// Metodo para insertar una nueva aula en la BD
        /// </summary>
        /// <param name="Cod_Est">Codiogo de la estancia para la BD</param>
        /// <param name="Metros">Metros de la habitacion para la BD</param>
        /// <param name="N_Rad">Numero de Radiadores de la habitacion</param>
        /// <returns>Devuelve true en caso de que se añada a la BD y false en caso de que falle</returns>
        internal bool AgregarAula(String Cod_Est, String Metros, String N_Rad)
        {
            try
            {
                int filas;
                using (var comando = new MySqlCommand("INSERT INTO ESTANCIAS (COD_EST, METROS, N_RAD) VALUES (@Cod, @Metros, @Radiador);", conector))
                {

                    //Parametros
                    comando.Parameters.AddWithValue("@Cod", Cod_Est);
                    comando.Parameters.AddWithValue("@Metros", Metros);
                    comando.Parameters.AddWithValue("@Radiador", N_Rad);

                    filas = comando.ExecuteNonQuery();
                }

                if (filas > 0)  //Verificar que insertó
                {  
                    return true;
                }
                else
                {
                    return false;
                }

            }catch(Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Metodo para obtener la informacion de la temperatura de las aulas para Syncfusion
        /// </summary>
        /// <param name="aula">Aula sobre la que se buscan datos</param>
        /// <returns>Devuelve una lista con los ultimos 24 registros de temperatura de un aula</returns>
        public List<RegistroTemperatura> ObtenerHistorialPorAula(string aula)
        {
            var lista = new List<RegistroTemperatura>();
            try
            {
                string sql = "SELECT TEMP_ACT, FECHA, HORA, MINUT, COD_EST FROM LECTURAS WHERE COD_EST = @aula ORDER BY FECHA ASC, HORA ASC, MINUT ASC LIMIT 24";

                using (var comando = new MySqlCommand(sql, conector))
                {
                    comando.Parameters.AddWithValue("@aula", aula.Trim().ToUpper());

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new RegistroTemperatura
                            {
                                TEMP_ACT = Convert.ToDouble(reader["TEMP_ACT"]),
                                FECHA = Convert.ToDateTime(reader["FECHA"]),
                                HORA = Convert.ToInt32(reader["HORA"]),
                                MINUT = Convert.ToInt32(reader["MINUT"]),
                                COD_EST = reader["COD_EST"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return lista;
        }

        //=========================================================================== Syncfusion Tiempo caldera valvula =

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aula">Nombre del aula de la que vamos a sacar informacion</param>
        /// <returns>Devuelve una lista con los tiempos de funcionamiento de la caldera y la valvula</returns>
        public List<RegistroActividad> ObtenerTiemposActivos(string aula)
        {
            var lista = new List<RegistroActividad>();

            // 1. Obtener estados de la Válvula del aula
            var estadosVal = ObtenerEventos("ESTADOS_VAL", aula);
            lista.Add(new RegistroActividad
            {
                Tipo = "Válvula",
                MinutosActivo = CalcularDiferencia(estadosVal)
            });

            // 2. Obtener estados de la Caldera (General)
            var estadosCal = ObtenerEventos("ESTADOS_CAL", null);
            lista.Add(new RegistroActividad
            {
                Tipo = "Caldera",
                MinutosActivo = CalcularDiferencia(estadosCal)
            });

            return lista;
        }

        /// <summary>
        /// Devuelve los datos con los que vamos a llenar la lista de estados
        /// </summary>
        /// <param name="tabla">Tabla a la que accedemos puede ser ESTADOS_CAL o ESTADOS_VAL</param>
        /// <param name="aula">Aula de la que sacamos los datos</param>
        /// <returns></returns>
        private List<dynamic> ObtenerEventos(string tabla, string aula)
        {
            var eventos = new List<dynamic>();
            string sql = $"SELECT FECHA_INI, EST_VALVULA, HORA, MINUT FROM {tabla}";
            if (aula != null) sql += " WHERE COD_EST = @aula";
            sql += " ORDER BY FECHA_INI, HORA, MINUT";

            using (var cmd = new MySqlCommand(sql, conector))
            {
                if (aula != null) cmd.Parameters.AddWithValue("@aula", aula);
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        DateTime fecha = rd.GetDateTime(0);
                        TimeSpan hora = new TimeSpan(rd.GetInt32(2), rd.GetInt32(3), 0);
                        eventos.Add(new
                        {
                            Momento = fecha.Add(hora),
                            Estado = rd.GetString(1)
                        });
                    }
                }
            }
            return eventos;
        }

        /// <summary>
        /// Calculo del tiempo que esta activo 
        /// </summary>
        /// <param name="eventos">Lista con la apertura y los cierres de la valvula</param>
        /// <returns>Devuelve el tiempo de funcionamiento de la valvula o la caldera</returns>
        private double CalcularDiferencia(List<dynamic> eventos)
        {
            double totalMinutos = 0;
            DateTime? inicio = null;

            foreach (var e in eventos)
            {
                if (e.Estado == "O") 
                    inicio = e.Momento;
                else if (e.Estado == "C" && inicio != null) 
                {
                    totalMinutos += (e.Momento - inicio.Value).TotalMinutes;
                    inicio = null;
                }
            }
            return Math.Round(totalMinutos, 2);
        }

        //Semanal
        /*private List<dynamic> ObtenerEventos(string tabla, string aula)
        {
            var eventos = new List<dynamic>();

            string sql = $@"SELECT FECHA_INI, EST_VALVULA, HORA, MINUT 
                    FROM {tabla} 
                    WHERE FECHA_INI >= DATE_SUB(CURDATE(), INTERVAL 7 DAY)";

            if (aula != null) { sql += " AND COD_EST = @aula"; }
            sql += " ORDER BY FECHA_INI ASC, HORA ASC, MINUT ASC";

            using (var cmd = new MySqlCommand(sql, conector))
            {
                if (aula != null) cmd.Parameters.AddWithValue("@aula", aula);
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        DateTime fecha = rd.GetDateTime(0);
                        TimeSpan hora = new TimeSpan(rd.GetInt32(2), rd.GetInt32(3), 0);
                        eventos.Add(new
                        {
                            Momento = fecha.Add(hora),
                            Estado = rd.GetString(1)
                        });
                    }
                }
            }
            return eventos;
        }*/

    }
}