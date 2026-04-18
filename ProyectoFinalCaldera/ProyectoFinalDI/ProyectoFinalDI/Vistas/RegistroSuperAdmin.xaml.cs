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
        if (Usr.Text != null && Contra.Text != null && Nom.Text != null && Ape.Text != null) {

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
            
        } else
        {
            DisplayAlert("Error", "Debe llenar todos los campos", "OK");
        }
    }

    private void Actualizacion(object sender, EventArgs e)
    {
        if (Usr.Text != null  && Nom.Text != null && Ape.Text != null)
        {   
            
            if (!Regex.IsMatch(Usr.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                DisplayAlert("Error", "Debes usar un correo electronico valido", "OK");
            }

            BD.Instance.AbrirConexion(this);
            if (Contra.Text == null) { 
            {
                BD.Instance.Actualizacion(this, seleccionado, Usr.Text, Nom.Text, Ape.Text, rol);
            }
            }
            else
            {
                BD.Instance.Actualizacion(this, seleccionado ,Usr.Text, Contra.Text, Nom.Text, Ape.Text, rol);
            }
            BD.Instance.CerrarConexion(this);
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

        Usr.Text = usuarioSeleccionado.email;
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