namespace Ejercicio1Clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCuadorDialogo_click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto es un cuadro de dialogo");

        }

        private void btnModal_click(object sender, EventArgs e)
        {
            FormModal nuevoformM = new FormModal(txtContenido.Text);
            nuevoformM.ShowDialog();
        }

        private void btn_noModal(object sender, EventArgs e)
        {
            FormNoModal nuevoformNoM = new FormNoModal(this, txtContenido.Text);
            nuevoformNoM.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
