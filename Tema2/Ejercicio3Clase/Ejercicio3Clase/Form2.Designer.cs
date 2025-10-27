namespace Ejercicio3Clase
{
    partial class AgregarIngeniero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblTlf = new Label();
            lblApe2 = new Label();
            lblApe1 = new Label();
            txtbNombre = new TextBox();
            txtBPrimerApe = new TextBox();
            txtBSegundoApe = new TextBox();
            txtBTelefono = new TextBox();
            btnAceptar = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ImageAlign = ContentAlignment.TopRight;
            lblNombre.Location = new Point(7, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(199, 38);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleRight;
            lblNombre.Click += label1_Click;
            // 
            // lblTlf
            // 
            lblTlf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTlf.ImageAlign = ContentAlignment.TopRight;
            lblTlf.Location = new Point(7, 143);
            lblTlf.Name = "lblTlf";
            lblTlf.Size = new Size(199, 38);
            lblTlf.TabIndex = 1;
            lblTlf.Text = "Telefono";
            lblTlf.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblApe2
            // 
            lblApe2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApe2.ImageAlign = ContentAlignment.TopRight;
            lblApe2.Location = new Point(7, 105);
            lblApe2.Name = "lblApe2";
            lblApe2.Size = new Size(199, 38);
            lblApe2.TabIndex = 2;
            lblApe2.Text = "Segundo Apellido";
            lblApe2.TextAlign = ContentAlignment.MiddleRight;
            lblApe2.Click += label2_Click;
            // 
            // lblApe1
            // 
            lblApe1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApe1.ImageAlign = ContentAlignment.TopRight;
            lblApe1.Location = new Point(7, 67);
            lblApe1.Name = "lblApe1";
            lblApe1.Size = new Size(199, 38);
            lblApe1.TabIndex = 3;
            lblApe1.Text = "Primer Apellido";
            lblApe1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbNombre
            // 
            txtbNombre.Location = new Point(212, 38);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(305, 27);
            txtbNombre.TabIndex = 4;
            // 
            // txtBPrimerApe
            // 
            txtBPrimerApe.Location = new Point(212, 76);
            txtBPrimerApe.Name = "txtBPrimerApe";
            txtBPrimerApe.Size = new Size(305, 27);
            txtBPrimerApe.TabIndex = 5;
            // 
            // txtBSegundoApe
            // 
            txtBSegundoApe.Location = new Point(212, 114);
            txtBSegundoApe.Name = "txtBSegundoApe";
            txtBSegundoApe.Size = new Size(305, 27);
            txtBSegundoApe.TabIndex = 6;
            txtBSegundoApe.TextChanged += textBox3_TextChanged;
            // 
            // txtBTelefono
            // 
            txtBTelefono.Location = new Point(212, 152);
            txtBTelefono.Name = "txtBTelefono";
            txtBTelefono.Size = new Size(305, 27);
            txtBTelefono.TabIndex = 7;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(504, 195);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 42);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(401, 195);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 42);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancelar_click;
            // 
            // AgregarIngeniero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 249);
            Controls.Add(btnCancel);
            Controls.Add(btnAceptar);
            Controls.Add(txtBTelefono);
            Controls.Add(txtBSegundoApe);
            Controls.Add(txtBPrimerApe);
            Controls.Add(txtbNombre);
            Controls.Add(lblApe1);
            Controls.Add(lblApe2);
            Controls.Add(lblTlf);
            Controls.Add(lblNombre);
            MaximumSize = new Size(628, 296);
            MinimumSize = new Size(628, 296);
            Name = "AgregarIngeniero";
            Text = "Agregar Ingeniero";
            FormClosing += AgregarIngeniero_FormClosing;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblTlf;
        private Label lblApe2;
        private Label lblApe1;
        private TextBox txtbNombre;
        private TextBox txtBPrimerApe;
        private TextBox txtBSegundoApe;
        private TextBox txtBTelefono;
        private Button btnAceptar;
        private Button btnCancel;
    }
}