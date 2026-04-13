using ProyectoFinalDI.Servicios;
using System.Text.RegularExpressions;

namespace ProyectoFinalDI.Vistas;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private async void Registro_Clicked(object sender, EventArgs e)
    {
        bool prueba = BD.Instance.AbrirConexion(this);

        if (prueba == true)
        {
            String usuario = Usr.Text;
            String contraseña = Contra.Text;
            String nombre = Nom.Text;
            String apellidos = Ape.Text;
            if (usuario == null || contraseña == null || nombre == null || apellidos == null)
            {
                await DisplayAlert("Error", "No puedes dejar campos vacios", "OK");
                return;
            }

            if (!Regex.IsMatch(usuario, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") )
            {
                await DisplayAlert("Error", "Debes usar un correo electronico valido", "OK");
                return;
            }

            bool registroS = BD.Instance.Registro(this, usuario, contraseña, nombre, apellidos);

            if (registroS == true)
            {
                await Navigation.PushAsync(new Aulas());
            }
            BD.Instance.CerrarConexion(this);
        }
    }
}