using System.Collections.ObjectModel;
using ProyectoFinalDI.Servicios;

namespace ProyectoFinalDI.Vistas;

/// <summary>
/// Representa la pagina de la lista de usuarios, sirve para que el super admin gestione a los usuarios
/// </summary>
public partial class ListaUsr : ContentPage
{
    /// <summary>
    /// Lista con los usuarios de la aplicacion 
    /// </summary>
    public ObservableCollection<UsuarioRolClase> ListaUsuarios { get; set; }

    /// <summary>
    /// Almacena el usuario seleccionado para pasarselo a la siguiente pagina
    /// </summary>
    UsuarioRolClase usuarioSeleccionado;

    /// <summary>
    /// Inizializa los componentes, carga en la lista los usuarios de la BD y los muestra 
    /// </summary>
    public ListaUsr()
    {
        InitializeComponent();

        ListaUsuarios = new ObservableCollection<UsuarioRolClase>();

        CargarUsuarios();

        BindingContext = this;
    }

    /// <summary>
    /// Carga los usuarios de la BD en la lista para mostrarlos
    /// </summary>
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

    /// <summary>
    /// Metodo que almacena el usuario seleccionado en el Atributo usuarioSeleccionado
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
    private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)//Seleccion de usuario
    {
        usuarioSeleccionado = e.CurrentSelection.FirstOrDefault() as UsuarioRolClase;
    }

    /// <summary>
    /// Metodo para abrir la pagina de agregar usuario
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
    private async void BtnAgregarUsrListUsr_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegistroSuperAdmin(1, this));
    }

    /// <summary>
    /// Metodo que elimina un usuario de la BD
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
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

    /// <summary>
    /// Metodo que abre la pagina de Edicion de usuario
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
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