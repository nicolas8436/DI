namespace Ejercicio6Clase
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
            menuOpc = new MenuStrip();
            menuOpcNuevo = new ToolStripMenuItem();
            menuOpcVentana = new ToolStripMenuItem();
            menuOpc.SuspendLayout();
            SuspendLayout();
            // 
            // menuOpc
            // 
            menuOpc.ImageScalingSize = new Size(20, 20);
            menuOpc.Items.AddRange(new ToolStripItem[] { menuOpcNuevo, menuOpcVentana });
            menuOpc.Location = new Point(0, 0);
            menuOpc.Name = "menuOpc";
            menuOpc.Size = new Size(944, 28);
            menuOpc.TabIndex = 1;
            menuOpc.Text = "menuStrip1";
            // 
            // menuOpcNuevo
            // 
            menuOpcNuevo.Name = "menuOpcNuevo";
            menuOpcNuevo.Size = new Size(66, 24);
            menuOpcNuevo.Text = "Nuevo";
            menuOpcNuevo.Click += menuOpcNuevo_Click;
            // 
            // menuOpcVentana
            // 
            menuOpcVentana.Name = "menuOpcVentana";
            menuOpcVentana.Size = new Size(76, 24);
            menuOpcVentana.Text = "Ventana";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 558);
            Controls.Add(menuOpc);
            IsMdiContainer = true;
            MainMenuStrip = menuOpc;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuOpc.ResumeLayout(false);
            menuOpc.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuOpc;
        private ToolStripMenuItem menuOpcNuevo;
        private ToolStripMenuItem menuOpcVentana;
    }
}
