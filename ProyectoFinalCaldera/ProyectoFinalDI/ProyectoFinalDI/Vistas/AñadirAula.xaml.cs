using ProyectoFinalDI.Servicios;
using System.Text.RegularExpressions;

namespace ProyectoFinalDI.Vistas;

public partial class AñadirAula : ContentPage
{
    private Aulas aulas;
    public AñadirAula(Aulas a)
    {
        this.aulas = a;
        InitializeComponent();
    }

    private async void Cancelar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Confirmar_Clicked(object sender, EventArgs e)
    {

        String Cod_Est = null;

        if (EntryNombre.Text != null) {Cod_Est = EntryNombre.Text.ToUpper();}
        String Metros = EntryMetros.Text;
        String N_Rad = EntryRadiadores.Text;

        if (!string.IsNullOrWhiteSpace(Cod_Est) && !string.IsNullOrWhiteSpace(Metros) && !string.IsNullOrWhiteSpace(N_Rad))
        {
            BD.Instance.AbrirConexion(this);
            if (!Existe(Cod_Est) && ValidarAula(Cod_Est) && ValidarMetros(Metros) && ValidarRadiadores(N_Rad))
            {
                

                if(BD.Instance.AgregarAula(Cod_Est, Metros, N_Rad))
                {
                    await DisplayAlert("Exito", "Aula añadida correctamente", "Ok");
                    aulas.CargarAulas();
                    await Navigation.PopAsync();
                } 
                else
                {
                    await DisplayAlert("Error","Error al añadir el aula","Ok");
                }
                BD.Instance.CerrarConexion(this);
                
            }
        } 
        else
        {
            await DisplayAlert("Error","No puedes dejar campos vacios","Ok");
        } 
    }

    private bool Existe(String Cod_est) {

        if (BD.Instance.ExisteAula(Cod_est))
        {
            DisplayAlert("Error", "El aula ya existe", "Ok");
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool ValidarAula(String Cod_est) 
    { 
        if (Regex.IsMatch(Cod_est, "^[A-Z][0-9]{2}$"))
        {
            return true;
        }
        else
        {
            DisplayAlert("Error","Codigo de aula no valido (A00)","Ok");
            return false;
        }
    }

    private bool ValidarMetros(String Metros) 
    {
        int metrosInt; 
        if(!int.TryParse(Metros, out metrosInt))
        {
            DisplayAlert("Error", "No puedes meter letras aqui", "OK");
            return false;
        }

        if (metrosInt >= 1 && metrosInt <= 50)
        {
            return true;
        }
        else
        {
            DisplayAlert("Error", "Tamaño del aula no valido debe ser entre 1 y 50", "Ok");
            return false;
        }
    }

    private bool ValidarRadiadores(String N_Rad) 
    {
        int radInt; 
        if (!int.TryParse(N_Rad, out radInt))
        {
            DisplayAlert("Error", "No puedes meter letras aqui", "OK");
            return false;
        }

        if (radInt >= 1 && radInt <= 10)
        {
            return true;
        }
        else
        {
            DisplayAlert("Error", "Numero de radiadores no valido debe ser entre 1 y 10", "Ok");
            return false;
        }
    }
}