namespace Ejercicio2Clase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResolucion = new Label();
            panel1 = new Panel();
            chbVentana2 = new CheckBox();
            panel2 = new Panel();
            rdbResolucion2 = new RadioButton();
            rdbResolucion3 = new RadioButton();
            rdbResolucion1 = new RadioButton();
            lblVentana = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblResolucion
            // 
            lblResolucion.AutoSize = true;
            lblResolucion.Location = new Point(130, 105);
            lblResolucion.Name = "lblResolucion";
            lblResolucion.Size = new Size(81, 20);
            lblResolucion.TabIndex = 1;
            lblResolucion.Text = "Resolucion";
            lblResolucion.Click += lblResolucion_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(chbVentana2);
            panel1.Location = new Point(395, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 163);
            panel1.TabIndex = 2;
            // 
            // chbVentana2
            // 
            chbVentana2.AutoSize = true;
            chbVentana2.Location = new Point(58, 71);
            chbVentana2.Name = "chbVentana2";
            chbVentana2.Size = new Size(100, 24);
            chbVentana2.TabIndex = 2;
            chbVentana2.Text = "Maximizar";
            chbVentana2.UseVisualStyleBackColor = true;
            chbVentana2.CheckedChanged += chbVentana_Max;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(rdbResolucion2);
            panel2.Controls.Add(rdbResolucion3);
            panel2.Controls.Add(rdbResolucion1);
            panel2.Location = new Point(130, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 163);
            panel2.TabIndex = 3;
            // 
            // rdbResolucion2
            // 
            rdbResolucion2.AutoSize = true;
            rdbResolucion2.Location = new Point(18, 72);
            rdbResolucion2.Name = "rdbResolucion2";
            rdbResolucion2.Size = new Size(93, 24);
            rdbResolucion2.TabIndex = 2;
            rdbResolucion2.TabStop = true;
            rdbResolucion2.Text = "800 x 600";
            rdbResolucion2.UseVisualStyleBackColor = true;
            rdbResolucion2.CheckedChanged += Rdb800x600;
            // 
            // rdbResolucion3
            // 
            rdbResolucion3.AutoSize = true;
            rdbResolucion3.Location = new Point(18, 118);
            rdbResolucion3.Name = "rdbResolucion3";
            rdbResolucion3.Size = new Size(101, 24);
            rdbResolucion3.TabIndex = 1;
            rdbResolucion3.TabStop = true;
            rdbResolucion3.Text = "1024 x 768";
            rdbResolucion3.UseVisualStyleBackColor = true;
            rdbResolucion3.CheckedChanged += Rdb1024x768;
            // 
            // rdbResolucion1
            // 
            rdbResolucion1.AutoSize = true;
            rdbResolucion1.Location = new Point(18, 23);
            rdbResolucion1.Name = "rdbResolucion1";
            rdbResolucion1.Size = new Size(93, 24);
            rdbResolucion1.TabIndex = 0;
            rdbResolucion1.TabStop = true;
            rdbResolucion1.Text = "640 x 480";
            rdbResolucion1.UseVisualStyleBackColor = true;
            rdbResolucion1.CheckedChanged += Rdb640x480;
            // 
            // lblVentana
            // 
            lblVentana.AutoSize = true;
            lblVentana.Location = new Point(400, 105);
            lblVentana.Name = "lblVentana";
            lblVentana.Size = new Size(62, 20);
            lblVentana.TabIndex = 1;
            lblVentana.Text = "Ventana";
            lblVentana.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResolucion);
            Controls.Add(lblVentana);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResolucion;
        private Panel panel1;
        private Panel panel2;
        private Label lblVentana;
        private RadioButton rdbResolucion1;
        private RadioButton rdbResolucion2;
        private RadioButton rdbResolucion3;
        private CheckBox chbVentana2;
    }
}
