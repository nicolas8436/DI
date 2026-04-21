using ProyectoFinalDI.Models;
using ProyectoFinalDI.Servicios;
using Syncfusion.Maui.Toolkit.Charts;

namespace ProyectoFinalDI.Vistas;

/// <summary>
/// Pagina de Informes(Syncfusion)
/// </summary>
public partial class Informes : ContentPage
{
    /// <summary>
    /// Construxtor de Informes, inizializa los componentes
    /// </summary>
    public Informes()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Override que recarga la pagina para mostrar los datos de los informes
    /// </summary>
    protected override void OnAppearing()
    {
        base.OnAppearing();
        CargarInformes();
    }

    /// <summary>
    /// Metodo que carga y formatea los datos que se van a mostrar en los informes
    /// </summary>
    private void CargarInformes()
    {
        try
        {
            BD.Instance.AbrirConexion(this);
            List<RegistroTemperatura> datos = BD.Instance.ObtenerHistorialGlobal(this);//Carga los datos de la bd a la lista
            BD.Instance.CerrarConexion(this);

            if (datos != null && datos.Any())
            {
                var gruposPorAula = datos.GroupBy(x => x.COD_EST).ToList();//Clasifica datos por aula

                BindableLayout.SetItemsSource(ContenedorGraficos, gruposPorAula);
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
    }
}