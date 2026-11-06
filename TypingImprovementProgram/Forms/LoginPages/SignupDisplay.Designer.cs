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
            components = new System.ComponentModel.Container();
            lblSignUpWelcome = new Label();
            lblLoginUsername = new Label();
            textBoxSignUpUsername = new TextBox();
            lblLoginPassword = new Label();
            textboxSignUpPassword = new TextBox();
            label1 = new Label();
            btnCreateUserAccount = new Button();
            btnReturn = new Button();
            textBoxReenterPassword = new TextBox();
            toolTip1 = new ToolTip(components);
            checkboxViewPassword = new CheckBox();
            checkboxViewReenterPassword = new CheckBox();
            SuspendLayout();
            // 
            // lblSignUpWelcome
            // 
            lblSignUpWelcome.AutoSize = true;
            lblSignUpWelcome.BackColor = SystemColors.Window;
            lblSignUpWelcome.Font = new Font("Segoe UI", 32.2F);
            lblSignUpWelcome.ForeColor = Color.Purple;
            lblSignUpWelcome.Location = new Point(62, 66);
            lblSignUpWelcome.Margin = new Padding(5, 0, 5, 0);
            lblSignUpWelcome.Name = "lblSignUpWelcome";
            lblSignUpWelcome.Size = new Size(349, 114);
            lblSignUpWelcome.TabIndex = 9;
            lblSignUpWelcome.Text = "Sign Up";
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.BackColor = Color.Transparent;
            lblLoginUsername.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginUsername.ForeColor = SystemColors.ButtonShadow;
            lblLoginUsername.Location = new Point(62, 355);
            lblLoginUsername.Margin = new Padding(5, 0, 5, 0);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(245, 55);
            lblLoginUsername.TabIndex = 11;
            lblLoginUsername.Text = "Username:";
            // 
            // textBoxSignUpUsername
            // 
            textBoxSignUpUsername.BackColor = Color.Gainsboro;
            textBoxSignUpUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxSignUpUsername.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSignUpUsername.Location = new Point(62, 424);
            textBoxSignUpUsername.Margin = new Padding(5);
            textBoxSignUpUsername.Name = "textBoxSignUpUsername";
            textBoxSignUpUsername.Size = new Size(1047, 78);
            textBoxSignUpUsername.TabIndex = 10;
            toolTip1.SetToolTip(textBoxSignUpUsername, "Username must:\r\n• Be at least 5 characters long\r\n• Not contain spaces");
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.BackColor = Color.Transparent;
            lblLoginPassword.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold);
            lblLoginPassword.ForeColor = SystemColors.ButtonShadow;
            lblLoginPassword.Location = new Point(62, 555);
            lblLoginPassword.Margin = new Padding(5, 0, 5, 0);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(224, 54);
            lblLoginPassword.TabIndex = 13;
            lblLoginPassword.Text = "Password:";
            // 
            // textboxSignUpPassword
            // 
            textboxSignUpPassword.BackColor = Color.Gainsboro;
            textboxSignUpPassword.BorderStyle = BorderStyle.FixedSingle;
            textboxSignUpPassword.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxSignUpPassword.Location = new Point(62, 626);
            textboxSignUpPassword.Margin = new Padding(5);
            textboxSignUpPassword.Name = "textboxSignUpPassword";
            textboxSignUpPassword.Size = new Size(1047, 78);
            textboxSignUpPassword.TabIndex = 12;
            toolTip1.SetToolTip(textboxSignUpPassword, "Password must:\r\n• Be at least 5 characters long\r\n• Contain at least one uppercase character\r\n• Contain at least one special character");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(62, 758);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(414, 54);
            label1.TabIndex = 15;
            label1.Text = "Re-enter Password:";
            // 
            // btnCreateUserAccount
            // 
            btnCreateUserAccount.BackColor = Color.WhiteSmoke;
            btnCreateUserAccount.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateUserAccount.Location = new Point(304, 1062);
            btnCreateUserAccount.Margin = new Padding(5, 6, 5, 6);
            btnCreateUserAccount.Name = "btnCreateUserAccount";
            btnCreateUserAccount.Size = new Size(499, 128);
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
            btnReturn.Location = new Point(62, 954);
            btnReturn.Margin = new Padding(5, 6, 5, 6);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(353, 64);
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
            textBoxReenterPassword.Location = new Point(62, 835);
            textBoxReenterPassword.Margin = new Padding(5);
            textBoxReenterPassword.Name = "textBoxReenterPassword";
            textBoxReenterPassword.Size = new Size(1047, 78);
            textBoxReenterPassword.TabIndex = 16;
            toolTip1.SetToolTip(textBoxReenterPassword, "Password must:\r\n• Be at least 5 characters long\r\n• Contain at least one uppercase character\r\n• Contain at least one special character");
            // 
            // checkboxViewPassword
            // 
            checkboxViewPassword.AutoSize = true;
            checkboxViewPassword.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkboxViewPassword.ForeColor = SystemColors.ButtonShadow;
            checkboxViewPassword.Location = new Point(804, 560);
            checkboxViewPassword.Name = "checkboxViewPassword";
            checkboxViewPassword.Size = new Size(305, 50);
            checkboxViewPassword.TabIndex = 19;
            checkboxViewPassword.Text = "View Password";
            checkboxViewPassword.UseVisualStyleBackColor = true;
            checkboxViewPassword.CheckedChanged += checkboxViewPassword_CheckedChanged;
            // 
            // checkboxViewReenterPassword
            // 
            checkboxViewReenterPassword.AutoSize = true;
            checkboxViewReenterPassword.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkboxViewReenterPassword.ForeColor = SystemColors.ButtonShadow;
            checkboxViewReenterPassword.Location = new Point(804, 770);
            checkboxViewReenterPassword.Name = "checkboxViewReenterPassword";
            checkboxViewReenterPassword.Size = new Size(305, 50);
            checkboxViewReenterPassword.TabIndex = 20;
            checkboxViewReenterPassword.Text = "View Password";
            checkboxViewReenterPassword.UseVisualStyleBackColor = true;
            checkboxViewReenterPassword.CheckedChanged += checkboxViewReenterPassword_CheckedChanged;
            // 
            // SignupDisplay
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(checkboxViewReenterPassword);
            Controls.Add(checkboxViewPassword);
            Controls.Add(textBoxReenterPassword);
            Controls.Add(btnReturn);
            Controls.Add(btnCreateUserAccount);
            Controls.Add(label1);
            Controls.Add(lblLoginPassword);
            Controls.Add(textboxSignUpPassword);
            Controls.Add(lblLoginUsername);
            Controls.Add(textBoxSignUpUsername);
            Controls.Add(lblSignUpWelcome);
            Margin = new Padding(5);
            Name = "SignupDisplay";
            Size = new Size(1167, 1326);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSignUpWelcome;
        private Label lblLoginUsername;
        private TextBox textBoxSignUpUsername;
        private Label lblLoginPassword;
        private TextBox textboxSignUpPassword;
        private Label label1;
        private Button btnCreateUserAccount;
        private Button btnReturn;
        private TextBox textBoxReenterPassword;
        private ToolTip toolTip1;
        private CheckBox checkboxViewPassword;
        private CheckBox checkboxViewReenterPassword;
    }
}
