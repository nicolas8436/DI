using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7Clase
{
    public partial class FormAgregar : Form
    {
        private BBDD baseDatos;

        // Propiedades para comunicar con Form1
        public bool CiudadAgregada { get; private set; }
        public string CodigoPais { get; private set; }

        // Modifica el constructor para recibir la BBDD
        public FormAgregar(BBDD baseDatos)
        {
            InitializeComponent();
            this.baseDatos = baseDatos;
            this.CiudadAgregada = false;
            this.CodigoPais = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            // Poner el foco en el primer campo al cargar el formulario
            txtBNombre.Focus();
        }

        // Añade este método para el botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtBNombre.Text) ||
                string.IsNullOrWhiteSpace(txtBCodPais.Text) ||
                string.IsNullOrWhiteSpace(txtBDistrito.Text) ||
                string.IsNullOrWhiteSpace(txtBPoblacion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos", "Error");
                return;
            }

            // Validar que la población sea un número válido
            if (!int.TryParse(txtBPoblacion.Text, out int poblacion) || poblacion < 0)
            {
                MessageBox.Show("La poblacion debe ser un numero mayor o igual a 0", "Error");
                return;
            }

            // Validar longitud del código de país
            if (txtBCodPais.Text.Length != 3)
            {
                MessageBox.Show("El codigo de pais debe tener exactamente 3 caracteres", "Error");
                return;
            }

            try
            {
                // Llamar al método para agregar la ciudad
                bool exito = baseDatos.AgregarCiudad(
                    txtBNombre.Text.Trim(),
                    txtBCodPais.Text.Trim().ToUpper(),
                    txtBDistrito.Text.Trim(),
                    poblacion
                );

                if (exito)
                {
                    MessageBox.Show("Ciudad agregada correctamente", "Éxito");

                    this.CiudadAgregada = true;
                    this.CodigoPais = txtBCodPais.Text.Trim().ToUpper();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar la ciudad. Verifique el código de país.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la ciudad: {ex.Message}", "Error");
            }
        }


        //Solo num
        private void txtPoblacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Mayusculas
        private void txtCodigoPais_TextChanged(object sender, EventArgs e)
        {
            txtBCodPais.CharacterCasing = CharacterCasing.Upper;
        }
    }
}