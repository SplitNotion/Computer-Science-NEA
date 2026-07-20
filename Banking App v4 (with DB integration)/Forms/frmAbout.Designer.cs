namespace BankingApp
{
    partial class frmAbout
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
            lblAbout = new Label();
            lblName = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.Location = new Point(21, 19);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(70, 15);
            lblAbout.TabIndex = 0;
            lblAbout.Text = "Information";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(21, 72);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(83, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 23);
            txtName.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(214, 123);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save and Close";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 322);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblAbout);
            Name = "frmAbout";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAbout;
        private Label lblName;
        private TextBox txtName;
        private Button btnSave;
    }
}