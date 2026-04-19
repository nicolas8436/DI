namespace ProyectoFinalDI.Vistas;

using ProyectoFinalDI.Servicios;

public partial class InicioSesion : ContentPage
{
	public InicioSesion()
	{
		InitializeComponent();
	}

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

            // 2. Verificar credenciales
            bool loginExitoso = BD.Instance.InicioS(this, usuario, contraseña);

            if (loginExitoso)
            {
                // 3. Obtener el rol y guardarlo en el Singleton global de Persona
                int rolObtenido = BD.Instance.ObtenerRol(this, usuario);
                Persona.Instance.SetRol(rolObtenido);

                // 4. REINICIAR LA APP CON EL NUEVO SHELL
                // Esto destruye el estado anterior y ejecuta el OnAppearing del Shell
                Application.Current.MainPage = new AppShell();

                // 5. NAVEGACIÓN INMEDIATA
                // Saltamos directamente a la página de Aulas (dentro de las pestañas)
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