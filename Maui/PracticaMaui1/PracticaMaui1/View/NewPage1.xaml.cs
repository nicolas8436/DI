using Microsoft.Maui.Controls;

namespace PracticaMaui1.View
{
    public partial class NewPage1 : ContentPage
    {
        public NewPage1()
        {
            InitializeComponent();
        }

        // Método para el botón btnTest
        private void btnTest_Clicked(object sender, EventArgs e)
        {
            // Aquí va el código que se ejecutará cuando se haga clic en el botón
            // Por ejemplo:
            DisplayAlert("Mensaje", "Botón clickeado!", "OK");
        }

        // Método para el CheckBox
        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (lblChk != null)
            {
                lblChk.Text = e.Value ? "Activado" : "Desactivado";
            }
        }

        // Método para el Slider
        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (lblSlider != null)
            {
                lblSlider.Text = $"Valor: {e.NewValue:F2}";
            }
        }

        // Método para el Stepper
        private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            // Código para el cambio de valor del Stepper
            // Por ejemplo:
            // lblStepper.Text = $"Valor: {e.NewValue}";
        }

        // Método para el Switch
        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            // Código para el cambio de estado del Switch
            // Por ejemplo:
            // DisplayAlert("Switch", $"Estado: {e.Value}", "OK");
        }

        // Método para el DatePicker
        private void fecha_DateSelected(object sender, DateChangedEventArgs e)
        {
            // Código para cuando se selecciona una fecha
            // Por ejemplo:
            // DisplayAlert("Fecha", $"Fecha seleccionada: {e.NewDate.ToShortDateString()}", "OK");
        }
    }
}