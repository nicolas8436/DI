using System;
using Microsoft.Maui.Controls;

namespace ProyectoFinalDI.Vistas
{

    /// <summary>
    /// Pagina de Inicio
    /// </summary>
    public partial class Inicio : ContentPage
    {
        /// <summary>
        /// Constructor de Inicio, inizia los componentes de la pagina
        /// </summary>
        public Inicio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Boton que lleva a la pagina de inicio de sesion
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos el evento</param>
        private async void InicioS_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InicioSesion());
        }

        /// <summary>
        /// Boton que lleva a la pagina de registro de usuario
        /// </summary>
        /// <param name="sender">Objeto que dispara el evento</param>
        /// <param name="e">Argumentos el evento</param>
        private async void Registro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }
    }
}