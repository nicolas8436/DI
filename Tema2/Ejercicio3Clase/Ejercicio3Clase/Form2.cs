using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3Clase
{
    public partial class AgregarIngeniero : Form
    {
        public AgregarIngeniero()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnCancelar_click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void btnAceptar_click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbNombre.Text) ||
                string.IsNullOrWhiteSpace(txtBPrimerApe.Text) ||
                string.IsNullOrWhiteSpace(txtBSegundoApe.Text) ||
                string.IsNullOrWhiteSpace(txtBTelefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Forestal IngenieroCreado = new Forestal
            (
                txtbNombre.Text.Trim(),
                txtBPrimerApe.Text.Trim(),
                txtBSegundoApe.Text.Trim(),
                txtBTelefono.Text.Trim()
            );

            this.Close();


        }

        private void AgregarIngeniero_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
