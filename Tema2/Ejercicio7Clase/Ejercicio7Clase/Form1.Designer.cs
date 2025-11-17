namespace Ejercicio7Clase
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            chkVisible = new CheckBox();
            tbUsuario = new TextBox();
            tbContraseña = new TextBox();
            tbServidor = new TextBox();
            tbPuerto = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            Ayuda = new ContextMenuStrip(components);
            BtnAñadirF = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 70);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 99);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 188);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Servidor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 222);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "Puerto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(296, 30);
            label5.Name = "label5";
            label5.Size = new Size(177, 20);
            label5.TabIndex = 4;
            label5.Text = "Selecciona base de datos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(541, 30);
            label6.Name = "label6";
            label6.Size = new Size(180, 20);
            label6.TabIndex = 5;
            label6.Text = "Selecciona tabla de datos";
            // 
            // chkVisible
            // 
            chkVisible.AutoSize = true;
            chkVisible.Location = new Point(88, 142);
            chkVisible.Name = "chkVisible";
            chkVisible.Size = new Size(158, 24);
            chkVisible.TabIndex = 6;
            chkVisible.Text = "Mostrar contraseña";
            chkVisible.UseVisualStyleBackColor = true;
            chkVisible.Click += chkVisible_click;
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(115, 63);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(125, 27);
            tbUsuario.TabIndex = 7;
            // 
            // tbContraseña
            // 
            tbContraseña.Location = new Point(115, 96);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.Size = new Size(125, 27);
            tbContraseña.TabIndex = 8;
            tbContraseña.Click += chkVisible_click;
            // 
            // tbServidor
            // 
            tbServidor.Location = new Point(115, 185);
            tbServidor.Name = "tbServidor";
            tbServidor.Size = new Size(125, 27);
            tbServidor.TabIndex = 9;
            tbServidor.Text = "127.0.0.1";
            // 
            // tbPuerto
            // 
            tbPuerto.Location = new Point(115, 219);
            tbPuerto.Name = "tbPuerto";
            tbPuerto.Size = new Size(125, 27);
            tbPuerto.TabIndex = 10;
            tbPuerto.Text = "33060";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(283, 63);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(203, 124);
            listBox1.TabIndex = 11;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(532, 63);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(196, 124);
            listBox2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(904, 231);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(788, 90);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnConectar_Click;
            // 
            // Ayuda
            // 
            Ayuda.ImageScalingSize = new Size(20, 20);
            Ayuda.Name = "Ayuda";
            Ayuda.Size = new Size(61, 4);
            Ayuda.Text = "Ayuda";
            // 
            // BtnAñadirF
            // 
            BtnAñadirF.Location = new Point(788, 142);
            BtnAñadirF.Name = "BtnAñadirF";
            BtnAñadirF.Size = new Size(94, 29);
            BtnAñadirF.TabIndex = 15;
            BtnAñadirF.Text = "Añadir Fila";
            BtnAñadirF.UseVisualStyleBackColor = true;
            BtnAñadirF.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 502);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(904, 223);
            dataGridView2.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 757);
            Controls.Add(dataGridView2);
            Controls.Add(BtnAñadirF);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(tbPuerto);
            Controls.Add(tbServidor);
            Controls.Add(tbContraseña);
            Controls.Add(tbUsuario);
            Controls.Add(chkVisible);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox chkVisible;
        private TextBox tbUsuario;
        private TextBox tbContraseña;
        private TextBox tbServidor;
        private TextBox tbPuerto;
        private ListBox listBox1;
        private ListBox listBox2;
        private DataGridView dataGridView1;
        private Button button1;
        private ContextMenuStrip Ayuda;
        private Button BtnAñadirF;
        private DataGridView dataGridView2;
    }
}
