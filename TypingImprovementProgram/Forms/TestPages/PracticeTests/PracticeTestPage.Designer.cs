namespace TypingImprovementProgram.Forms.SetupPages
{
    partial class PracticeTestPage
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
            lblPracticeTestPage = new Label();
            btnContinuePracticeTest = new Button();
            keyboardPanel = new Panel();
            keyboardVisualiserControl1 = new KeyboardVisualiserControl();
            lbltypedWordProgressCounter = new Label();
            keyboardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblPracticeTestPage
            // 
            lblPracticeTestPage.AutoSize = true;
            lblPracticeTestPage.Font = new Font("Trebuchet MS", 42F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPracticeTestPage.Location = new Point(3, 0);
            lblPracticeTestPage.Name = "lblPracticeTestPage";
            lblPracticeTestPage.Size = new Size(536, 89);
            lblPracticeTestPage.TabIndex = 0;
            lblPracticeTestPage.Text = "PRACTICE TEST";
            // 
            // btnContinuePracticeTest
            // 
            btnContinuePracticeTest.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContinuePracticeTest.Location = new Point(1401, 18);
            btnContinuePracticeTest.Name = "btnContinuePracticeTest";
            btnContinuePracticeTest.Size = new Size(318, 117);
            btnContinuePracticeTest.TabIndex = 1;
            btnContinuePracticeTest.Text = "Continue ➔";
            btnContinuePracticeTest.UseVisualStyleBackColor = true;
            btnContinuePracticeTest.Click += btnContinuePracticeTest_Click;
            // 
            // keyboardPanel
            // 
            keyboardPanel.BackColor = Color.CadetBlue;
            keyboardPanel.Controls.Add(keyboardVisualiserControl1);
            keyboardPanel.Location = new Point(247, 654);
            keyboardPanel.Name = "keyboardPanel";
            keyboardPanel.Size = new Size(1220, 400);
            keyboardPanel.TabIndex = 2;
            // 
            // keyboardVisualiserControl1
            // 
            keyboardVisualiserControl1.Dock = DockStyle.Fill;
            keyboardVisualiserControl1.Font = new Font("Arial", 24F);
            keyboardVisualiserControl1.Location = new Point(0, 0);
            keyboardVisualiserControl1.Name = "keyboardVisualiserControl1";
            keyboardVisualiserControl1.Size = new Size(1220, 400);
            keyboardVisualiserControl1.TabIndex = 0;
            keyboardVisualiserControl1.TabStop = false;
            // 
            // lbltypedWordProgressCounter
            // 
            lbltypedWordProgressCounter.AutoSize = true;
            lbltypedWordProgressCounter.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltypedWordProgressCounter.Location = new Point(41, 254);
            lbltypedWordProgressCounter.Name = "lbltypedWordProgressCounter";
            lbltypedWordProgressCounter.Size = new Size(95, 62);
            lbltypedWordProgressCounter.TabIndex = 3;
            lbltypedWordProgressCounter.Text = "0/0";
            // 
            // PracticeTestPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(lbltypedWordProgressCounter);
            Controls.Add(keyboardPanel);
            Controls.Add(btnContinuePracticeTest);
            Controls.Add(lblPracticeTestPage);
            Name = "PracticeTestPage";
            Size = new Size(1736, 1106);
            keyboardPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPracticeTestPage;
        private Button btnContinuePracticeTest;
        private Panel keyboardPanel;
        private KeyboardVisualiserControl keyboardVisualiserControl1;
        private Label lbltypedWordProgressCounter;
    }
}
