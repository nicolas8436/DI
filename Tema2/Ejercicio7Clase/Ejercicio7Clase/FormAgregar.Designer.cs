namespace Ejercicio7Clase
{
    partial class FormAgregar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBPoblacion = new TextBox();
            txtBNombre = new TextBox();
            txtBDistrito = new TextBox();
            txtBCodPais = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 35);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo de pais";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 126);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Distrito";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 80);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 171);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Poblacion";
            // 
            // txtBPoblacion
            // 
            txtBPoblacion.Location = new Point(193, 168);
            txtBPoblacion.Name = "txtBPoblacion";
            txtBPoblacion.Size = new Size(125, 27);
            txtBPoblacion.TabIndex = 4;
            txtBPoblacion.TextChanged += textBox1_TextChanged;
            // 
            // txtBNombre
            // 
            txtBNombre.Location = new Point(193, 77);
            txtBNombre.Name = "txtBNombre";
            txtBNombre.Size = new Size(125, 27);
            txtBNombre.TabIndex = 5;
            // 
            // txtBDistrito
            // 
            txtBDistrito.Location = new Point(193, 123);
            txtBDistrito.Name = "txtBDistrito";
            txtBDistrito.Size = new Size(125, 27);
            txtBDistrito.TabIndex = 6;
            // 
            // txtBCodPais
            // 
            txtBCodPais.Location = new Point(193, 32);
            txtBCodPais.Name = "txtBCodPais";
            txtBCodPais.Size = new Size(125, 27);
            txtBCodPais.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(280, 250);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAgregar_Click;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 291);
            Controls.Add(button1);
            Controls.Add(txtBCodPais);
            Controls.Add(txtBDistrito);
            Controls.Add(txtBNombre);
            Controls.Add(txtBPoblacion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAgregar";
            Text = "FormAgregar";
            Load += FormAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBPoblacion;
        private TextBox txtBNombre;
        private TextBox txtBDistrito;
        private TextBox txtBCodPais;
        private Button button1;
    }
}