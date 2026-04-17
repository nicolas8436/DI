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
		bool prueba = BD.Instance.AbrirConexion(this);

		
		if (prueba == true)
		{
			String usuario = Usr.Text;
			String contraseña = Contra.Text;
			if (usuario == null || contraseña == null)
			{
                await DisplayAlert("Error", "No puedes dejar campos vacios", "OK");
				return;
			}
			bool inicioS = BD.Instance.InicioS(this, usuario, contraseña);

			if (inicioS == true) {
				Persona.Instance.SetRol(BD.Instance.ObtenerRol(this, usuario));
                await Navigation.PushAsync(new Aulas());
            }
			else 
			{
                await DisplayAlert("Error", "El usuario o la contraseña son incorrectos", "OK");
			}
			BD.Instance.CerrarConexion(this);
        }

		
    }
}