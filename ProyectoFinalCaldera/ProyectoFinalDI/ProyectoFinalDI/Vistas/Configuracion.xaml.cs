using ProyectoFinalDI.Resources.Idiomas;
using ProyectoFinalDI.Resources.Styles;
using ProyectoFinalDI.Servicios;
using System.Diagnostics.Contracts;
using System.Security.Principal;

namespace ProyectoFinalDI.Vistas;

/// <summary>
/// Clase de la pagina de configuracion de la aplicacion
/// </summary>
public partial class Configuracion : ContentPage
{

    /// <summary>
    /// Inizializa los componentes de la pagina
    /// </summary>
    public Configuracion()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Metodo que modifica los estilos de la aplicacion
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        ICollection<ResourceDictionary> miListaDiccionarios = Application.Current.Resources.MergedDictionaries;
        Double tamanioLabel = (Double)App.Current.Resources["TamanioTextoLabel"];
        Double tamanioTitulo = (Double)App.Current.Resources["TamanioTituloLabel"];

        var temaPrevio = miListaDiccionarios.FirstOrDefault(d =>
        d is TemaPrincipal || d is TemaOscuro || d is TemaClaro);

        if (temaPrevio != null)
        {
            miListaDiccionarios.Remove(temaPrevio);
        }

        miListaDiccionarios.Add(new Resources.Styles.TamFuentes());
        App.Current.Resources["TamanioTextoLabel"] = tamanioLabel;
        App.Current.Resources["TamanioTituloLabel"] = tamanioTitulo;

        if (RBprincipal.IsChecked)
        {
            miListaDiccionarios.Add(new Resources.Styles.TemaPrincipal());
        }

        if (RBoscuro.IsChecked)
        {
            miListaDiccionarios.Add(new Resources.Styles.TemaOscuro());
        }

        if (RBclaro.IsChecked)
        {
            miListaDiccionarios.Add(new Resources.Styles.TemaClaro());
        }
    }


    /// <summary>
    /// Cambia el tamaño del texto a traves del slider y de cuanto lo movemos
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
    private void Tamaño_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Double tamanioTextoLabelOriginal = 16;
        Double tamanioTituloLabelOriginal = 20;
        Double tamanioTituloGLabelOriginal = 28;

        Slider miSlider = (Slider)sender;

        App.Current.Resources["TamanioTextoLabel"] = tamanioTextoLabelOriginal * miSlider.Value;
        App.Current.Resources["TamanioTituloLabel"] = tamanioTituloLabelOriginal * miSlider.Value;
        App.Current.Resources["TamanioTituloGLabel"] = tamanioTituloGLabelOriginal * miSlider.Value;
    }

    /// <summary>
    /// Cambio de idioma con el toggle entre esapañol e ingles
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
    private void Idioma_Toggled(object sender, ToggledEventArgs e)
    {
        var diccionarios = Application.Current.Resources.MergedDictionaries;

        var idiomaActual = diccionarios.FirstOrDefault(d =>
            d is Espaniol || d is Ingles);

        if (idiomaActual != null)
            diccionarios.Remove(idiomaActual);

        if (interruptor.IsToggled)
            diccionarios.Add(new Ingles());
        else
            diccionarios.Add(new Espaniol());
    }

    /// <summary>
    /// Confirma el cambio de contraseña, siempre que cumpla ciertos requisitos
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
    private async void Confirmar_Clicked(object sender, EventArgs e)
    {
        String contra = EntryContra.Text;

        if (contra != "" && contra != null && contra.Length >= 8)
        {
            BD.Instance.AbrirConexion(this);
            bool cambio = BD.Instance.ContraseñaActual(this, contra);
            
            if (cambio)
            {
                await DisplayAlert("Contraseña actualizada", "Tu contraseña ha sido actualizada correctamente.", "OK");

                BD.Instance.CerrarConexion(this);
            }
            else
            {
                await DisplayAlert("Error", "No se a podido actualizar la contraseña en este momento.", "OK");
                BD.Instance.CerrarConexion(this);
            }
        
        } else
        {
            await DisplayAlert("Contraseña no valida", "La contraseña debe tener mas de 8 caracteres", "OK");
        }
    }

    /// <summary>
    /// Elimina la cuenta del usuario actual y le saca a la pantalla de inicio
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
    private async void Eliminar_Clicked(object sender, EventArgs e)
    {
        BD.Instance.AbrirConexion(this);
        bool borrado = BD.Instance.EliminarActual(this);

        if (borrado)
        {

            Persona.Instance.SetRol(0);
            BD.Instance.setActual(null);

            await DisplayAlert("Cuenta eliminada", "Tu cuenta ha sido borrada correctamente.", "OK");
            BD.Instance.CerrarConexion(this);

            Application.Current.MainPage = new AppShell();
            await Shell.Current.GoToAsync("//PantallaInicio");
        }
        else
        {
            await DisplayAlert("Error", "No se pudo eliminar la cuenta en este momento.", "OK");
            BD.Instance.CerrarConexion(this);
        }
    }
}