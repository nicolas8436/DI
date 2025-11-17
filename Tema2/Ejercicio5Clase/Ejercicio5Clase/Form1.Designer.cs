namespace Ejercicio5Clase
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
            components = new System.ComponentModel.Container();
            menuOpc = new MenuStrip();
            MenuOpcArchivo = new ToolStripMenuItem();
            MenuOpcArchivoSalir = new ToolStripMenuItem();
            MenuOpcHerramientas = new ToolStripMenuItem();
            MenuOpcHerramientasSuma = new ToolStripMenuItem();
            MenuOpcHerramientasResta = new ToolStripMenuItem();
            MenuOpcHerramientasMultiplicacion = new ToolStripMenuItem();
            MenuOpcHerramientasDivision = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            TxtBNum1 = new TextBox();
            ContextMenuNum1 = new ContextMenuStrip(components);
            CMBorrar = new ToolStripMenuItem();
            iniciar0ToolStripMenuItem = new ToolStripMenuItem();
            randomToolStripMenuItem = new ToolStripMenuItem();
            TxtBNum2 = new TextBox();
            TxtBResul = new TextBox();
            btnResultado = new Button();
            menuOpc.SuspendLayout();
            ContextMenuNum1.SuspendLayout();
            SuspendLayout();
            // 
            // menuOpc
            // 
            menuOpc.ImageScalingSize = new Size(20, 20);
            menuOpc.Items.AddRange(new ToolStripItem[] { MenuOpcArchivo, MenuOpcHerramientas, ayudaToolStripMenuItem });
            menuOpc.Location = new Point(0, 0);
            menuOpc.Name = "menuOpc";
            menuOpc.Size = new Size(800, 28);
            menuOpc.TabIndex = 0;
            menuOpc.Text = "menuOpc";
            // 
            // MenuOpcArchivo
            // 
            MenuOpcArchivo.DropDownItems.AddRange(new ToolStripItem[] { MenuOpcArchivoSalir });
            MenuOpcArchivo.Name = "MenuOpcArchivo";
            MenuOpcArchivo.Size = new Size(73, 24);
            MenuOpcArchivo.Text = "Archivo";
            // 
            // MenuOpcArchivoSalir
            // 
            MenuOpcArchivoSalir.Name = "MenuOpcArchivoSalir";
            MenuOpcArchivoSalir.ShortcutKeys = Keys.Control | Keys.Alt | Keys.S;
            MenuOpcArchivoSalir.Size = new Size(224, 26);
            MenuOpcArchivoSalir.Text = "Salir";
            MenuOpcArchivoSalir.Click += salir_click;
            // 
            // MenuOpcHerramientas
            // 
            MenuOpcHerramientas.DropDownItems.AddRange(new ToolStripItem[] { MenuOpcHerramientasSuma, MenuOpcHerramientasResta, MenuOpcHerramientasMultiplicacion, MenuOpcHerramientasDivision });
            MenuOpcHerramientas.Name = "MenuOpcHerramientas";
            MenuOpcHerramientas.Size = new Size(112, 24);
            MenuOpcHerramientas.Text = "Herramientas";
            // 
            // MenuOpcHerramientasSuma
            // 
            MenuOpcHerramientasSuma.Name = "MenuOpcHerramientasSuma";
            MenuOpcHerramientasSuma.Size = new Size(186, 26);
            MenuOpcHerramientasSuma.Text = "Suma";
            MenuOpcHerramientasSuma.Click += OpcSuma_Click;
            // 
            // MenuOpcHerramientasResta
            // 
            MenuOpcHerramientasResta.Name = "MenuOpcHerramientasResta";
            MenuOpcHerramientasResta.Size = new Size(186, 26);
            MenuOpcHerramientasResta.Text = "Resta";
            MenuOpcHerramientasResta.Click += OpcResta_Click;
            // 
            // MenuOpcHerramientasMultiplicacion
            // 
            MenuOpcHerramientasMultiplicacion.Name = "MenuOpcHerramientasMultiplicacion";
            MenuOpcHerramientasMultiplicacion.Size = new Size(186, 26);
            MenuOpcHerramientasMultiplicacion.Text = "Multiplicacion";
            MenuOpcHerramientasMultiplicacion.Click += OpcMultiplicacion_Click;
            // 
            // MenuOpcHerramientasDivision
            // 
            MenuOpcHerramientasDivision.Name = "MenuOpcHerramientasDivision";
            MenuOpcHerramientasDivision.Size = new Size(186, 26);
            MenuOpcHerramientasDivision.Text = "Division";
            MenuOpcHerramientasDivision.Click += OpcDivision_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.Click += menuOpcAyuda_click;
            // 
            // TxtBNum1
            // 
            TxtBNum1.ContextMenuStrip = ContextMenuNum1;
            TxtBNum1.Location = new Point(42, 57);
            TxtBNum1.Name = "TxtBNum1";
            TxtBNum1.Size = new Size(125, 27);
            TxtBNum1.TabIndex = 1;
            TxtBNum1.TextChanged += TxtBNum1_TextChanged;
            // 
            // ContextMenuNum1
            // 
            ContextMenuNum1.ImageScalingSize = new Size(20, 20);
            ContextMenuNum1.Items.AddRange(new ToolStripItem[] { CMBorrar, iniciar0ToolStripMenuItem, randomToolStripMenuItem });
            ContextMenuNum1.Name = "ContextMenuNum1";
            ContextMenuNum1.Size = new Size(137, 76);
            // 
            // CMBorrar
            // 
            CMBorrar.Name = "CMBorrar";
            CMBorrar.Size = new Size(136, 24);
            CMBorrar.Text = "Borrar";
            // 
            // iniciar0ToolStripMenuItem
            // 
            iniciar0ToolStripMenuItem.Name = "iniciar0ToolStripMenuItem";
            iniciar0ToolStripMenuItem.Size = new Size(136, 24);
            iniciar0ToolStripMenuItem.Text = "Iniciar(0)";
            // 
            // randomToolStripMenuItem
            // 
            randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            randomToolStripMenuItem.Size = new Size(136, 24);
            randomToolStripMenuItem.Text = "Random";
            // 
            // TxtBNum2
            // 
            TxtBNum2.ContextMenuStrip = ContextMenuNum1;
            TxtBNum2.Location = new Point(42, 111);
            TxtBNum2.Name = "TxtBNum2";
            TxtBNum2.Size = new Size(125, 27);
            TxtBNum2.TabIndex = 2;
            // 
            // TxtBResul
            // 
            TxtBResul.Location = new Point(42, 165);
            TxtBResul.Name = "TxtBResul";
            TxtBResul.Size = new Size(125, 27);
            TxtBResul.TabIndex = 3;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(193, 84);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(59, 29);
            btnResultado.TabIndex = 4;
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnResultado);
            Controls.Add(TxtBResul);
            Controls.Add(TxtBNum2);
            Controls.Add(TxtBNum1);
            Controls.Add(menuOpc);
            MainMenuStrip = menuOpc;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuOpc.ResumeLayout(false);
            menuOpc.PerformLayout();
            ContextMenuNum1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuOpc;
        private ToolStripMenuItem MenuOpcArchivo;
        private ToolStripMenuItem MenuOpcHerramientas;
        private ToolStripMenuItem MenuOpcArchivoSalir;
        private ToolStripMenuItem MenuOpcHerramientasSuma;
        private ToolStripMenuItem MenuOpcHerramientasResta;
        private ToolStripMenuItem MenuOpcHerramientasMultiplicacion;
        private ToolStripMenuItem MenuOpcHerramientasDivision;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private TextBox TxtBNum1;
        private TextBox TxtBNum2;
        private TextBox TxtBResul;
        private Button btnResultado;
        private ContextMenuStrip ContextMenuNum1;
        private ToolStripMenuItem CMBorrar;
        private ToolStripMenuItem iniciar0ToolStripMenuItem;
        private ToolStripMenuItem randomToolStripMenuItem;
    }
}
