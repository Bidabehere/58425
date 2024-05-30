namespace WinFormsApp2
{
    partial class ClienteForm
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
            Volver1 = new Button();
            Guardar1 = new Button();
            button3 = new Button();
            label1 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtDomicilio = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // Volver1
            // 
            Volver1.Location = new Point(12, 390);
            Volver1.Name = "Volver1";
            Volver1.Size = new Size(75, 23);
            Volver1.TabIndex = 0;
            Volver1.Text = "Volver";
            Volver1.UseVisualStyleBackColor = true;
            Volver1.Click += Volver1_Click;
            // 
            // Guardar1
            // 
            Guardar1.Location = new Point(101, 390);
            Guardar1.Name = "Guardar1";
            Guardar1.Size = new Size(75, 23);
            Guardar1.TabIndex = 1;
            Guardar1.Text = "Guardar";
            Guardar1.UseVisualStyleBackColor = true;
            Guardar1.Click += Guardar1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(189, 390);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 58);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 3;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(116, 55);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 106);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(116, 154);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 157);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Apellido";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(116, 208);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(100, 23);
            txtDomicilio.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 211);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 9;
            label4.Text = "Domicilio";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(116, 264);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 267);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 11;
            label5.Text = "Telefono";
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 450);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtDomicilio);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(Guardar1);
            Controls.Add(Volver1);
            Name = "ClienteForm";
            Text = "ClienteForm";
            Load += ClienteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Volver1;
        private Button Guardar1;
        private Button button3;
        private Label label1;
        private TextBox txtId;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtDomicilio;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
    }
}