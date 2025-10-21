using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1Clase
{
    public partial class FormNoModal : Form
    {

        private Form1 formPrincipal;
        public FormNoModal()
        {
            InitializeComponent();
        }

        public FormNoModal(Form1 f, string textoRecibido)
        {
            InitializeComponent();

            lbl.Text = textoRecibido;
            formPrincipal = f;
        }

        private void FormNoModal_FormClosing(object sender, FormClosingEventArgs e, string texto)
        {
            formPrincipal.Show();
            
        } 
    }
}
