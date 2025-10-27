namespace Ejercicio5Clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TxtBResul.Hide();
            btnResultado.Visible = false;
        }

        private void menuOpcAyuda_click(object sender, EventArgs e)
        {
            MessageBox.Show("Llama al Psicologo");
        }

        private void Suma()
        {
            int Num1; int Num2;

            try
            {
                Num1 = int.Parse(TxtBNum1.Text);
                Num2 = int.Parse(TxtBNum2.Text);

                int resultado = Num1 + Num2;

                String resul = resultado.ToString();

                TxtBResul.Text = resul;
                TxtBResul.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Solo puedes introducir numeros");
            }


        }

        private void Resta()
        {
            int Num1; int Num2;

            try
            {
                Num1 = int.Parse(TxtBNum1.Text);
                Num2 = int.Parse(TxtBNum2.Text);

                int resultado = Num1 - Num2;

                String resul = resultado.ToString();

                TxtBResul.Text = resul;
                TxtBResul.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Debes introducir numeros");
            }


        }

        private void Multiplicacion()
        {
            int Num1; int Num2;

            try
            {
                Num1 = int.Parse(TxtBNum1.Text);
                Num2 = int.Parse(TxtBNum2.Text);

                int resultado = Num1 * Num2;

                String resul = resultado.ToString();

                TxtBResul.Text = resul;
                TxtBResul.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Solo puedes introducir numeros");
            }


        }

        private void Division()
        {
            int Num1; int Num2;

            try
            {
                Num1 = int.Parse(TxtBNum1.Text);
                Num2 = int.Parse(TxtBNum2.Text);

                int resultado = Num1 / Num2;

                String resul = resultado.ToString();

                TxtBResul.Text = resul;
                TxtBResul.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Solo puedes introducir numeros");
            }


        }


        private void OpcSuma_Click(object sender, EventArgs e)
        {
            MenuOpcHerramientasSuma.Checked = true;
            MenuOpcHerramientasDivision.Checked = false;
            MenuOpcHerramientasMultiplicacion.Checked = false;
            MenuOpcHerramientasResta.Checked = false;

            btnResultado.Text = "+";
            btnResultado.Visible = true;

        }

        private void OpcResta_Click(object sender, EventArgs e)
        {
            MenuOpcHerramientasSuma.Checked = false;
            MenuOpcHerramientasDivision.Checked = false;
            MenuOpcHerramientasMultiplicacion.Checked = false;
            MenuOpcHerramientasResta.Checked = true;

            btnResultado.Text = "-";
            btnResultado.Visible = true;
        }

        private void OpcMultiplicacion_Click(object sender, EventArgs e)
        {
            MenuOpcHerramientasSuma.Checked = false;
            MenuOpcHerramientasDivision.Checked = false;
            MenuOpcHerramientasMultiplicacion.Checked = true;
            MenuOpcHerramientasResta.Checked = false;

            btnResultado.Text = "*";
            btnResultado.Visible = true;
        }

        private void OpcDivision_Click(object sender, EventArgs e)
        {
            MenuOpcHerramientasSuma.Checked = false;
            MenuOpcHerramientasDivision.Checked = true;
            MenuOpcHerramientasMultiplicacion.Checked = false;
            MenuOpcHerramientasResta.Checked = false;

            btnResultado.Text = "/";
            btnResultado.Visible = true;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

            if (MenuOpcHerramientasSuma.Checked == true)
            {
                Suma();
            }
            else if (MenuOpcHerramientasResta.Checked == true)
            {
                Resta();
            }
            else if (MenuOpcHerramientasMultiplicacion.Checked == true)
            {
                Multiplicacion();
            }
            else if (MenuOpcHerramientasDivision.Checked == true)
            {
                Division();
            }


        }

        private void salir_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtBNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CMBorrar_click(object sender, EventArgs e)
        {
            if () { 
            TxtBNum1.Text = "";
            }

            if () { 
            TxtBNum2.Text = "";
            }

        }

        private void CM0_click(object sender, EventArgs e)
        {
            if ()
            {
                TxtBNum1.Text = "0";
            }

            if ()
            {
                TxtBNum2.Text = "0";
            }

        }

        private void CMRandom_click(object sender, EventArgs e)
        {   
            Random rnd = new Random();
            if ()
            {

                int numR = rnd.Next();

                String numRText = rnd.ToString();
                TxtBNum1.Text = numRText;
            }

            if ()
            {
                int numR = rnd.Next();

                String numRText = rnd.ToString();

                TxtBNum2.Text = numRText;
            }

        }
    }
}
