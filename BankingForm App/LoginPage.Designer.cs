namespace BankingForm_App
{
    partial class LoginPage
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
            lblUsername = new Label();
            lblPassword = new Label();
            txtboxUsername = new TextBox();
            txtboxPassword = new TextBox();
            pictureBox1 = new PictureBox();
            labelincorrectWarning = new Label();
            buttonLogin = new Button();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(30, 73);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(182, 37);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(30, 131);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(176, 37);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // txtboxUsername
            // 
            txtboxUsername.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxUsername.Location = new Point(223, 73);
            txtboxUsername.Margin = new Padding(3, 2, 3, 2);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(352, 41);
            txtboxUsername.TabIndex = 2;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Font = new Font("Microsoft Sans Serif", 18F);
            txtboxPassword.Location = new Point(223, 131);
            txtboxPassword.Margin = new Padding(3, 2, 3, 2);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(352, 35);
            txtboxPassword.TabIndex = 3;
            txtboxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_12_28_173117;
            pictureBox1.Location = new Point(612, 73);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 338);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelincorrectWarning
            // 
            labelincorrectWarning.AutoSize = true;
            labelincorrectWarning.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            labelincorrectWarning.ForeColor = Color.Red;
            labelincorrectWarning.Location = new Point(12, 204);
            labelincorrectWarning.Name = "labelincorrectWarning";
            labelincorrectWarning.Size = new Size(239, 52);
            labelincorrectWarning.TabIndex = 6;
            labelincorrectWarning.Text = "Username/Password \r\nis incorrect!";
            labelincorrectWarning.TextAlign = ContentAlignment.TopCenter;
            labelincorrectWarning.UseMnemonic = false;
            labelincorrectWarning.Visible = false;
            labelincorrectWarning.Click += label1_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(275, 204);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(249, 52);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHelp.Location = new Point(898, 431);
            buttonHelp.Margin = new Padding(3, 2, 3, 2);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(140, 57);
            buttonHelp.TabIndex = 7;
            buttonHelp.TabStop = false;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // LoginPage
            // 
            AcceptButton = buttonLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 499);
            Controls.Add(buttonHelp);
            Controls.Add(labelincorrectWarning);
            Controls.Add(buttonLogin);
            Controls.Add(pictureBox1);
            Controls.Add(txtboxPassword);
            Controls.Add(txtboxUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginPage";
            Text = "APP LOGIN";
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtboxUsername;
        private TextBox txtboxPassword;
        private PictureBox pictureBox1;
        private Label labelincorrectWarning;
        private Button buttonLogin;
        private Button buttonHelp;
    }
}