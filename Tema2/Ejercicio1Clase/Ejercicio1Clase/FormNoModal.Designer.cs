namespace Ejercicio1Clase
{
    partial class FormNoModal
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
            lbl = new Label();
            txtalgo = new TextBox();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.Chartreuse;
            lbl.Location = new Point(124, 179);
            lbl.Name = "lbl";
            lbl.Size = new Size(494, 62);
            lbl.TabIndex = 1;
            lbl.Text = "Este form no es modal";
            // 
            // txtalgo
            // 
            txtalgo.Location = new Point(303, 255);
            txtalgo.Name = "txtalgo";
            txtalgo.Size = new Size(125, 27);
            txtalgo.TabIndex = 2;
            // 
            // FormNoModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtalgo);
            Controls.Add(lbl);
            Name = "FormNoModal";
            Text = "FormNoModal";
            FormClosing += FormNoModal_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private TextBox txtalgo;
    }
}