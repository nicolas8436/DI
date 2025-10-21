namespace Ejercicio1Clase
{
    partial class FormModal
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
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.FromArgb(255, 128, 255);
            lbl.Location = new Point(169, 192);
            lbl.Name = "lbl";
            lbl.Size = new Size(426, 62);
            lbl.TabIndex = 0;
            lbl.Text = "Este form es modal";
            // 
            // FormModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl);
            Name = "FormModal";
            Text = "FormModal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
    }
}