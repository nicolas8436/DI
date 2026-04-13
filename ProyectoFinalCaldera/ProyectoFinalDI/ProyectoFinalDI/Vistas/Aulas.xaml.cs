using System.Collections.ObjectModel;

namespace ProyectoFinalDI.Vistas;

public partial class Aulas : ContentPage
{
    public ObservableCollection<AulaClase> ListaAulas { get; set; }

    public Aulas()
    {
        InitializeComponent();

        ListaAulas = new ObservableCollection<AulaClase>
        {
            new AulaClase { Nombre="A23", TempActual="33°C", TempConfort="33°C", EstadoCaldera="Encendida" },
            new AulaClase { Nombre="A24", TempActual="30°C", TempConfort="32°C", EstadoCaldera="Apagada" },
            new AulaClase { Nombre="A25", TempActual="29°C", TempConfort="31°C", EstadoCaldera="Encendida" },
            new AulaClase { Nombre="A26", TempActual="28°C", TempConfort="30°C", EstadoCaldera="Apagada" },
            new AulaClase { Nombre="A27", TempActual="33°C", TempConfort="33°C", EstadoCaldera="Encendida" }
        };

        BindingContext = this;
    }

    private async void Configurar_Clicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var aula = button.CommandParameter.ToString();

        await Navigation.PushAsync(new Aula(aula));
    }
}