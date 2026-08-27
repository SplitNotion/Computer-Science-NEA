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
            label1 = new Label();
            btnContinueBaselineTest = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(679, 706);
            label1.Name = "label1";
            label1.Size = new Size(345, 54);
            label1.TabIndex = 0;
            label1.Text = "Baseline Test Page";
            label1.Click += label1_Click;
            // 
            // btnContinueBaselineTest
            // 
            btnContinueBaselineTest.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContinueBaselineTest.Location = new Point(1390, 971);
            btnContinueBaselineTest.Name = "btnContinueBaselineTest";
            btnContinueBaselineTest.Size = new Size(318, 117);
            btnContinueBaselineTest.TabIndex = 1;
            btnContinueBaselineTest.Text = "Next Test ➔";
            btnContinueBaselineTest.UseVisualStyleBackColor = true;
            btnContinueBaselineTest.Click += btnContinueBaselineTest_Click;
            // 
            // BaselineTestPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(btnContinueBaselineTest);
            Controls.Add(label1);
            Name = "BaselineTestPage";
            Size = new Size(1736, 1106);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnContinueBaselineTest;
    }
}
