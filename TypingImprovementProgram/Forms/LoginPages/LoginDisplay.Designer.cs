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
            SuspendLayout();
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.BackColor = Color.Transparent;
            lblLoginPassword.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold);
            lblLoginPassword.ForeColor = SystemColors.ButtonShadow;
            lblLoginPassword.Location = new Point(33, 334);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(106, 27);
            lblLoginPassword.TabIndex = 7;
            lblLoginPassword.Text = "Password";
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.BackColor = Color.Gainsboro;
            textBoxLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxLoginPassword.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLoginPassword.Location = new Point(33, 367);
            textBoxLoginPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.Size = new Size(565, 43);
            textBoxLoginPassword.TabIndex = 6;
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.BackColor = Color.Transparent;
            lblLoginUsername.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginUsername.ForeColor = SystemColors.ButtonShadow;
            lblLoginUsername.Location = new Point(33, 216);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(115, 27);
            lblLoginUsername.TabIndex = 5;
            lblLoginUsername.Text = "Username";
            // 
            // textBoxLoginUsername
            // 
            textBoxLoginUsername.BackColor = Color.Gainsboro;
            textBoxLoginUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxLoginUsername.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLoginUsername.Location = new Point(33, 248);
            textBoxLoginUsername.Margin = new Padding(3, 2, 3, 2);
            textBoxLoginUsername.Name = "textBoxLoginUsername";
            textBoxLoginUsername.Size = new Size(565, 43);
            textBoxLoginUsername.TabIndex = 4;
            // 
            // lblLoginWelcome
            // 
            lblLoginWelcome.AutoSize = true;
            lblLoginWelcome.BackColor = SystemColors.Window;
            lblLoginWelcome.Font = new Font("Segoe UI", 32.2F);
            lblLoginWelcome.ForeColor = Color.Purple;
            lblLoginWelcome.Location = new Point(33, 31);
            lblLoginWelcome.Name = "lblLoginWelcome";
            lblLoginWelcome.Size = new Size(240, 59);
            lblLoginWelcome.TabIndex = 8;
            lblLoginWelcome.Text = "Get Started";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.WhiteSmoke;
            btnCreateAccount.BackgroundImageLayout = ImageLayout.None;
            btnCreateAccount.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccount.Location = new Point(33, 424);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(190, 30);
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
            btnSignIn.Location = new Point(164, 498);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(269, 60);
            btnSignIn.TabIndex = 10;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // LoginDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnSignIn);
            Controls.Add(btnCreateAccount);
            Controls.Add(lblLoginWelcome);
            Controls.Add(lblLoginPassword);
            Controls.Add(textBoxLoginPassword);
            Controls.Add(lblLoginUsername);
            Controls.Add(textBoxLoginUsername);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginDisplay";
            Size = new Size(628, 622);
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
    }
}
