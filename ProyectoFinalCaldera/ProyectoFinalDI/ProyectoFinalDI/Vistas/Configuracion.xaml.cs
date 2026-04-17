using System.Security.Principal;
using ProyectoFinalDI.Resources.Styles;
using ProyectoFinalDI.Resources.Idiomas;

namespace ProyectoFinalDI.Vistas;

public partial class Configuracion : ContentPage
{
    public Configuracion()
    {
        InitializeComponent();
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        ICollection<ResourceDictionary> miListaDiccionarios = Application.Current.Resources.MergedDictionaries;

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
}