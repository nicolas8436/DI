namespace RepasoExamen
{
    public partial class Form1 : Form
    {
        private List<Persona> personas;
        public List<Form3> forms;
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.personas = new List<Persona>();
            forms = new List<Form3>();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.MdiParent = this;
            f2.Show();

        }

        public void AgregarPersona(Persona p)
        {
            personas.Add(p);
        }

        private void Eliminar_click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this);
            f4.ShowDialog();
        }

        public List<Persona> ObtenerPersonas()
        {
            return personas;
        }

        public bool eliminar(String apellidos)
        {
            foreach (Persona p in personas)
            {
                if ((p.Ap1 + " " + p.Ap2).Equals(apellidos))
                {
                    personas.Remove(p);
                    return true;

                }
                else
                {
                    MessageBox.Show("Error al eliminar a la persona");
                    return false;
                }
            }

            return false;
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            foreach (Persona p in personas)
            {
                Form3 f3 = new Form3();
                forms.Add(f3);
                f3.MdiParent = this;
                f3.rellenar(p);
                f3.Show();
            }
        }

        private void CerrarTodo_Click(object sender, EventArgs e)
        {
            try { 
            foreach (Form3 f3 in forms)
            {
                f3.cerrar();
            }
                forms.Clear();
            }
            catch(Exception a)
            {
                MessageBox.Show("Error al cerrar los form3");
            }
        }
    }
}
