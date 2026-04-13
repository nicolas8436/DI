using System.Security.Principal;

namespace ProyectoFinalDI.Vistas;

public partial class Configuracion : ContentPage
{
	public Configuracion()
	{
		InitializeComponent();
	}

    private void Idioma_Toggled(object sender, ToggledEventArgs e)
    {

    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        ICollection<ResourceDictionary> miListaDiccionarios = Application.Current.Resources.MergedDictionaries;

        Double tamanioTextoLabelOriginal = 14;
        Double tamanioTituloLabelOriginal = 18;

        Double tamanioLabel = tamanioTextoLabelOriginal;
        Double tamanioTitulo = tamanioTituloLabelOriginal;

        if (miListaDiccionarios != null)
        {
            miListaDiccionarios.Clear();

        }

        miListaDiccionarios.Add(new Resources.Styles.TemaPrincipal());
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

    private void Tamaño_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Double tamanioTextoLabelOriginal = 14;
        Double tamanioTituloLabelOriginal = 18;

        Slider miSlider = (Slider)sender;

        App.Current.Resources["TamanioTextoLabel"] = tamanioTextoLabelOriginal * miSlider.Value;
        App.Current.Resources["TamanioTituloLabel"] = tamanioTextoLabelOriginal * miSlider.Value;
    }
}