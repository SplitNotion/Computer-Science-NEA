namespace TypingImprovementProgram.Forms
{
    partial class DashboardPage
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
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            lblWelcomeUser = new Label();
            SuspendLayout();
            // 
            // lblWelcomeUser
            // 
            lblWelcomeUser.AutoSize = true;
            lblWelcomeUser.BackColor = SystemColors.ControlDark;
            lblWelcomeUser.Font = new Font("Trebuchet MS", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeUser.ForeColor = Color.White;
            lblWelcomeUser.Location = new Point(3, 109);
            lblWelcomeUser.Name = "lblWelcomeUser";
            lblWelcomeUser.Size = new Size(606, 84);
            lblWelcomeUser.TabIndex = 1;
            lblWelcomeUser.Text = "Welcome, <user>!";
            // 
            // DashboardPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(lblWelcomeUser);
            Name = "DashboardPage";
            Size = new Size(1512, 1113);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label lblWelcomeUser;
    }
}
