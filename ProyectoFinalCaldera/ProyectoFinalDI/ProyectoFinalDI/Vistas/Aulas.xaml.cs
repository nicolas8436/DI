using System.Collections.ObjectModel;
using ProyectoFinalDI.Servicios;
using System.Net.Http;

namespace ProyectoFinalDI.Vistas;

public partial class Aulas : ContentPage
{
    public ObservableCollection<AulaClase> ListaAulas { get; set; }
    public bool configurar { get; set; }
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

    private void CargarAulas()
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

    private async void Configurar_Clicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var aula = button.CommandParameter.ToString();

        await Navigation.PushAsync(new Aula(aula));
    }

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
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                // Uso de paquete nuget que no se como se llama ahora mismo
                var resultado = await response.Content.ReadAsAsync<ProyectoFinalDI.Servicios.ApiWheather>();

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
}