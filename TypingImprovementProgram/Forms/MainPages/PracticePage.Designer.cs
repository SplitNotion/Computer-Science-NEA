namespace TypingImprovementProgram.Forms.MainPages
{
    partial class PracticePage
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
            btnGeneratePracticeTest = new Button();
            SuspendLayout();
            // 
            // btnGeneratePracticeTest
            // 
            btnGeneratePracticeTest.BackColor = SystemColors.ControlLightLight;
            btnGeneratePracticeTest.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGeneratePracticeTest.Location = new Point(1111, 229);
            btnGeneratePracticeTest.Name = "btnGeneratePracticeTest";
            btnGeneratePracticeTest.Size = new Size(376, 158);
            btnGeneratePracticeTest.TabIndex = 2;
            btnGeneratePracticeTest.Text = "Generate Practice Test ➔";
            btnGeneratePracticeTest.UseVisualStyleBackColor = false;
            btnGeneratePracticeTest.Click += this.btnGeneratePracticeTest_Click;
            // 
            // PracticePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGeneratePracticeTest);
            Name = "PracticePage";
            Size = new Size(1512, 1113);
            ResumeLayout(false);
        }  

        #endregion

        private Button btnGeneratePracticeTest;
    }
}
