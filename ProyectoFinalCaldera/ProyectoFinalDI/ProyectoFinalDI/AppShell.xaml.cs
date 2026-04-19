using ProyectoFinalDI.Servicios;

namespace ProyectoFinalDI;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        int rol = Persona.Instance.GetRol();

        if (rol == 0) // No logueado
        {
            SeccionAulas.IsVisible = false;
        }
        else
        {
            // Mostramos la sección de la hamburguesa que contiene las pestañas
            SeccionAulas.IsVisible = true;

            // Controlamos las pestañas individuales dentro de esa sección
            // Solo Admin (Rol 1) ve Usuarios e Informes
            TabUsuarios.IsVisible = (rol == 1);
            TabInformes.IsVisible = (rol == 1);

            // Registrados ven Configuración y la pestaña principal de Aulas
            TabConfig.IsVisible = (rol >= 1 && rol <= 3);
        }
    }
}