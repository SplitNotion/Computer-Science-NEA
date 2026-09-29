namespace TypingImprovementProgram.Forms.LoginPages
{
    partial class LoginPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPageForm));
            pictureBox1 = new PictureBox();
            panelLoginPage = new Panel();
            loginDisplay1 = new LoginDisplay();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLoginPage.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1517, 796);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelLoginPage
            // 
            panelLoginPage.Controls.Add(loginDisplay1);
            panelLoginPage.Location = new Point(443, 106);
            panelLoginPage.Margin = new Padding(3, 2, 3, 2);
            panelLoginPage.Name = "panelLoginPage";
            panelLoginPage.Size = new Size(630, 623);
            panelLoginPage.TabIndex = 1;
            // 
            // loginDisplay1
            // 
            loginDisplay1.BackColor = Color.White;
            loginDisplay1.BorderStyle = BorderStyle.FixedSingle;
            loginDisplay1.Dock = DockStyle.Fill;
            loginDisplay1.Location = new Point(0, 0);
            loginDisplay1.Margin = new Padding(3, 2, 3, 2);
            loginDisplay1.Name = "loginDisplay1";
            loginDisplay1.Size = new Size(630, 623);
            loginDisplay1.TabIndex = 0;
            loginDisplay1.Load += loginDisplay1_Load;
            // 
            // LoginPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1517, 796);
            Controls.Add(panelLoginPage);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(1533, 880);
            MinimumSize = new Size(1533, 782);
            Name = "LoginPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPageForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLoginPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelLoginPage;
        private LoginDisplay loginDisplay1;
    }
}