namespace RepasoExamen
{
    partial class Form3
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
            button2 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(479, 244);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 19;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(177, 228);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 27);
            textBox4.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(177, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 27);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 27);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 27);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 231);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 13;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 177);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 12;
            label3.Text = "Seg¡undo Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 115);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 11;
            label2.Text = "Primer Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 62);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 10;
            label1.Text = "Nombre";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 283);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}