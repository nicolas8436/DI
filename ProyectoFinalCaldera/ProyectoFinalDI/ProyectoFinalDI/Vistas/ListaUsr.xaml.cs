using System.Collections.ObjectModel;
using ProyectoFinalDI.Servicios;

namespace ProyectoFinalDI.Vistas;

public partial class ListaUsr : ContentPage
{
    public ObservableCollection<UsuarioRolClase> ListaUsuarios { get; set; }
    UsuarioRolClase usuarioSeleccionado;

    public ListaUsr()
    {
        InitializeComponent();

        ListaUsuarios = new ObservableCollection<UsuarioRolClase>();

        CargarUsuarios();

        BindingContext = this;
    }

    public void CargarUsuarios()//Cargar la lista con usuarios/roles
    {
        if (BD.Instance.AbrirConexion(this))
        {
            var usuarios = BD.Instance.ObtenerUsuarios(this);

            ListaUsuarios.Clear();

            foreach (var u in usuarios)
                ListaUsuarios.Add(u);

            BD.Instance.CerrarConexion(this);
        }
    }

    private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)//Seleccion de usuario
    {
        usuarioSeleccionado = e.CurrentSelection.FirstOrDefault() as UsuarioRolClase;
    }

    private async void BtnAgregarUsrListUsr_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegistroSuperAdmin(1, this));
    }

    private async void BtnEliminarUsrListUsr_Clicked(object sender, EventArgs e)
    {
        if (usuarioSeleccionado == null)
        {
            DisplayAlert("Error", "Selecciona un usuario", "OK");
            return;
        }

        bool respuesta = await DisplayAlert(
        "Confirmar",
        $"¿Eliminar a {usuarioSeleccionado.nombre}?",
        "Sí",
        "Cancelar"
    );

        if (!respuesta) { 
            return;}
        
        await DisplayAlert("Eliminado", "Usuario eliminado", "OK");

        BD.Instance.AbrirConexion(this);
        BD.Instance.BorrarUsr(this, usuarioSeleccionado);
        ListaUsuarios.Remove(usuarioSeleccionado);
        BD.Instance.CerrarConexion(this);
    }

    private async void BtnEditarUsrListUsr_Clicked(object sender, EventArgs e)
    {
        if (usuarioSeleccionado == null)
        {
            DisplayAlert("Error", "Selecciona un usuario", "OK");
            return;
        }

        DisplayAlert("Editar", $"Editar {usuarioSeleccionado.nombre}", "OK");

        await Navigation.PushAsync(new RegistroSuperAdmin(2, usuarioSeleccionado, this));
    }
}