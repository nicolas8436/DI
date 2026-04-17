using System.Collections.ObjectModel;
using ProyectoFinalDI.Servicios;

namespace ProyectoFinalDI.Vistas;

public partial class Aulas : ContentPage
{
    public ObservableCollection<AulaClase> ListaAulas { get; set; }

    public Aulas()
    {
        InitializeComponent();

        ListaAulas = new ObservableCollection<AulaClase>();

        BindingContext = this;

        CargarAulas();
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
}