namespace TypingImprovementProgram.Forms.MainPages
{
    partial class SettingsPage
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
            lblWelcomeUser = new Label();
            lblUserID = new Label();
            lblUsername = new Label();
            SuspendLayout();
            // 
            // lblWelcomeUser
            // 
            lblWelcomeUser.AutoSize = true;
            lblWelcomeUser.BackColor = SystemColors.ControlDark;
            lblWelcomeUser.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeUser.ForeColor = Color.White;
            lblWelcomeUser.Location = new Point(3, 110);
            lblWelcomeUser.Name = "lblWelcomeUser";
            lblWelcomeUser.Size = new Size(932, 59);
            lblWelcomeUser.TabIndex = 2;
            lblWelcomeUser.Text = "Here is a variety of user settings options:";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.BackColor = SystemColors.ControlDark;
            lblUserID.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.White;
            lblUserID.Location = new Point(596, 240);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(339, 38);
            lblUserID.TabIndex = 3;
            lblUserID.Text = "Your UserID = <userID>";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.ControlDark;
            lblUsername.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(547, 278);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(443, 38);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Your Username = <UserName>";
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(lblUsername);
            Controls.Add(lblUserID);
            Controls.Add(lblWelcomeUser);
            Name = "SettingsPage";
            Size = new Size(1512, 1113);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeUser;
        private Label lblUserID;
        private Label lblUsername;
    }
}
