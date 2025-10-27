using System.Runtime.InteropServices.ObjectiveC;

namespace Ejercicio2Clase
{
    public partial class Form1 : Form
    {
        private List<Coche> listaCoches;
        public Form1()
        {
            InitializeComponent();
        }


        private void Rdb640x480(object sender, EventArgs e)
        {
            if (chbVentana2.Checked)
            {

            }
            else if (rdbResolucion1.Checked)
            {
                this.Size = new Size(640, 480);
            }
        }

        private void Rdb800x600(object sender, EventArgs e)
        {
            if (chbVentana2.Checked)
            {

            }
            else if (rdbResolucion2.Checked)
            {
                this.Size = new Size(800, 600);
            }
        }
        private void Rdb1024x768(object sender, EventArgs e)
        {
            if (chbVentana2.Checked)
            {

            }
            else if (rdbResolucion3.Checked)
            {
                this.Size = new Size(1024, 768);
            }
        }

        private void chbVentana_Max(object sender, EventArgs e)
        {
            if (chbVentana2.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void form1_load(object sender, EventArgs e)
        {
           /* for (int i = 0; i < listBox1.Items.Count; i++)
            {
                comboBox1.Items.Add(listBox1.Items[i].ToString());

            }
            comboBox1.Items.Add("Mazda");*/

            listaCoches = new List<Coche>();
            listaCoches.Add(new Coche("Audi", "R8"));
            listaCoches.Add(new Coche("Ford", "Mustang GT"));
            listaCoches.Add(new Coche("Bmw", "420d"));

            listBox1.DataSource = listaCoches;
            comboBox1.DataSource = listaCoches;
        }
    }
}
