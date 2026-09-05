namespace TypingImprovementProgram.Forms.SetupPages
{
    partial class BaselineTestPage
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
            lblbaselineTestPage = new Label();
            btnContinueBaselineTest = new Button();
            keyboardPanel = new Panel();
            keyboardVisualiserControl1 = new KeyboardVisualiserControl();
            lbltypedWordProgressCounter = new Label();
            keyboardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblbaselineTestPage
            // 
            lblbaselineTestPage.AutoSize = true;
            lblbaselineTestPage.Font = new Font("Trebuchet MS", 42F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbaselineTestPage.Location = new Point(3, 0);
            lblbaselineTestPage.Name = "lblbaselineTestPage";
            lblbaselineTestPage.Size = new Size(527, 89);
            lblbaselineTestPage.TabIndex = 0;
            lblbaselineTestPage.Text = "BASELINE TEST";
            // 
            // btnContinueBaselineTest
            // 
            btnContinueBaselineTest.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContinueBaselineTest.Location = new Point(1401, 18);
            btnContinueBaselineTest.Name = "btnContinueBaselineTest";
            btnContinueBaselineTest.Size = new Size(318, 117);
            btnContinueBaselineTest.TabIndex = 1;
            btnContinueBaselineTest.Text = "Next Test ➔";
            btnContinueBaselineTest.UseVisualStyleBackColor = true;
            btnContinueBaselineTest.Click += btnContinueBaselineTest_Click;
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
            // BaselineTestPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(lbltypedWordProgressCounter);
            Controls.Add(keyboardPanel);
            Controls.Add(btnContinueBaselineTest);
            Controls.Add(lblbaselineTestPage);
            Name = "BaselineTestPage";
            Size = new Size(1736, 1106);
            keyboardPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblbaselineTestPage;
        private Button btnContinueBaselineTest;
        private Panel keyboardPanel;
        private KeyboardVisualiserControl keyboardVisualiserControl1;
        private Label lbltypedWordProgressCounter;
    }
}
