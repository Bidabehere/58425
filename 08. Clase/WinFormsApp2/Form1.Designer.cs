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
            btnLimpiar = new Button();
            label1 = new Label();
            dgProductosConE = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgProductosConE).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(451, 28);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 32);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(110, 28);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 1;
            label1.Text = "Productos con E";
            // 
            // dgProductosConE
            // 
            dgProductosConE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductosConE.Location = new Point(83, 103);
            dgProductosConE.Name = "dgProductosConE";
            dgProductosConE.RowTemplate.Height = 25;
            dgProductosConE.Size = new Size(629, 297);
            dgProductosConE.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgProductosConE);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductosConE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Label label1;
        private DataGridView dgProductosConE;
    }
}
