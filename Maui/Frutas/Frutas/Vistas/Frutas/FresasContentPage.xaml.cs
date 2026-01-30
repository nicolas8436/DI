using Frutas.Resources.Styles;
using Microsoft.Maui.Controls;

namespace Frutas.Vistas.Frutas;

public partial class FresasContentPage : ContentPage
{
    ResourceDictionary miRecursoDiccionario;
	public FresasContentPage()
	{
		InitializeComponent();
        miRecursoDiccionario = new ResourceDictionary();
	}

    private void BoxView_Focused(object sender, FocusEventArgs e)
    {
        Resources["Cuerpo"] = Resources["CuerpoFocussed"];
        Resources["Titulo"] = Resources["TituloFocussed"];
    }

    private void BoxView_Unfocused(object sender, FocusEventArgs e)
    {
        Resources["Cuerpo"] = Resources["CuerpoFocussed"];
        Resources["Titulo"] = Resources["TituloFocussed"];
    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        ICollection<ResourceDictionary> miListaDiccionarios = Application.Current.Resources.MergedDictionaries;
        Double tamanioLabel = (Double)App.Current.Resources["TamanioTextoLabel"];
        Double tamanioTitulo = (Double)App.Current.Resources["TamanioTituloLabel"];

        if (miListaDiccionarios != null)
        {
            miListaDiccionarios.Clear();
            
        }

        miListaDiccionarios.Add(new Resources.Styles.TamanioFuentes());
        App.Current.Resources["TamanioTextoLabel"] = tamanioLabel;
        App.Current.Resources["TamanioTituloLabel"] = tamanioTitulo;

        if (interruptor.IsToggled){
            miListaDiccionarios.Add(new Resources.Idiomas.Ingles());

        } else {
            miListaDiccionarios.Add(new Resources.Idiomas.Espaniol());
        }
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        ICollection<ResourceDictionary> miListaDiccionarios = Application.Current.Resources.MergedDictionaries;
        Double tamanioLabel = (Double)App.Current.Resources["TamanioTextoLabel"];
        Double tamanioTitulo = (Double)App.Current.Resources["TamanioTituloLabel"];

        if (miListaDiccionarios != null)
        {
            miListaDiccionarios.Clear();

        }

        miListaDiccionarios.Add(new Resources.Styles.TamanioFuentes());
        App.Current.Resources["TamanioTextoLabel"] = tamanioLabel;
        App.Current.Resources["TamanioTituloLabel"] = tamanioTitulo;

        if (rTPrincipal.IsChecked)
        {
            miListaDiccionarios.Add(new Resources.Styles.TemaPrincipal());
        }

        if (rTOscuro.IsChecked)
        {
            miListaDiccionarios.Add(new Resources.Styles.TemaOscuro());
        }

        if (rTClaro.IsChecked)
        {
            miListaDiccionarios.Add(new Resources.Styles.TemaClaro());
        }

    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        //Cambiamos el texto por el original por el tamaño q aumenta
        Slider miSlider = (Slider)sender;

        App.Current.Resources["TamanioTextoLabel"] = (Double)App.Current.Resources["TamanioTextoLabelOriginal"] * miSlider.Value;
        App.Current.Resources["TamanioTituloLabel"] = (Double)App.Current.Resources["TamanioTituloLabelOriginal"] * miSlider.Value;

    }
}