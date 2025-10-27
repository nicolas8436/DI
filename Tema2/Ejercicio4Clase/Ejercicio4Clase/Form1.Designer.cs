namespace Ejercicio4Clase
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
            btn2 = new Button();
            txtb = new TextBox();
            pan = new Panel();
            pan.SuspendLayout();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn1.Location = new Point(544, 12);
            btn1.Name = "btn1";
            btn1.Size = new Size(244, 252);
            btn1.TabIndex = 0;
            btn1.Text = "button1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(12, 12);
            btn2.Name = "btn2";
            btn2.Size = new Size(263, 252);
            btn2.TabIndex = 1;
            btn2.Text = "button2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // txtb
            // 
            txtb.Anchor = AnchorStyles.None;
            txtb.Location = new Point(26, 27);
            txtb.Multiline = true;
            txtb.Name = "txtb";
            txtb.Size = new Size(206, 309);
            txtb.TabIndex = 2;
            txtb.TextChanged += textBox1_TextChanged;
            // 
            // pan
            // 
            pan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pan.BackColor = Color.FromArgb(192, 255, 192);
            pan.Controls.Add(txtb);
            pan.Location = new Point(281, 12);
            pan.Name = "pan";
            pan.Size = new Size(257, 358);
            pan.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pan);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            pan.ResumeLayout(false);
            pan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private TextBox txtb;
        private Panel pan;
    }
}
