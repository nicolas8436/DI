using ProyectoFinalDI.Servicios;
using System.Text.RegularExpressions;

namespace ProyectoFinalDI.Vistas;

/// <summary>
/// Pagina de registro de usuario 
/// </summary>
public partial class Registro : ContentPage
{

    /// <summary>
    /// Constructor de la pagina de registro, inizializa los componentes
    /// </summary>
    public Registro()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Comprueba que los campos esten rellenados de manera valida y añade al nuevo usuario
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
    private async void Registro_Clicked(object sender, EventArgs e)
    {
        bool prueba = BD.Instance.AbrirConexion(this);

        if (prueba == true)
        {
            string usuario = Usr.Text;
            string contraseña = Contra.Text;
            string nombre = Nom.Text;
            string apellidos = Ape.Text;

            
            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contraseña) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellidos))
            {
                await DisplayAlert("Error", "No puedes dejar campos vacíos", "OK");
                BD.Instance.CerrarConexion(this); 
                return;
            }

            if (contraseña.Length < 8)
            {
                await DisplayAlert("Contraseña no valida", "La contraseña tiene que tener minimo 8 caracteres", "OK");
                BD.Instance.CerrarConexion(this);
                return;
            }



                if (!Regex.IsMatch(usuario, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                await DisplayAlert("Error", "Debes usar un correo electrónico válido", "OK");
                BD.Instance.CerrarConexion(this); 
                return;
            }

            bool registroS = BD.Instance.Registro(this, usuario, contraseña, nombre, apellidos);

            

            if (registroS)
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

            BD.Instance.CerrarConexion(this);
        
        

        }
    }
}