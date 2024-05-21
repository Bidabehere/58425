namespace WinFormsApp1
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
            button1 = new Button();
            label1 = new Label();
            dgvLista = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(591, 39);
            button1.Name = "button1";
            button1.Size = new Size(123, 40);
            button1.TabIndex = 0;
            button1.Text = "Agrgar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(87, 24);
            label1.Name = "label1";
            label1.Size = new Size(199, 50);
            label1.TabIndex = 1;
            label1.Text = "Productos";
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(30, 102);
            dgvLista.Name = "dgvLista";
            dgvLista.RowTemplate.Height = 25;
            dgvLista.Size = new Size(730, 313);
            dgvLista.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvLista);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dgvLista;
    }
}
