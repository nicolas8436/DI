using ProyectoFinalDI.Models;
using ProyectoFinalDI.Servicios;
using Syncfusion.Maui.Toolkit.Charts;

namespace ProyectoFinalDI.Vistas;

public partial class Informes : ContentPage
{
    public Informes()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        CargarInformes();
    }

    private void CargarInformes()
    {
        try
        {
            BD.Instance.AbrirConexion(this);
            List<RegistroTemperatura> datos = BD.Instance.ObtenerHistorialGlobal(this);
            BD.Instance.CerrarConexion(this);

            if (datos != null && datos.Any())
            {
                var gruposPorAula = datos.GroupBy(x => x.COD_EST).ToList();

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    BindableLayout.SetItemsSource(ContenedorGraficos, gruposPorAula);
                });
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
    }
}