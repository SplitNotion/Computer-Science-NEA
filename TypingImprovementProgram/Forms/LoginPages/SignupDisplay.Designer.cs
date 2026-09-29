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
            lblLoginWelcome = new Label();
            SuspendLayout();
            // 
            // lblLoginWelcome
            // 
            lblLoginWelcome.AutoSize = true;
            lblLoginWelcome.BackColor = SystemColors.Window;
            lblLoginWelcome.Font = new Font("Segoe UI", 32.2F);
            lblLoginWelcome.ForeColor = Color.Purple;
            lblLoginWelcome.Location = new Point(33, 31);
            lblLoginWelcome.Name = "lblLoginWelcome";
            lblLoginWelcome.Size = new Size(174, 59);
            lblLoginWelcome.TabIndex = 9;
            lblLoginWelcome.Text = "Sign Up";
            // 
            // SignupDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblLoginWelcome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignupDisplay";
            Size = new Size(628, 622);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginWelcome;
    }
}
