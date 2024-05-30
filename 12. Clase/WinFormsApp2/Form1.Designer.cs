namespace WinFormsApp2
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
            dgvClienteProducto = new DataGridView();
            button1 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvClienteProducto).BeginInit();
            SuspendLayout();
            // 
            // dgvClienteProducto
            // 
            dgvClienteProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClienteProducto.Location = new Point(12, 72);
            dgvClienteProducto.Name = "dgvClienteProducto";
            dgvClienteProducto.RowTemplate.Height = 25;
            dgvClienteProducto.Size = new Size(576, 282);
            dgvClienteProducto.TabIndex = 0;
            dgvClienteProducto.CellContentClick += dgvCliente_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(480, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Clientes", "Productos" });
            comboBox1.Location = new Point(12, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 372);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dgvClienteProducto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClienteProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClienteProducto;
        private Button button1;
        private ComboBox comboBox1;
    }
}
