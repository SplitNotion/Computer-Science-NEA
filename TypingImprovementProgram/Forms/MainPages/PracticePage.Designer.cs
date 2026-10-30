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
            btnDifficultyEasy = new Button();
            btnDifficultyMedium = new Button();
            btnDifficultyHard = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDifficultyMixed = new Button();
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnTimedNone = new Button();
            btnTimed15Sec = new Button();
            btnTimed30Sec = new Button();
            btnTimed1Min = new Button();
            label3 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btnLengthRandom = new Button();
            btnLength30Words = new Button();
            btnLength40Words = new Button();
            btnLengthCustom = new Button();
            txtBoxCustomLength = new TextBox();
            lblCustomLength = new Label();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
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
            btnGeneratePracticeTest.Click += btnGeneratePracticeTest_Click;
            // 
            // btnDifficultyEasy
            // 
            btnDifficultyEasy.BackColor = SystemColors.ControlLightLight;
            btnDifficultyEasy.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDifficultyEasy.Location = new Point(3, 122);
            btnDifficultyEasy.Name = "btnDifficultyEasy";
            btnDifficultyEasy.Size = new Size(239, 113);
            btnDifficultyEasy.TabIndex = 3;
            btnDifficultyEasy.Text = "Easy";
            btnDifficultyEasy.UseVisualStyleBackColor = false;
            btnDifficultyEasy.Click += btnDifficultyEasy_Click;
            // 
            // btnDifficultyMedium
            // 
            btnDifficultyMedium.BackColor = SystemColors.ControlLightLight;
            btnDifficultyMedium.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDifficultyMedium.Location = new Point(3, 241);
            btnDifficultyMedium.Name = "btnDifficultyMedium";
            btnDifficultyMedium.Size = new Size(239, 113);
            btnDifficultyMedium.TabIndex = 4;
            btnDifficultyMedium.Text = "Medium";
            btnDifficultyMedium.UseVisualStyleBackColor = false;
            btnDifficultyMedium.Click += btnDifficultyMedium_Click;
            // 
            // btnDifficultyHard
            // 
            btnDifficultyHard.BackColor = SystemColors.ControlLightLight;
            btnDifficultyHard.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDifficultyHard.Location = new Point(3, 360);
            btnDifficultyHard.Name = "btnDifficultyHard";
            btnDifficultyHard.Size = new Size(239, 113);
            btnDifficultyHard.TabIndex = 5;
            btnDifficultyHard.Text = "Hard";
            btnDifficultyHard.UseVisualStyleBackColor = false;
            btnDifficultyHard.Click += btnDifficultyHard_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnDifficultyMixed);
            flowLayoutPanel1.Controls.Add(btnDifficultyEasy);
            flowLayoutPanel1.Controls.Add(btnDifficultyMedium);
            flowLayoutPanel1.Controls.Add(btnDifficultyHard);
            flowLayoutPanel1.Location = new Point(37, 197);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(249, 475);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnDifficultyMixed
            // 
            btnDifficultyMixed.BackColor = SystemColors.ControlLightLight;
            btnDifficultyMixed.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDifficultyMixed.Location = new Point(3, 3);
            btnDifficultyMixed.Name = "btnDifficultyMixed";
            btnDifficultyMixed.Size = new Size(239, 113);
            btnDifficultyMixed.TabIndex = 7;
            btnDifficultyMixed.Text = "Mixed";
            btnDifficultyMixed.UseVisualStyleBackColor = false;
            btnDifficultyMixed.Click += btnDifficultyMixed_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 133);
            label1.Name = "label1";
            label1.Size = new Size(261, 54);
            label1.TabIndex = 7;
            label1.Text = "Test Difficulty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(436, 133);
            label2.Name = "label2";
            label2.Size = new Size(151, 54);
            label2.TabIndex = 9;
            label2.Text = "Timed?";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnTimedNone);
            flowLayoutPanel2.Controls.Add(btnTimed15Sec);
            flowLayoutPanel2.Controls.Add(btnTimed30Sec);
            flowLayoutPanel2.Controls.Add(btnTimed1Min);
            flowLayoutPanel2.Location = new Point(380, 197);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(249, 475);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // btnTimedNone
            // 
            btnTimedNone.BackColor = SystemColors.ControlLightLight;
            btnTimedNone.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimedNone.Location = new Point(3, 3);
            btnTimedNone.Name = "btnTimedNone";
            btnTimedNone.Size = new Size(239, 113);
            btnTimedNone.TabIndex = 7;
            btnTimedNone.Text = "None";
            btnTimedNone.UseVisualStyleBackColor = false;
            btnTimedNone.Click += btnTimedNone_Click;
            // 
            // btnTimed15Sec
            // 
            btnTimed15Sec.BackColor = SystemColors.ControlLightLight;
            btnTimed15Sec.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimed15Sec.Location = new Point(3, 122);
            btnTimed15Sec.Name = "btnTimed15Sec";
            btnTimed15Sec.Size = new Size(239, 113);
            btnTimed15Sec.TabIndex = 3;
            btnTimed15Sec.Text = "15 seconds";
            btnTimed15Sec.UseVisualStyleBackColor = false;
            btnTimed15Sec.Click += btnTimed15Sec_Click;
            // 
            // btnTimed30Sec
            // 
            btnTimed30Sec.BackColor = SystemColors.ControlLightLight;
            btnTimed30Sec.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimed30Sec.Location = new Point(3, 241);
            btnTimed30Sec.Name = "btnTimed30Sec";
            btnTimed30Sec.Size = new Size(239, 113);
            btnTimed30Sec.TabIndex = 4;
            btnTimed30Sec.Text = "30 seconds";
            btnTimed30Sec.UseVisualStyleBackColor = false;
            btnTimed30Sec.Click += btnTimed30Sec_Click;
            // 
            // btnTimed1Min
            // 
            btnTimed1Min.BackColor = SystemColors.ControlLightLight;
            btnTimed1Min.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimed1Min.Location = new Point(3, 360);
            btnTimed1Min.Name = "btnTimed1Min";
            btnTimed1Min.Size = new Size(239, 113);
            btnTimed1Min.TabIndex = 5;
            btnTimed1Min.Text = "1 minute";
            btnTimed1Min.UseVisualStyleBackColor = false;
            btnTimed1Min.Click += btnTimed1Min_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(741, 133);
            label3.Name = "label3";
            label3.Size = new Size(227, 54);
            label3.TabIndex = 11;
            label3.Text = "Test Length";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(btnLengthRandom);
            flowLayoutPanel3.Controls.Add(btnLength30Words);
            flowLayoutPanel3.Controls.Add(btnLength40Words);
            flowLayoutPanel3.Controls.Add(btnLengthCustom);
            flowLayoutPanel3.Location = new Point(726, 200);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(249, 475);
            flowLayoutPanel3.TabIndex = 10;
            // 
            // btnLengthRandom
            // 
            btnLengthRandom.BackColor = SystemColors.ControlLightLight;
            btnLengthRandom.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLengthRandom.Location = new Point(3, 3);
            btnLengthRandom.Name = "btnLengthRandom";
            btnLengthRandom.Size = new Size(239, 113);
            btnLengthRandom.TabIndex = 7;
            btnLengthRandom.Text = "Random";
            btnLengthRandom.UseVisualStyleBackColor = false;
            btnLengthRandom.Click += btnLengthRandom_Click;
            // 
            // btnLength30Words
            // 
            btnLength30Words.BackColor = SystemColors.ControlLightLight;
            btnLength30Words.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLength30Words.Location = new Point(3, 122);
            btnLength30Words.Name = "btnLength30Words";
            btnLength30Words.Size = new Size(239, 113);
            btnLength30Words.TabIndex = 3;
            btnLength30Words.Text = "30 words";
            btnLength30Words.UseVisualStyleBackColor = false;
            btnLength30Words.Click += btnLength30Words_Click;
            // 
            // btnLength40Words
            // 
            btnLength40Words.BackColor = SystemColors.ControlLightLight;
            btnLength40Words.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLength40Words.Location = new Point(3, 241);
            btnLength40Words.Name = "btnLength40Words";
            btnLength40Words.Size = new Size(239, 113);
            btnLength40Words.TabIndex = 4;
            btnLength40Words.Text = "40 words";
            btnLength40Words.UseVisualStyleBackColor = false;
            btnLength40Words.Click += btnLength40Words_Click;
            // 
            // btnLengthCustom
            // 
            btnLengthCustom.BackColor = SystemColors.ControlLightLight;
            btnLengthCustom.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLengthCustom.Location = new Point(3, 360);
            btnLengthCustom.Name = "btnLengthCustom";
            btnLengthCustom.Size = new Size(239, 113);
            btnLengthCustom.TabIndex = 5;
            btnLengthCustom.Text = "Custom";
            btnLengthCustom.UseVisualStyleBackColor = false;
            btnLengthCustom.Click += btnLengthCustom_Click;
            // 
            // txtBoxCustomLength
            // 
            txtBoxCustomLength.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxCustomLength.Location = new Point(974, 605);
            txtBoxCustomLength.Name = "txtBoxCustomLength";
            txtBoxCustomLength.Size = new Size(33, 38);
            txtBoxCustomLength.TabIndex = 12;
            // 
            // lblCustomLength
            // 
            lblCustomLength.AutoSize = true;
            lblCustomLength.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomLength.Location = new Point(1013, 608);
            lblCustomLength.Name = "lblCustomLength";
            lblCustomLength.Size = new Size(82, 31);
            lblCustomLength.TabIndex = 13;
            lblCustomLength.Text = "Words";
            // 
            // PracticePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCustomLength);
            Controls.Add(txtBoxCustomLength);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnGeneratePracticeTest);
            Name = "PracticePage";
            Size = new Size(1512, 1113);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeneratePracticeTest;
        private Button btnDifficultyEasy;
        private Button btnDifficultyMedium;
        private Button btnDifficultyHard;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDifficultyMixed;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnTimedNone;
        private Button btnTimed15Sec;
        private Button btnTimed30Sec;
        private Button btnTimed1Min;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button btnLengthRandom;
        private Button btnLength30Words;
        private Button btnLength40Words;
        private Button btnLengthCustom;
        private TextBox txtBoxCustomLength;
        private Label lblCustomLength;
    }
}
