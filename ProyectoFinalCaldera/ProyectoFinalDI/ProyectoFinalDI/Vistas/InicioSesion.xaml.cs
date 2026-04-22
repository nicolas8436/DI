namespace ProyectoFinalDI.Vistas;

using ProyectoFinalDI.Servicios;

/// <summary>
/// Clase de la pagina de inicio de sesion
/// </summary>
public partial class InicioSesion : ContentPage
{
    /// <summary>
    /// Constructor de inicio de sesion, inizializa los constructores
    /// </summary>
	public InicioSesion()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Metodo que comprueba e inicia sesion con el usuario y contraseña indicado
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
    private async void InicioS_Clicked(object sender, EventArgs e)
    {
        // 1. Abrir conexión con tu Singleton de BD
        bool conexionAbierta = BD.Instance.AbrirConexion(this);

        if (conexionAbierta)
        {
            string usuario = Usr.Text;
            string contraseña = Contra.Text;

            // Validación básica de nulos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                await DisplayAlert("Error", "Por favor, rellena todos los campos", "OK");
                return;
            }

            bool loginExitoso = BD.Instance.InicioS(this, usuario, contraseña);

            if (loginExitoso)
            {
                int rolObtenido = BD.Instance.ObtenerRol(this, usuario);
                Persona.Instance.SetRol(rolObtenido);

                Application.Current.MainPage = new AppShell();

                await Shell.Current.GoToAsync("//AulasPage");

                BD.Instance.CerrarConexion(this);
            }
            else
            {
                await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
                BD.Instance.CerrarConexion(this);
            }
        }
    }
}