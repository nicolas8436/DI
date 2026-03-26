namespace Frutas.Vistas.Inicio;
/// <summary>
/// Clase de gestion para la content page de inicio
/// </summary>
public partial class InicioContentPage : ContentPage
{
    /// <summary>
    /// Constructor de la contentpage de inicio
    /// </summary>
    public InicioContentPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

        /// <summary>
        /// Metodo que se desencadena cuando se pulsa el boton 
        /// y se abre una nueva pagina
        /// </summary>
        /// <param name="sender">Evento que lo activa</param>
        /// <param name="e">Parametro que se le pasa</param>
        var window = Application.Current?.Windows.FirstOrDefault();
        if (window != null)
        {
            window.Page = new Navegacion.FrutaShell();
        }
        // Si no hay ventana, no hacer nada (opcional: mostrar mensaje de error).
    }
}