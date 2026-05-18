using System.Collections.ObjectModel;
using ProyectoFinalDI.Servicios;
using System.Net.Http;

namespace ProyectoFinalDI.Vistas;

/// <summary>
/// Pagina de visualizacion de las aulas del centro
/// </summary>
public partial class Aulas : ContentPage
{
    /// <summary>
    /// Listado de aulas sacado de la BD
    /// </summary>
    public ObservableCollection<AulaClase> ListaAulas { get; set; }

    /// <summary>
    /// Variable para saber si el usuario puede configurar el aula (Rol 1 o 2)
    /// </summary>
    public bool configurar { get; set; }

    /// <summary>
    /// Constructor de la pagina; inizializa la pagina, comprueba el rol y carga los datos de la BD
    /// </summary>
    public Aulas()
    {
        InitializeComponent();

        int rol = Persona.Instance.GetRol();
        if (rol == 3) { configurar = false; } else { configurar = true; }

        ListaAulas = new ObservableCollection<AulaClase>();

        BindingContext = this;

        CargarAulas();
        CargarClima();


    }
    /// <summary>
    /// Metodo CargarAulas: Este metodo actualiza la informacion de las aulas con los datos de la base de datos
    /// </summary>
    public void CargarAulas()
    {
        if (BD.Instance.AbrirConexion(this))
        {
            var datos = BD.Instance.ObtenerAulas(this);

            ListaAulas.Clear();

            foreach (var aula in datos)
                ListaAulas.Add(aula);

            BD.Instance.CerrarConexion(this);
        }
    }

    /// <summary>
    /// Metodo del boton de configuracion, abre la pagina de configuracion del aula solo disponible para admin y superadmin 
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
    private async void Configurar_Clicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var aula = button.CommandParameter.ToString();

        await Navigation.PushAsync(new Aula(aula, this));
    }

    /// <summary>
    /// Metodo para eliminar un aula de la BD
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento</param>
    /// <param name="e">Argumentos el evento</param>
    private async void Eliminar_Clicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var aula = button.CommandParameter as AulaClase;

        BD.Instance.AbrirConexion(this);

        if (BD.Instance.EliminarAula(aula.Nombre))
        {
            await DisplayAlert("Exito","Aula " + aula.Nombre + " eliminada","Ok");
            CargarAulas();
        }
        else
        {
            await DisplayAlert("Error al eliminar","Ha ocurrido un error al intentar eliminar el aula","Ok");
        }

        BD.Instance.CerrarConexion(this);
    }

    /// <summary>
    /// Consumo de la API, saca la informacion necesaria de la api y se la aplica a los label correspondientes
    /// </summary>
    private async void CargarClima()
{
    // 1. Cliente http para hacer las peticiones
    using (HttpClient client = new HttpClient())
    {
        // 2. Url para pedir a la api
        string url = "https://api.openweathermap.org/data/2.5/weather?q=Cuenca,es&appid=c64a0e8b3e404ede2c9ee219f5719c7c&lang=es&units=metric";

        try
        {
            // Peticion
            var peticion = await client.GetAsync(url);

            if (peticion.IsSuccessStatusCode)
            {
                // Uso de paquete nuget que no se como se llama ahora mismo
                var resultado = await peticion.Content.ReadAsAsync<ProyectoFinalDI.Servicios.ApiWheather>();

                //Texto sacado de la api
                LblCiudad.Text = resultado.Name;
                LblTemp.Text = $"{resultado.Main.Temp}°C";
                LblHumedad.Text = $"Humedad: {resultado.Main.Humidity}%";

                // Icono
                string iconCode = resultado.Weather[0].Icon;
                ImgClima.Source = $"https://openweathermap.org/img/wn/{iconCode}@2x.png";
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "No se pudo cargar el clima", "OK");
        }
    }
}

    private void Agregar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AñadirAula(this));
    }
}