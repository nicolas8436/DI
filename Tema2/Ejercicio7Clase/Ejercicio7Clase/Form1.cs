namespace Ejercicio7Clase
{
    public partial class Form1 : Form
    {

        private BBDD baseDatos;
        public Form1()
        {
            InitializeComponent();
            baseDatos = new BBDD();
        }

        private void chkVisible_click(object sender, EventArgs e)
        {
            if (chkVisible.Checked)
            {
                tbContraseña.PasswordChar = '\0';
            }
            else
            {
                tbContraseña.PasswordChar = '*';
            }
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (baseDatos.Conectar(tbServidor.Text, tbPuerto.Text, tbUsuario.Text, tbContraseña.Text))
            {
                dataGridView1.DataSource = baseDatos.ObtenerGrid();
            }
            else
            {
                MessageBox.Show("Se ha producido un error al acceder a la BBDD");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (baseDatos == null)
            {
                MessageBox.Show("Primero debe conectar a la base de datos");
                return;
            }

            // Pasa la instancia de BBDD al FormAgregar
            FormAgregar formAgregarCiudad = new FormAgregar(baseDatos);
            formAgregarCiudad.ShowDialog();

            // Opcional: Actualizar el DataGridView2 si se agregó una ciudad
            if (formAgregarCiudad.CiudadAgregada && dataGridView2.DataSource != null)
            {
                if (!string.IsNullOrEmpty(formAgregarCiudad.CodigoPais))
                {
                    dataGridView2.DataSource = baseDatos.obtenerDatos(formAgregarCiudad.CodigoPais);
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ///SI EL VALOR CLICKEADO (RECIBE COMO PARAM E, POR ESO SE USA E)
            if (e.RowIndex >= 0)
            {
                /// OBTENEMOS EL VALOR DE LA FILA (ROW) SOBRE LA QUE SE HA HECHO CLICK
                DataGridViewRow filaClick = dataGridView1.Rows[e.RowIndex];

                ///Pillamos el valor de la primera celda, en este caso al ser array seria 0
                String valorCodigo = filaClick.Cells[0].Value.ToString();

                ///MODIFGICAMOS EL VALOR DE dataGridView2

                dataGridView2.DataSource = baseDatos.obtenerDatos(valorCodigo);
                ///Devolvemos este valor :p
                ///
                ////V2 NO SE PUJEDE MODIFICAR EL EVENTO, TIENE QUE SER VOID SI O SI!!!!
                //return valorCodigo;
            }
            //MessageBox.Show(temp);
            //return null; /// ojo cuidao con abusar con null.
        }
    }
}
