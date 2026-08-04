namespace TypingImprovementProgram.Forms.SetupPages
{
    partial class BaselineTestForm
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
            panelScreen = new Panel();
            introductionPage1 = new IntroductionPage();
            panelScreen.SuspendLayout();
            SuspendLayout();
            // 
            // panelScreen
            // 
            panelScreen.Controls.Add(introductionPage1);
            panelScreen.Dock = DockStyle.Fill;
            panelScreen.Location = new Point(0, 0);
            panelScreen.Name = "panelScreen";
            panelScreen.Size = new Size(1298, 673);
            panelScreen.TabIndex = 0;
            panelScreen.Paint += panel1_Paint;
            // 
            // introductionPage1
            // 
            introductionPage1.BackColor = Color.Coral;
            introductionPage1.Location = new Point(-7, 3);
            introductionPage1.Name = "introductionPage1";
            introductionPage1.Size = new Size(1305, 670);
            introductionPage1.TabIndex = 0;
            // 
            // BaselineTestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 673);
            Controls.Add(panelScreen);
            MinimumSize = new Size(1280, 720);
            Name = "BaselineTestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaselineTestForm";
            panelScreen.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelScreen;
        private IntroductionPage introductionPage1;
    }
}