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
    public partial class Form4 : Form
    {
        private Form1 f1;

        public Form4(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) { 
            if(f1.eliminar(listBox1.SelectedItem.ToString()) == true) { 
            MessageBox.Show("Persona eliminada correctamente");
            this.Close();}
            else {
                MessageBox.Show("Error al eliminar a la persona");
                this.Close();
            }
            }else
            {
                MessageBox.Show("Debe añadir personas primero");
                this.Close();
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {   
            List<string> listaApellidos = new List<string>();
            Anchor = AnchorStyles.Left | AnchorStyles.Top;
            foreach (Persona p in f1.ObtenerPersonas())
            {
                string apellidos = p.Ap1.ToString() +" "+ p.Ap2.ToString();
                listaApellidos.Add(apellidos);
            }

            listBox1.DataSource = listaApellidos;
        }
    }
}
