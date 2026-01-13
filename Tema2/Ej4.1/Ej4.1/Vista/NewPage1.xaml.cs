namespace Ej4._1.Vista;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
   /* private void OnButtonClicked(object sender, System.EventArgs e)
    {
        if (sender is Button button)
        {
            // Cambiar HorizontalOptions directamente
            if (button.Text == "Inicio")
            {
                Mov.HorizontalTextAlignment = TextAlignment.Start;
                Mov.Text = "Hola";
            }
            else if (button.Text == "Medio")
            {
                Mov.HorizontalTextAlignment = TextAlignment.Center;
                Mov.Text = "Hola";
            }
            else if (button.Text == "Fin")
            {
                Mov.HorizontalTextAlignment = TextAlignment.End;
                Mov.Text = "Hola";
            }

            // Forzar actualización del layout
            Dispatcher.Dispatch(() =>
            {
                Mov.InvalidateMeasure();
            });
        }
    }*/
}