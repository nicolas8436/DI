namespace Ejercicio3Clase
{
    partial class VerForestal
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
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ImageAlign = ContentAlignment.TopRight;
            lblNombre.Location = new Point(29, 46);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(199, 38);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTlf
            // 
            lblTlf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTlf.ImageAlign = ContentAlignment.TopRight;
            lblTlf.Location = new Point(29, 160);
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
            lblApe2.Location = new Point(29, 122);
            lblApe2.Name = "lblApe2";
            lblApe2.Size = new Size(199, 38);
            lblApe2.TabIndex = 2;
            lblApe2.Text = "Segundo Apellido";
            lblApe2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblApe1
            // 
            lblApe1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApe1.ImageAlign = ContentAlignment.TopRight;
            lblApe1.Location = new Point(29, 84);
            lblApe1.Name = "lblApe1";
            lblApe1.Size = new Size(199, 38);
            lblApe1.TabIndex = 3;
            lblApe1.Text = "Primer Apellido";
            lblApe1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtbNombre
            // 
            txtbNombre.Location = new Point(234, 55);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(305, 27);
            txtbNombre.TabIndex = 4;
            // 
            // txtBPrimerApe
            // 
            txtBPrimerApe.Location = new Point(234, 93);
            txtBPrimerApe.Name = "txtBPrimerApe";
            txtBPrimerApe.Size = new Size(305, 27);
            txtBPrimerApe.TabIndex = 5;
            // 
            // txtBSegundoApe
            // 
            txtBSegundoApe.Location = new Point(234, 131);
            txtBSegundoApe.Name = "txtBSegundoApe";
            txtBSegundoApe.Size = new Size(305, 27);
            txtBSegundoApe.TabIndex = 6;
            // 
            // txtBTelefono
            // 
            txtBTelefono.Location = new Point(234, 169);
            txtBTelefono.Name = "txtBTelefono";
            txtBTelefono.Size = new Size(305, 27);
            txtBTelefono.TabIndex = 7;
            // 
            // VerForestal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 249);
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
            Name = "VerForestal";
            Text = "VerForestal";
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
    }
}