namespace TypingImprovementProgram.Forms.SetupPages
{
    partial class IntroductionPage
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
            btnIntroductionAccept = new Button();
            lblIntroductionText = new Label();
            SuspendLayout();
            // 
            // btnIntroductionAccept
            // 
            btnIntroductionAccept.Location = new Point(654, 467);
            btnIntroductionAccept.Name = "btnIntroductionAccept";
            btnIntroductionAccept.Size = new Size(389, 116);
            btnIntroductionAccept.TabIndex = 0;
            btnIntroductionAccept.Text = "Accept";
            btnIntroductionAccept.UseVisualStyleBackColor = true;
            btnIntroductionAccept.Click += btnIntroductionAccept_Click;
            // 
            // lblIntroductionText
            // 
            lblIntroductionText.AutoSize = true;
            lblIntroductionText.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntroductionText.Location = new Point(489, 387);
            lblIntroductionText.Name = "lblIntroductionText";
            lblIntroductionText.Size = new Size(752, 54);
            lblIntroductionText.TabIndex = 1;
            lblIntroductionText.Text = "This is a placeholder. Please press accept.";
            // 
            // IntroductionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            Controls.Add(lblIntroductionText);
            Controls.Add(btnIntroductionAccept);
            Name = "IntroductionPage";
            Size = new Size(1750, 1160);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIntroductionAccept;
        private Label lblIntroductionText;
    }
}
