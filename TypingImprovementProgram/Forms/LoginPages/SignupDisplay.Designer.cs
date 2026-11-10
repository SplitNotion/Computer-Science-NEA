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
            lblConfirmPassword = new Label();
            btnCreateUserAccount = new Button();
            btnReturn = new Button();
            textBoxReenterPassword = new TextBox();
            toolTip1 = new ToolTip(components);
            checkboxViewPassword = new CheckBox();
            checkboxViewReenterPassword = new CheckBox();
            lblCapsLockOnWarning = new Label();
            SuspendLayout();
            // 
            // lblSignUpWelcome
            // 
            lblSignUpWelcome.AutoSize = true;
            lblSignUpWelcome.BackColor = SystemColors.Window;
            lblSignUpWelcome.Font = new Font("Segoe UI", 32.2F);
            lblSignUpWelcome.ForeColor = Color.Purple;
            lblSignUpWelcome.Location = new Point(33, 31);
            lblSignUpWelcome.Name = "lblSignUpWelcome";
            lblSignUpWelcome.Size = new Size(174, 59);
            lblSignUpWelcome.TabIndex = 9;
            lblSignUpWelcome.Text = "Sign Up";
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.BackColor = Color.Transparent;
            lblLoginUsername.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginUsername.ForeColor = SystemColors.ButtonShadow;
            lblLoginUsername.Location = new Point(33, 166);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(123, 27);
            lblLoginUsername.TabIndex = 11;
            lblLoginUsername.Text = "Username:";
            // 
            // textBoxSignUpUsername
            // 
            textBoxSignUpUsername.BackColor = Color.Gainsboro;
            textBoxSignUpUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxSignUpUsername.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSignUpUsername.Location = new Point(33, 199);
            textBoxSignUpUsername.Margin = new Padding(3, 2, 3, 2);
            textBoxSignUpUsername.Name = "textBoxSignUpUsername";
            textBoxSignUpUsername.Size = new Size(565, 43);
            textBoxSignUpUsername.TabIndex = 10;
            toolTip1.SetToolTip(textBoxSignUpUsername, "Username must:\r\n• Be at least 5 characters long\r\n• Not contain spaces");
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.BackColor = Color.Transparent;
            lblLoginPassword.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold);
            lblLoginPassword.ForeColor = SystemColors.ButtonShadow;
            lblLoginPassword.Location = new Point(33, 260);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(114, 27);
            lblLoginPassword.TabIndex = 13;
            lblLoginPassword.Text = "Password:";
            // 
            // textboxSignUpPassword
            // 
            textboxSignUpPassword.BackColor = Color.Gainsboro;
            textboxSignUpPassword.BorderStyle = BorderStyle.FixedSingle;
            textboxSignUpPassword.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxSignUpPassword.Location = new Point(33, 293);
            textboxSignUpPassword.Margin = new Padding(3, 2, 3, 2);
            textboxSignUpPassword.Name = "textboxSignUpPassword";
            textboxSignUpPassword.Size = new Size(565, 43);
            textboxSignUpPassword.TabIndex = 12;
            toolTip1.SetToolTip(textboxSignUpPassword, "Password must:\r\n• Be at least 5 characters long\r\n• Contain at least one uppercase character\r\n• Contain at least one special character");
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = Color.Transparent;
            lblConfirmPassword.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = SystemColors.ButtonShadow;
            lblConfirmPassword.Location = new Point(33, 356);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(202, 27);
            lblConfirmPassword.TabIndex = 15;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // btnCreateUserAccount
            // 
            btnCreateUserAccount.BackColor = Color.WhiteSmoke;
            btnCreateUserAccount.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateUserAccount.Location = new Point(164, 498);
            btnCreateUserAccount.Name = "btnCreateUserAccount";
            btnCreateUserAccount.Size = new Size(269, 60);
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
            btnReturn.Location = new Point(33, 447);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(190, 30);
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
            textBoxReenterPassword.Location = new Point(33, 392);
            textBoxReenterPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxReenterPassword.Name = "textBoxReenterPassword";
            textBoxReenterPassword.Size = new Size(565, 43);
            textBoxReenterPassword.TabIndex = 16;
            toolTip1.SetToolTip(textBoxReenterPassword, "Password must:\r\n• Be at least 5 characters long\r\n• Contain at least one uppercase character\r\n• Contain at least one special character");
            // 
            // checkboxViewPassword
            // 
            checkboxViewPassword.AutoSize = true;
            checkboxViewPassword.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkboxViewPassword.ForeColor = SystemColors.ButtonShadow;
            checkboxViewPassword.Location = new Point(433, 262);
            checkboxViewPassword.Margin = new Padding(2);
            checkboxViewPassword.Name = "checkboxViewPassword";
            checkboxViewPassword.Size = new Size(162, 28);
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
            checkboxViewReenterPassword.Location = new Point(433, 361);
            checkboxViewReenterPassword.Margin = new Padding(2);
            checkboxViewReenterPassword.Name = "checkboxViewReenterPassword";
            checkboxViewReenterPassword.Size = new Size(162, 28);
            checkboxViewReenterPassword.TabIndex = 20;
            checkboxViewReenterPassword.Text = "View Password";
            checkboxViewReenterPassword.UseVisualStyleBackColor = true;
            checkboxViewReenterPassword.CheckedChanged += checkboxViewReenterPassword_CheckedChanged;
            // 
            // lblCapsLockOnWarning
            // 
            lblCapsLockOnWarning.AutoSize = true;
            lblCapsLockOnWarning.BackColor = SystemColors.ControlLightLight;
            lblCapsLockOnWarning.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCapsLockOnWarning.ForeColor = Color.Salmon;
            lblCapsLockOnWarning.Location = new Point(151, 255);
            lblCapsLockOnWarning.Name = "lblCapsLockOnWarning";
            lblCapsLockOnWarning.Size = new Size(215, 32);
            lblCapsLockOnWarning.TabIndex = 21;
            lblCapsLockOnWarning.Text = "CAPS LOCK IS ON!";
            // 
            // SignupDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblCapsLockOnWarning);
            Controls.Add(checkboxViewReenterPassword);
            Controls.Add(checkboxViewPassword);
            Controls.Add(textBoxReenterPassword);
            Controls.Add(btnReturn);
            Controls.Add(btnCreateUserAccount);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblLoginPassword);
            Controls.Add(textboxSignUpPassword);
            Controls.Add(lblLoginUsername);
            Controls.Add(textBoxSignUpUsername);
            Controls.Add(lblSignUpWelcome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignupDisplay";
            Size = new Size(628, 622);
            KeyUp += CapsLockChecker;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSignUpWelcome;
        private Label lblLoginUsername;
        private TextBox textBoxSignUpUsername;
        private Label lblLoginPassword;
        private TextBox textboxSignUpPassword;
        private Label lblConfirmPassword;
        private Button btnCreateUserAccount;
        private Button btnReturn;
        private TextBox textBoxReenterPassword;
        private ToolTip toolTip1;
        private CheckBox checkboxViewPassword;
        private CheckBox checkboxViewReenterPassword;
        private Label lblCapsLockOnWarning;
    }
}
