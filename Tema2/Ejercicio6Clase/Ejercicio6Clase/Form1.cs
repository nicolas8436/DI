using System.Diagnostics.Eventing.Reader;

namespace Ejercicio6Clase
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
        
        private FormDoc ultimoFormDoc;
        private void menuOpcNuevo_Click(object sender, EventArgs e)
        {
            FormDoc nuevoForm = new FormDoc();

            if (ultimoFormDoc != null && !ultimoFormDoc.IsDisposed)
            {
                nuevoForm.Text = ultimoFormDoc.Text;
            }

            nuevoForm.MdiParent = this;
            nuevoForm.Show();
            
            ultimoFormDoc = nuevoForm;


        }
    }
}
