namespace TypingImprovementProgram.Forms.LoginPages
{
    partial class LoginDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLoginPassword = new Label();
            textBoxLoginPassword = new TextBox();
            lblLoginUsername = new Label();
            textBoxLoginUsername = new TextBox();
            lblLoginWelcome = new Label();
            btnCreateAccount = new Button();
            btnSignIn = new Button();
            checkboxViewPassword = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.BackColor = Color.Transparent;
            lblLoginPassword.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold);
            lblLoginPassword.ForeColor = SystemColors.ButtonShadow;
            lblLoginPassword.Location = new Point(62, 712);
            lblLoginPassword.Margin = new Padding(5, 0, 5, 0);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(208, 54);
            lblLoginPassword.TabIndex = 7;
            lblLoginPassword.Text = "Password";
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.BackColor = Color.Gainsboro;
            textBoxLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxLoginPassword.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLoginPassword.Location = new Point(62, 782);
            textBoxLoginPassword.Margin = new Padding(5);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.Size = new Size(1047, 78);
            textBoxLoginPassword.TabIndex = 6;
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.BackColor = Color.Transparent;
            lblLoginUsername.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginUsername.ForeColor = SystemColors.ButtonShadow;
            lblLoginUsername.Location = new Point(62, 461);
            lblLoginUsername.Margin = new Padding(5, 0, 5, 0);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(229, 55);
            lblLoginUsername.TabIndex = 5;
            lblLoginUsername.Text = "Username";
            // 
            // textBoxLoginUsername
            // 
            textBoxLoginUsername.BackColor = Color.Gainsboro;
            textBoxLoginUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxLoginUsername.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLoginUsername.Location = new Point(62, 530);
            textBoxLoginUsername.Margin = new Padding(5);
            textBoxLoginUsername.Name = "textBoxLoginUsername";
            textBoxLoginUsername.Size = new Size(1047, 78);
            textBoxLoginUsername.TabIndex = 4;
            // 
            // lblLoginWelcome
            // 
            lblLoginWelcome.AutoSize = true;
            lblLoginWelcome.BackColor = SystemColors.Window;
            lblLoginWelcome.Font = new Font("Segoe UI", 32.2F);
            lblLoginWelcome.ForeColor = Color.Purple;
            lblLoginWelcome.Location = new Point(62, 66);
            lblLoginWelcome.Margin = new Padding(5, 0, 5, 0);
            lblLoginWelcome.Name = "lblLoginWelcome";
            lblLoginWelcome.Size = new Size(476, 114);
            lblLoginWelcome.TabIndex = 8;
            lblLoginWelcome.Text = "Get Started";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.WhiteSmoke;
            btnCreateAccount.BackgroundImageLayout = ImageLayout.None;
            btnCreateAccount.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccount.Location = new Point(62, 904);
            btnCreateAccount.Margin = new Padding(5, 6, 5, 6);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(353, 64);
            btnCreateAccount.TabIndex = 9;
            btnCreateAccount.TabStop = false;
            btnCreateAccount.Text = "New? Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.WhiteSmoke;
            btnSignIn.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.Location = new Point(304, 1062);
            btnSignIn.Margin = new Padding(5, 6, 5, 6);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(499, 128);
            btnSignIn.TabIndex = 10;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // checkboxViewPassword
            // 
            checkboxViewPassword.AutoSize = true;
            checkboxViewPassword.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkboxViewPassword.ForeColor = SystemColors.ButtonShadow;
            checkboxViewPassword.Location = new Point(804, 717);
            checkboxViewPassword.Name = "checkboxViewPassword";
            checkboxViewPassword.Size = new Size(305, 50);
            checkboxViewPassword.TabIndex = 20;
            checkboxViewPassword.Text = "View Password";
            checkboxViewPassword.UseVisualStyleBackColor = true;
            checkboxViewPassword.CheckedChanged += checkboxViewPassword_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(78, 192);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(632, 50);
            label1.TabIndex = 21;
            label1.Text = "Enter credentials to continue to tests.";
            // 
            // LoginDisplay
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label1);
            Controls.Add(checkboxViewPassword);
            Controls.Add(btnSignIn);
            Controls.Add(btnCreateAccount);
            Controls.Add(lblLoginWelcome);
            Controls.Add(lblLoginPassword);
            Controls.Add(textBoxLoginPassword);
            Controls.Add(lblLoginUsername);
            Controls.Add(textBoxLoginUsername);
            Margin = new Padding(5);
            Name = "LoginDisplay";
            Size = new Size(1167, 1326);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginPassword;
        private TextBox textBoxLoginPassword;
        private Label lblLoginUsername;
        private TextBox textBoxLoginUsername;
        private Label lblLoginWelcome;
        private Button btnCreateAccount;
        private Button btnSignIn;
        private CheckBox checkboxViewPassword;
        private Label label1;
    }
}
