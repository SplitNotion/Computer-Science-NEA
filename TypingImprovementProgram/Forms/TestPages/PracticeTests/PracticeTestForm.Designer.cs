namespace TypingImprovementProgram.Forms.SetupPages
{
    partial class PracticeTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticeTestForm));
            panelScreen = new Panel();
            practiceTestPage1 = new PracticeTestPage();
            panelScreen.SuspendLayout();
            SuspendLayout();
            // 
            // panelScreen
            // 
            panelScreen.Controls.Add(practiceTestPage1);
            panelScreen.Dock = DockStyle.Fill;
            panelScreen.Location = new Point(0, 0);
            panelScreen.Name = "panelScreen";
            panelScreen.Size = new Size(1732, 1113);
            panelScreen.TabIndex = 0;
            panelScreen.Paint += panel1_Paint;
            // 
            // practiceTestPage1
            // 
            practiceTestPage1.BackColor = SystemColors.ControlDarkDark;
            practiceTestPage1.Dock = DockStyle.Fill;
            practiceTestPage1.incorrectCounter = 0;
            practiceTestPage1.Location = new Point(0, 0);
            practiceTestPage1.Name = "practiceTestPage1";
            practiceTestPage1.Size = new Size(1732, 1113);
            practiceTestPage1.TabIndex = 0;
            practiceTestPage1.totalCharacterAttempts = 0;
            practiceTestPage1.totalCharacters = 174;
            practiceTestPage1.totalWords = 23;
            practiceTestPage1.typedWords = 0;
            // 
            // PracticeTestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1732, 1113);
            Controls.Add(panelScreen);
            MaximizeBox = false;
            MinimumSize = new Size(1700, 1100);
            Name = "PracticeTestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaselineTestForm";
            FormClosing += BaselineTestForm_FormClosing;
            panelScreen.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelScreen;
        private PracticeTestPage practiceTestPage1;
    }
}