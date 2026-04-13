using System;
using Microsoft.Maui.Controls;

namespace ProyectoFinalDI.Vistas
{
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private async void InicioS_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InicioSesion());
        }

        private async void Registro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }
    }
}