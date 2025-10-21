namespace Ejercicio1Clase
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
            btn1 = new Button();
            btnM = new Button();
            btnNoM = new Button();
            txtContenido = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.AccessibleDescription = "btnCuadorDialogo_click";
            btn1.AccessibleName = "btnCuadorDialogo_click";
            btn1.Location = new Point(12, 12);
            btn1.Name = "btn1";
            btn1.Size = new Size(141, 29);
            btn1.TabIndex = 0;
            btn1.Text = "Texto_Modal";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnCuadorDialogo_click;
            // 
            // btnM
            // 
            btnM.AccessibleDescription = "btnModal";
            btnM.AccessibleName = "btnModal";
            btnM.Location = new Point(12, 47);
            btnM.Name = "btnM";
            btnM.Size = new Size(141, 29);
            btnM.TabIndex = 1;
            btnM.Text = "Form Modal";
            btnM.UseVisualStyleBackColor = true;
            btnM.Click += btnModal_click;
            // 
            // btnNoM
            // 
            btnNoM.Location = new Point(12, 82);
            btnNoM.Name = "btnNoM";
            btnNoM.Size = new Size(141, 29);
            btnNoM.TabIndex = 2;
            btnNoM.Text = "Form No Modal";
            btnNoM.UseVisualStyleBackColor = true;
            btnNoM.Click += btn_noModal;
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(159, 84);
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(170, 27);
            txtContenido.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 91);
            label1.Name = "label1";
            label1.Size = new Size(9, 20);
            label1.TabIndex = 4;
            label1.Text = "\r\n";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtContenido);
            Controls.Add(btnNoM);
            Controls.Add(btnM);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btnM;
        private Button btnNoM;
        private TextBox txtContenido;
        private Label label1;
    }
}
