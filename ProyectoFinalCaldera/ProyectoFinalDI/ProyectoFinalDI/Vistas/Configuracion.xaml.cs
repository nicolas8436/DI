using ProyectoFinalDI.Resources.Idiomas;
using ProyectoFinalDI.Resources.Styles;
using System.Security.Principal;

namespace ProyectoFinalDI.Vistas;

public partial class Configuracion : ContentPage
{
    public Configuracion()
    {
        InitializeComponent();
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            var radioButton = sender as RadioButton;
            if (radioButton == null) return;

            var mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries == null) return;

            // 1. Buscamos si ya existe un tema cargado para eliminarlo
            // Comprobamos por el espacio de nombres de tus archivos de estilos
            var temaExistente = mergedDictionaries.FirstOrDefault(d =>
                d is ProyectoFinalDI.Resources.Styles.TemaClaro ||
                d is ProyectoFinalDI.Resources.Styles.TemaOscuro ||
                d is ProyectoFinalDI.Resources.Styles.TemaPrincipal);

            if (temaExistente != null)
            {
                mergedDictionaries.Remove(temaExistente);
            }

            // 2. Añadimos el nuevo tema según la selección
            if (radioButton == RBprincipal)
            {
                mergedDictionaries.Add(new ProyectoFinalDI.Resources.Styles.TemaPrincipal());
            }
            else if (radioButton == RBoscuro)
            {
                mergedDictionaries.Add(new ProyectoFinalDI.Resources.Styles.TemaOscuro());
            }
            else if (radioButton == RBclaro)
            {
                mergedDictionaries.Add(new ProyectoFinalDI.Resources.Styles.TemaClaro());
            }
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

    private void Confirmar_Clicked(object sender, EventArgs e)
    {

    }
}