using ProyectoFinalDI.Models;
using ProyectoFinalDI.Servicios;

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
        CargarPicker();
    }

    private void CargarPicker()
    {
        try
        {
            BD.Instance.AbrirConexion(this);
            var aulas = BD.Instance.ObtenerAulas(this);
            BD.Instance.CerrarConexion(this);

            if (aulas != null)
                PickerAulas.ItemsSource = aulas.Select(a => a.Nombre).ToList();
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", "Error al cargar aulas: " + ex.Message, "OK");
        }
    }

    private void PickerAulas_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (PickerAulas.SelectedIndex == -1) return;

        string aulaSeleccionada = PickerAulas.SelectedItem.ToString();

        BD.Instance.AbrirConexion(this);

        // --- CARGA INFORME 1 ---
        var datosTemp = BD.Instance.ObtenerHistorialPorAula(aulaSeleccionada);
        if (datosTemp != null && datosTemp.Any())
        {
            SeriesGrafico.ItemsSource = datosTemp;
            LabelAulaSeleccionada.Text = aulaSeleccionada;
            FrameGrafico.IsVisible = true;
        }

        // --- CARGA INFORME 2 ---
        var datosTiempos = BD.Instance.ObtenerTiemposActivos(aulaSeleccionada);
        if (datosTiempos != null && datosTiempos.Any())
        {
            SeriesTiempos.ItemsSource = datosTiempos;
            FrameTiempos.IsVisible = true;
        }

        BD.Instance.CerrarConexion(this);
    }
}