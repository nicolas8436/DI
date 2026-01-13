namespace RepasoExamen
{
    partial class Form2
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
            TxtBNombre = new TextBox();
            TxtBA1 = new TextBox();
            TxtBA2 = new TextBox();
            TxtBTelefono = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 64);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 117);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 1;
            label2.Text = "Primer Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 179);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 2;
            label3.Text = "Seg¡undo Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 233);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // TxtBNombre
            // 
            TxtBNombre.Location = new Point(177, 61);
            TxtBNombre.Name = "TxtBNombre";
            TxtBNombre.Size = new Size(186, 27);
            TxtBNombre.TabIndex = 4;
            // 
            // TxtBA1
            // 
            TxtBA1.Location = new Point(177, 114);
            TxtBA1.Name = "TxtBA1";
            TxtBA1.Size = new Size(186, 27);
            TxtBA1.TabIndex = 5;
            // 
            // TxtBA2
            // 
            TxtBA2.Location = new Point(177, 176);
            TxtBA2.Name = "TxtBA2";
            TxtBA2.Size = new Size(186, 27);
            TxtBA2.TabIndex = 6;
            // 
            // TxtBTelefono
            // 
            TxtBTelefono.Location = new Point(177, 230);
            TxtBTelefono.Name = "TxtBTelefono";
            TxtBTelefono.Size = new Size(186, 27);
            TxtBTelefono.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(518, 80);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Agreger_Click;
            // 
            // button2
            // 
            button2.Location = new Point(518, 198);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Cancelar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 322);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TxtBTelefono);
            Controls.Add(TxtBA2);
            Controls.Add(TxtBA1);
            Controls.Add(TxtBNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtBNombre;
        private TextBox TxtBA1;
        private TextBox TxtBA2;
        private TextBox TxtBTelefono;
        private Button button1;
        private Button button2;
    }
}