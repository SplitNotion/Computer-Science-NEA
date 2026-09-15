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
            SuspendLayout();
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.BackColor = Color.Transparent;
            lblLoginPassword.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold);
            lblLoginPassword.ForeColor = SystemColors.ButtonShadow;
            lblLoginPassword.Location = new Point(38, 446);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(132, 35);
            lblLoginPassword.TabIndex = 7;
            lblLoginPassword.Text = "Password";
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.BackColor = Color.Gainsboro;
            textBoxLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxLoginPassword.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLoginPassword.Location = new Point(38, 489);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.Size = new Size(645, 51);
            textBoxLoginPassword.TabIndex = 6;
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.BackColor = Color.Transparent;
            lblLoginUsername.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginUsername.ForeColor = SystemColors.ButtonShadow;
            lblLoginUsername.Location = new Point(38, 288);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(146, 36);
            lblLoginUsername.TabIndex = 5;
            lblLoginUsername.Text = "Username";
            lblLoginUsername.Click += lblLoginUsername_Click;
            // 
            // textBoxLoginUsername
            // 
            textBoxLoginUsername.BackColor = Color.Gainsboro;
            textBoxLoginUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxLoginUsername.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLoginUsername.Location = new Point(38, 331);
            textBoxLoginUsername.Name = "textBoxLoginUsername";
            textBoxLoginUsername.Size = new Size(645, 51);
            textBoxLoginUsername.TabIndex = 4;
            // 
            // lblLoginWelcome
            // 
            lblLoginWelcome.AutoSize = true;
            lblLoginWelcome.BackColor = SystemColors.Window;
            lblLoginWelcome.Font = new Font("Segoe UI", 32.2F);
            lblLoginWelcome.ForeColor = Color.Purple;
            lblLoginWelcome.Location = new Point(38, 41);
            lblLoginWelcome.Name = "lblLoginWelcome";
            lblLoginWelcome.Size = new Size(297, 72);
            lblLoginWelcome.TabIndex = 8;
            lblLoginWelcome.Text = "Get Started";
            // 
            // LoginDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblLoginWelcome);
            Controls.Add(lblLoginPassword);
            Controls.Add(textBoxLoginPassword);
            Controls.Add(lblLoginUsername);
            Controls.Add(textBoxLoginUsername);
            Name = "LoginDisplay";
            Size = new Size(718, 829);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginPassword;
        private TextBox textBoxLoginPassword;
        private Label lblLoginUsername;
        private TextBox textBoxLoginUsername;
        private Label lblLoginWelcome;
    }
}
