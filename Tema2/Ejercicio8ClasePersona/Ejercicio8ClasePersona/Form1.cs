using Ejercicio7Clase;

namespace Ejercicio8ClasePersona
{
    public partial class Form1 : Form
    {
        private BBDD miBBDD = new BBDD();
        public Form1()
        {
            InitializeComponent();
            btnConectar.Enabled=true;
            btnActualizar.Enabled=false;
            btnAgregar.Enabled=false;
            btnEliminar.Enabled=false;
            textBox1.Enabled=false;
            textBox2.Enabled=false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            if (conectar())
            {
                btnConectar.Enabled = false;
                btnActualizar.Enabled = true;
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            } else
            {
                MessageBox.Show("Error al conectar a la base de datos");
            }

        }
    }
}
