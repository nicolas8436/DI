namespace Ejercicio3Clase
{
    partial class ListaIngenieros
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
            lbl1 = new Label();
            listBox1 = new ListBox();
            btnEliminar = new Button();
            btnContar = new Button();
            btnNombre = new Button();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(88, 35);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(331, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "Ingeniero Forestal para trabajar en la empresa";
            lbl1.Click += lbl1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(88, 80);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(331, 264);
            listBox1.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(149, 361);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnContar
            // 
            btnContar.Location = new Point(349, 361);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(94, 29);
            btnContar.TabIndex = 5;
            btnContar.Text = "Contar";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // btnNombre
            // 
            btnNombre.Location = new Point(249, 361);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(94, 29);
            btnNombre.TabIndex = 6;
            btnNombre.Text = "Nombre";
            btnNombre.UseVisualStyleBackColor = true;
            btnNombre.Click += btnNombre_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(49, 361);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_click;
            // 
            // ListaIngenieros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 437);
            Controls.Add(btnAgregar);
            Controls.Add(btnNombre);
            Controls.Add(btnContar);
            Controls.Add(btnEliminar);
            Controls.Add(listBox1);
            Controls.Add(lbl1);
            MaximumSize = new Size(517, 484);
            MinimumSize = new Size(517, 484);
            Name = "ListaIngenieros";
            Text = "Lista de Ingenieros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private ListBox listBox1;
        private Button button1;
        private Button btnEliminar;
        private Button btnContar;
        private Button btnNombre;
        private Button btnAgregar;
    }
}
