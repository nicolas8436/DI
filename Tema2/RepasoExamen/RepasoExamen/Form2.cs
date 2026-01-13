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
    public partial class Form2 : Form
    {
        public Form1 f1;

        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Agreger_Click(object sender, EventArgs e)
        {
            int tlf;

            if (TxtBTelefono.Text.Length < 9 || TxtBTelefono.Text.Length >= 10)
            {
                MessageBox.Show("El numero de telefono debe tener 9 numeros");
            }
            else if(TxtBNombre.Text.Equals("") || TxtBA1.Text.Equals("") || TxtBA2.Text.Equals("") || TxtBTelefono.Text.Equals(""))
            {
                MessageBox.Show("Los campos no pueden estar vacios y el numero de telefono debe tener 9 numeros");
            }
            else {
                
                Persona p = new Persona(TxtBNombre.Text, TxtBA1.Text, TxtBA2.Text, int.Parse(TxtBTelefono.Text));
                f1.AgregarPersona(p);
                this.Close(); 
                MessageBox.Show("Persona añadida correctamente");
            }

             
            
            
        }
    }
}
