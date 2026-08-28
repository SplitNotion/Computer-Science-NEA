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
            panel1 = new Panel();
            keyboardVisualiserControl1 = new KeyboardVisualiserControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 42F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(527, 89);
            label1.TabIndex = 0;
            label1.Text = "BASELINE TEST";
            label1.Click += label1_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(keyboardVisualiserControl1);
            panel1.Location = new Point(247, 654);
            panel1.Name = "panel1";
            panel1.Size = new Size(1220, 400);
            panel1.TabIndex = 2;
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
            // BaselineTestPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(panel1);
            Controls.Add(btnContinueBaselineTest);
            Controls.Add(label1);
            Name = "BaselineTestPage";
            Size = new Size(1736, 1106);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnContinueBaselineTest;
        private Panel panel1;
        private KeyboardVisualiserControl keyboardVisualiserControl1;
    }
}
