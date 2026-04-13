namespace ProyectoFinalDI.Vistas;

using ProyectoFinalDI.Servicios;
using System.Text.RegularExpressions;
using System.Transactions;

public partial class Aula : ContentPage
{
	private String aula;
	private String temp_conf;
	private String temp_act;

	public Aula(String aula)
	{
		this.aula = aula;
		
		InitializeComponent();
		datos_Temp();
		TituloAula.Text += " " + aula;
		AulaXX.Text += " " + aula;
    }

	public void datos_Temp()
	{
		BD.Instance.AbrirConexion(this);

		temp_conf = BD.Instance.Temp_Conf(aula, this);
		temp_act = BD.Instance.Temp_Act(aula, this);

		TempAct.Text = temp_act + "ºC";
		TempConf.Text = temp_conf + "ºC";
		
		BD.Instance.CerrarConexion(this);
    }

    private async void Cancelar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Confirmar_Clicked(object sender, EventArgs e)
    {
        BD.Instance.AbrirConexion(this);
        if (NuevaTemp.Text != null && Regex.IsMatch(NuevaTemp.Text, "^(1[8-9]|2[0-9]|30)$")) { 
			bool operacion;
			operacion = BD.Instance.Cambio_Conf(aula, this, NuevaTemp.Text);

			if (operacion) {

                TempConf.Text = NuevaTemp.Text + "°C";
                NuevaTemp.Text = "";

                await DisplayAlert("Exito","Temperatura de confort actualizada correctamente","OK");
            }
			else {
                await DisplayAlert("Error", "Fallo al actualizar la temperatura de confort", "OK"); 
			};

			BD.Instance.CerrarConexion(this);
        } else
		{
            await DisplayAlert("Error", "Debes poner una temperatura de confort valida", "OK");

        }
    }
}