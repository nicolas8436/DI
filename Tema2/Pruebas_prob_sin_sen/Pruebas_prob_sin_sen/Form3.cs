using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas_prob_sin_sen
{
    public partial class Form3 : Form
    {
        private Form1 formPrincipal;
        public Form3(Form1 f)
        {
            InitializeComponent();
            formPrincipal = f;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {

            formPrincipal.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

            }
            else if (radioButton1.Checked)
            {
                this.Size = new Size(1024, 768);
            }
        }

                private void radioButton2_CheckedChanged(object sender, EventArgs e)
                {

            if (checkBox1.Checked)
            {

            }
            else if (radioButton2.Checked)
            {
                this.Size = new Size(800, 600);
            }

        }
    }
}
