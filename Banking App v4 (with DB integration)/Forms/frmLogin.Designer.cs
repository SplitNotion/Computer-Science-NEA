namespace BankingApp
{
    partial class frmLogin
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
            lblInformation = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // lblInformation
            // 
            lblInformation.AutoSize = true;
            lblInformation.Location = new Point(21, 19);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new Size(70, 15);
            lblInformation.TabIndex = 0;
            lblInformation.Text = "Information";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(21, 72);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(109, 69);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(234, 23);
            txtUsername.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(214, 160);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(109, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 23);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(21, 111);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 322);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblInformation);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInformation;
        private Label lblUsername;
        private TextBox txtUsername;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblPassword;
    }
}