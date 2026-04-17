using ProyectoFinalDI.Servicios;
using System.Collections.ObjectModel;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace ProyectoFinalDI.Vistas;

public partial class RegistroSuperAdmin : ContentPage
{
    UsuarioRolClase seleccionado;
    ListaUsr actualizar;
	private int rol = 3;
    private int opc = 0;

    public RegistroSuperAdmin(int opc, ListaUsr p)//Agregar 
	{
		InitializeComponent();
        this.opc = opc;//Opc = 1
        actualizar = p;//Para actualizar la lista
        
        TituloRegistroEdicion.SetDynamicResource(Label.TextProperty, "TituloReg");
        TextoRegEdtUsr.SetDynamicResource(Label.TextProperty, "TextoRegUsr");

    }

    public RegistroSuperAdmin(int opc, UsuarioRolClase usuarioSeleccionado, ListaUsr p)//Editar
    {
        InitializeComponent();
        this.opc = opc;//Opc = 2 
        actualizar = p;//Para actualizar la lista
        seleccionado = usuarioSeleccionado;

        TituloRegistroEdicion.SetDynamicResource(Label.TextProperty, "TituloEdit");
        TextoRegEdtUsr.SetDynamicResource(Label.TextProperty, "TextoEdtUsr");

        RellenarCampos(seleccionado);

    }


    

    public async void BtnContinuar(object sender, EventArgs e)
    {

        if (seleccionado != null)
        {
            Actualizacion(sender, e);
        }
        else if (seleccionado == null)
        {
            Registo(sender, e);       
        }
        
    }


    private async void Registo(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(Usr.Text) && !string.IsNullOrWhiteSpace(Contra.Text) && !string.IsNullOrWhiteSpace(Nom.Text) && !string.IsNullOrWhiteSpace(Ape.Text)) {

            if (!Regex.IsMatch(Usr.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                DisplayAlert("Error", "Debes usar un correo electronico valido", "OK");
                
            } 
            else
            {
                BD.Instance.AbrirConexion(this);

                BD.Instance.Registro(this, Usr.Text, Contra.Text, Nom.Text, Ape.Text, rol);

                BD.Instance.CerrarConexion(this);
                actualizar.CargarUsuarios();
            }
            await Navigation.PopAsync();
        } else
        {
            DisplayAlert("Error", "Debe llenar todos los campos", "OK");
        }
    }

    private async void Actualizacion(object sender, EventArgs e)
    {  
        if (!string.IsNullOrWhiteSpace(Usr.Text) && !string.IsNullOrWhiteSpace(Contra.Text) && !string.IsNullOrWhiteSpace(Nom.Text) && !string.IsNullOrWhiteSpace(Ape.Text))
        {
            // Validar email siempre, independientemente de si hay contraseña o no
            if (!Regex.IsMatch(Usr.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                DisplayAlert("Error", "Debes usar un correo electronico valido", "OK");
                return;
            }

            BD.Instance.AbrirConexion(this);
      
            BD.Instance.Actualizacion(this, seleccionado, Usr.Text.Trim(), Contra.Text, Nom.Text, Ape.Text, rol, lista);
            
            BD.Instance.CerrarConexion(this);
            actualizar.CargarUsuarios();
            await Navigation.PopAsync();
        }
        else
        {
            DisplayAlert("Error", "Debe llenar todos los campos", "OK");
        }
    }

    private void RBRol(object sender, EventArgs e) {

        if (RBRegistrado.IsChecked)
        {
            rol = 3;
        }

        if (RBSuper.IsChecked)
        {
            rol = 1;
        }

        if (RBAdmin.IsChecked)
        {
            rol = 2;
        }

        
    }

    private void RellenarCampos(UsuarioRolClase usuarioSeleccionado){

        Usr.Text = usuarioSeleccionado.email.Trim();
        Contra.Text = usuarioSeleccionado.contraseña;
        Nom.Text = usuarioSeleccionado.nombre;
        Ape.Text = usuarioSeleccionado.apellido;

        if (usuarioSeleccionado.rol.Equals("SuperAdmin"))
        {
            RBSuper.IsChecked = true;
        }
        else if (usuarioSeleccionado.rol.Equals("Admin"))
        {
            RBAdmin.IsChecked = true;
        }
    }
}