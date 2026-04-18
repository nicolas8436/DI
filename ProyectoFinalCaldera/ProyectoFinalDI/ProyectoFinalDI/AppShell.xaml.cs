namespace ProyectoFinalDI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            ActualizarNavegacion(0);//Rol a 0 (No registrado)
        }

        public void ActualizarNavegacion(int rol)
        {   
            //Lista de usuarios
            PestanaListaUsr.IsVisible = (rol == 1);

            //Configuracion
            PestanaConfig.IsVisible = (rol >= 1 && rol <= 3);
        }
    }
}