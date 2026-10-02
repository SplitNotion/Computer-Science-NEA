namespace TypingImprovementProgram.Forms.LoginPages
{
    partial class SignupDisplay
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
            lblSignUpWelcome = new Label();
            lblLoginUsername = new Label();
            textBoxSignUpUsername = new TextBox();
            lblLoginPassword = new Label();
            textBoxLoginPassword = new TextBox();
            label1 = new Label();
            btnCreateUserAccount = new Button();
            btnReturn = new Button();
            textBoxReenterPassword = new TextBox();
            SuspendLayout();
            // 
            // lblSignUpWelcome
            // 
            lblSignUpWelcome.AutoSize = true;
            lblSignUpWelcome.BackColor = SystemColors.Window;
            lblSignUpWelcome.Font = new Font("Segoe UI", 32.2F);
            lblSignUpWelcome.ForeColor = Color.Purple;
            lblSignUpWelcome.Location = new Point(38, 41);
            lblSignUpWelcome.Name = "lblSignUpWelcome";
            lblSignUpWelcome.Size = new Size(219, 72);
            lblSignUpWelcome.TabIndex = 9;
            lblSignUpWelcome.Text = "Sign Up";
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.BackColor = Color.Transparent;
            lblLoginUsername.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginUsername.ForeColor = SystemColors.ButtonShadow;
            lblLoginUsername.Location = new Point(38, 222);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(156, 36);
            lblLoginUsername.TabIndex = 11;
            lblLoginUsername.Text = "Username:";
            // 
            // textBoxSignUpUsername
            // 
            textBoxSignUpUsername.BackColor = Color.Gainsboro;
            textBoxSignUpUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxSignUpUsername.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSignUpUsername.Location = new Point(38, 265);
            textBoxSignUpUsername.Name = "textBoxSignUpUsername";
            textBoxSignUpUsername.Size = new Size(645, 51);
            textBoxSignUpUsername.TabIndex = 10;
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.BackColor = Color.Transparent;
            lblLoginPassword.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold);
            lblLoginPassword.ForeColor = SystemColors.ButtonShadow;
            lblLoginPassword.Location = new Point(38, 347);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(142, 35);
            lblLoginPassword.TabIndex = 13;
            lblLoginPassword.Text = "Password:";
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.BackColor = Color.Gainsboro;
            textBoxLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxLoginPassword.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLoginPassword.Location = new Point(38, 391);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.Size = new Size(645, 51);
            textBoxLoginPassword.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(38, 474);
            label1.Name = "label1";
            label1.Size = new Size(264, 35);
            label1.TabIndex = 15;
            label1.Text = "Re-enter Password:";
            // 
            // btnCreateUserAccount
            // 
            btnCreateUserAccount.BackColor = Color.WhiteSmoke;
            btnCreateUserAccount.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateUserAccount.Location = new Point(187, 664);
            btnCreateUserAccount.Margin = new Padding(3, 4, 3, 4);
            btnCreateUserAccount.Name = "btnCreateUserAccount";
            btnCreateUserAccount.Size = new Size(307, 80);
            btnCreateUserAccount.TabIndex = 18;
            btnCreateUserAccount.Text = "Create Account";
            btnCreateUserAccount.UseVisualStyleBackColor = false;
            btnCreateUserAccount.Click += btnCreateUserAccount_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.WhiteSmoke;
            btnReturn.BackgroundImageLayout = ImageLayout.None;
            btnReturn.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(38, 596);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(217, 40);
            btnReturn.TabIndex = 17;
            btnReturn.TabStop = false;
            btnReturn.Text = "← Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // textBoxReenterPassword
            // 
            textBoxReenterPassword.BackColor = Color.Gainsboro;
            textBoxReenterPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxReenterPassword.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxReenterPassword.Location = new Point(38, 522);
            textBoxReenterPassword.Name = "textBoxReenterPassword";
            textBoxReenterPassword.Size = new Size(645, 51);
            textBoxReenterPassword.TabIndex = 16;
            // 
            // SignupDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(textBoxReenterPassword);
            Controls.Add(btnReturn);
            Controls.Add(btnCreateUserAccount);
            Controls.Add(label1);
            Controls.Add(lblLoginPassword);
            Controls.Add(textBoxLoginPassword);
            Controls.Add(lblLoginUsername);
            Controls.Add(textBoxSignUpUsername);
            Controls.Add(lblSignUpWelcome);
            Name = "SignupDisplay";
            Size = new Size(718, 829);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSignUpWelcome;
        private Label lblLoginUsername;
        private TextBox textBoxSignUpUsername;
        private Label lblLoginPassword;
        private TextBox textBoxLoginPassword;
        private Label label1;
        private Button btnCreateUserAccount;
        private Button btnReturn;
        private TextBox textBoxReenterPassword;
    }
}
