namespace Ejercicio2Clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblResolucion_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Rdb640x480(object sender, EventArgs e)
        {
            if (chbVentana2.Checked)
            {

            }
            else if(rdbResolucion1.Checked)
            {
                this.Size = new Size(640, 480);
            }
        }

        private void Rdb800x600(object sender, EventArgs e)
        {
            if (chbVentana2.Checked)
            {

            }
            else if(rdbResolucion2.Checked)
            {
                this.Size = new Size(800, 600);
            }
        }
        private void Rdb1024x768(object sender, EventArgs e)
        {   if (chbVentana2.Checked) { 

            }else if (rdbResolucion3.Checked)
            {
                this.Size = new Size(1024, 768);
            }
        }

        private void chbVentana_Max(object sender, EventArgs e)
        {
            if (chbVentana2.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
            } else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
