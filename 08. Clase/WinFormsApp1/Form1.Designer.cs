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
            dgMayores = new DataGridView();
            btnBorrar = new Button();
            btnOrdenar = new Button();
            btnLimpiar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgMayores).BeginInit();
            SuspendLayout();
            // 
            // dgMayores
            // 
            dgMayores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMayores.Location = new Point(37, 92);
            dgMayores.Name = "dgMayores";
            dgMayores.RowTemplate.Height = 25;
            dgMayores.Size = new Size(881, 423);
            dgMayores.TabIndex = 0;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(298, 30);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(114, 31);
            btnBorrar.TabIndex = 1;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(450, 30);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(109, 31);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(605, 30);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 31);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(150, 30);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(118, 30);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 549);
            Controls.Add(btnModificar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnBorrar);
            Controls.Add(dgMayores);
            Name = "Form1";
            Text = "Hola Coders!";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgMayores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgMayores;
        private Button btnBorrar;
        private Button btnOrdenar;
        private Button btnLimpiar;
        private Button btnModificar;
    }
}
