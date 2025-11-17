namespace Ejercicio6Clase
{
    partial class FormDoc
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
            richTxtFolio = new RichTextBox();
            SuspendLayout();
            // 
            // richTxtFolio
            // 
            richTxtFolio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTxtFolio.Location = new Point(1, 0);
            richTxtFolio.Name = "richTxtFolio";
            richTxtFolio.Size = new Size(797, 450);
            richTxtFolio.TabIndex = 0;
            richTxtFolio.Text = "";
            richTxtFolio.TextChanged += richTxtFolio_TextChanged;
            // 
            // FormDoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTxtFolio);
            Name = "FormDoc";
            Text = "FormDoc";
            Load += FormDoc_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTxtFolio;
    }
}