using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoExamen
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void rellenar(Persona p)
        {
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Ap1;
            textBox3.Text = p.Ap2;
            textBox4.Text = p.Telefono.ToString();

        }

        public void cerrar()
        {
            this.Close();
        }
    }
}
