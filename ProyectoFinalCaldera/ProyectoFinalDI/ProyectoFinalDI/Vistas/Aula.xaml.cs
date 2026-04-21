namespace ProyectoFinalDI.Vistas;

using ProyectoFinalDI.Servicios;
using System.Text.RegularExpressions;
using System.Transactions;

/// <summary>
/// Representa la pagina de Configuracion del aula
/// </summary>
public partial class Aula : ContentPage
{
	/// <summary>
	/// Atributo con el nombre del aula
	/// </summary>
	private String aula;

	/// <summary>
	/// Atributo con la temperatura de confort del aula
	/// </summary>
	private String temp_conf;

	/// <summary>
	/// Atributo con la temperatura actual del aula
	/// </summary>
	private String temp_act;

	/// <summary>
	/// Constructor de la clase aula Inizializa los componentes y llena los label en funcion del aula a la que se accede
	/// </summary>
	/// <param name="aula">Nombre del aula para buscar los datos necesarios</param>
	public Aula(String aula)
	{
		this.aula = aula;
		
		InitializeComponent();
		datos_Temp();
		TituloAula.Text += " " + aula;
		AulaXX.Text += " " + aula;
    }

	/// <summary>
	/// CLase que obtiene los datos de la temperatura de confort y actual para llenar los label con esa informacion
	/// </summary>
	public void datos_Temp()
	{
		BD.Instance.AbrirConexion(this);

		temp_conf = BD.Instance.Temp_Conf(aula, this);
		temp_act = BD.Instance.Temp_Act(aula, this);

		TempAct.Text = temp_act + "ºC";
		TempConf.Text = temp_conf + "ºC";
		
		BD.Instance.CerrarConexion(this);
    }

    /// <summary>
    /// Vuelve a la pagina de aulas (cancela la edicion de temperatura del aula)
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
    private async void Cancelar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    /// <summary>
    /// Lee del entry y cambia la temperatura de confort del aula seleccionada
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
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