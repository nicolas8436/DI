namespace Frutas.Vistas.Inicio;

public partial class InicioContentPage : ContentPage
{
    public InicioContentPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Solución para CS0618 y CS8602:
        // Usar Application.Current.Windows[0].Page para cambiar la página raíz de la ventana principal.
        var window = Application.Current?.Windows.FirstOrDefault();
        if (window != null)
        {
            window.Page = new Navegacion.FrutaShell();
        }
        // Si no hay ventana, no hacer nada (opcional: mostrar mensaje de error).
    }
}