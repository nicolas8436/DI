using System.Runtime.CompilerServices;

namespace Ejercicio3Clase
{
    public partial class ListaIngenieros : Form
    {
        public ListaIngenieros()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnContar_Click(object sender, EventArgs e)
        {

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_click(object sender, EventArgs e)
        {
            AgregarIngeniero formAgregarIn = new AgregarIngeniero();
            formAgregarIn.Show();
            this.Hide();

            formAgregarIn.FormClosed += (s, args) => this.Show();
            formAgregarIn.Show();

        }

        private void cierreAgregacion(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
