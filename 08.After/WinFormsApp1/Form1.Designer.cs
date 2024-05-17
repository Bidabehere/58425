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
            lstMenu = new ListView();
            SuspendLayout();
            // 
            // lstMenu
            // 
            lstMenu.Location = new Point(25, 36);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(564, 276);
            lstMenu.TabIndex = 0;
            lstMenu.UseCompatibleStateImageBehavior = false;
            lstMenu.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 349);
            Controls.Add(lstMenu);
            Name = "Form1";
            Text = "Menu";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lstMenu;
    }
}
