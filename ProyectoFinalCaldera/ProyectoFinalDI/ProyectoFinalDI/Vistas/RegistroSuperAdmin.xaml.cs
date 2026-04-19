using ProyectoFinalDI.Servicios;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace ProyectoFinalDI.Vistas;

public partial class RegistroSuperAdmin : ContentPage
{
    UsuarioRolClase seleccionado;
    private ListaUsr actualizar;
    private int rol = 3;
    private int opc = 0;

    public RegistroSuperAdmin(int opc, ListaUsr p) // Agregar 
    {
        InitializeComponent();
        this.opc = opc; // Opc = 1
        actualizar = p; // Para actualizar la lista

        // Actualizamos el título de la barra superior (TitleView) y el del cuerpo
        LabelTituloBarra.SetDynamicResource(Label.TextProperty, "TituloReg");
        TextoRegEdtUsr.SetDynamicResource(Label.TextProperty, "TextoRegUsr");
    }

    public RegistroSuperAdmin(int opc, UsuarioRolClase usuarioSeleccionado, ListaUsr p) // Editar
    {
        InitializeComponent();
        this.opc = opc; // Opc = 2 
        actualizar = p; // Para actualizar la lista
        seleccionado = usuarioSeleccionado;

        // Actualizamos el título de la barra superior (TitleView) y el del cuerpo
        LabelTituloBarra.SetDynamicResource(Label.TextProperty, "TituloEdit");
        TextoRegEdtUsr.SetDynamicResource(Label.TextProperty, "TextoEdtUsr");

        RellenarCampos(seleccionado);
    }

    public void BtnContinuar(object sender, EventArgs e)
    {
        if (opc == 2)
        {
            Actualizacion(sender, e);
        }
        else if (opc == 1)
        {
            Registo(sender, e);
        }

        actualizar.CargarUsuarios();
        Navigation.PopAsync();
    }

    private void Registo(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(Usr.Text) && !string.IsNullOrWhiteSpace(Contra.Text) &&
            !string.IsNullOrWhiteSpace(Nom.Text) && !string.IsNullOrWhiteSpace(Ape.Text))
        {

            if (Contra.Text.Length < 8)
            {
                DisplayAlert("Contraseña no valida", "La contraseña tiene que tener minimo 8 caracteres", "OK");
                BD.Instance.CerrarConexion(this);
                return;
            }

            if (!Regex.IsMatch(Usr.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                DisplayAlert("Error", "Debes usar un correo electronico valido", "OK");
            }
            else
            {
                BD.Instance.AbrirConexion(this);
                BD.Instance.Registro(this, Usr.Text, Contra.Text, Nom.Text, Ape.Text, rol);
                BD.Instance.CerrarConexion(this);
            }
        }
        else
        {
            DisplayAlert("Error", "Debe llenar todos los campos", "OK");
        }
    }

    private void Actualizacion(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(Usr.Text) && !string.IsNullOrWhiteSpace(Nom.Text) && !string.IsNullOrWhiteSpace(Ape.Text))
        {
            if (!Regex.IsMatch(Usr.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                DisplayAlert("Error", "Debes usar un correo electronico valido", "OK");
                return;
            }

            BD.Instance.AbrirConexion(this);
            if (string.IsNullOrWhiteSpace(Contra.Text))
            {
                BD.Instance.Actualizacion(this, seleccionado, Usr.Text, Nom.Text, Ape.Text, rol);
            }
            else
            {
                BD.Instance.Actualizacion(this, seleccionado, Usr.Text, Contra.Text, Nom.Text, Ape.Text, rol);
            }
            BD.Instance.CerrarConexion(this);
        }
        else
        {
            DisplayAlert("Error", "Debe llenar todos los campos", "OK");
        }
    }

    private void RBRol(object sender, EventArgs e)
    {
        if (RBRegistrado.IsChecked) rol = 3;
        else if (RBSuper.IsChecked) rol = 1;
        else if (RBAdmin.IsChecked) rol = 2;
    }

    private void RellenarCampos(UsuarioRolClase usuarioSeleccionado)
    {
        Usr.Text = usuarioSeleccionado.email;
        Nom.Text = usuarioSeleccionado.nombre;
        Ape.Text = usuarioSeleccionado.apellido;

        if (usuarioSeleccionado.rol.Equals("SuperAdmin") || usuarioSeleccionado.rol.Equals("1"))
        {
            RBSuper.IsChecked = true;
        }
        else if (usuarioSeleccionado.rol.Equals("Admin") || usuarioSeleccionado.rol.Equals("2"))
        {
            RBAdmin.IsChecked = true;
        }
        else
        {
            RBRegistrado.IsChecked = true;
        }
    }
}