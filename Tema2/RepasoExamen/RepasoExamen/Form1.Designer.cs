namespace RepasoExamen
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
            menuStrip1 = new MenuStrip();
            Insertar = new ToolStripMenuItem();
            Eliminar = new ToolStripMenuItem();
            Mostrar = new ToolStripMenuItem();
            cerrarTodoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Insertar, Eliminar, Mostrar, cerrarTodoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Insertar
            // 
            Insertar.Name = "Insertar";
            Insertar.Size = new Size(72, 24);
            Insertar.Text = "Insertar";
            Insertar.Click += BtnInsertar_Click;
            // 
            // Eliminar
            // 
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(77, 24);
            Eliminar.Text = "Eliminar";
            Eliminar.Click += Eliminar_click;
            // 
            // Mostrar
            // 
            Mostrar.Name = "Mostrar";
            Mostrar.Size = new Size(74, 24);
            Mostrar.Text = "Mostrar";
            Mostrar.Click += Mostrar_Click;
            // 
            // cerrarTodoToolStripMenuItem
            // 
            cerrarTodoToolStripMenuItem.Name = "cerrarTodoToolStripMenuItem";
            cerrarTodoToolStripMenuItem.Size = new Size(101, 24);
            cerrarTodoToolStripMenuItem.Text = "Cerrar Todo";
            cerrarTodoToolStripMenuItem.Click += CerrarTodo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Insertar;
        private ToolStripMenuItem Mostrar;
        private ToolStripMenuItem Eliminar;
        private ToolStripMenuItem cerrarTodoToolStripMenuItem;
    }
}
