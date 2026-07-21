
namespace BankingApp
{
    partial class frmTransactions
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
            btnDeposit = new Button();
            btnWithdraw = new Button();
            lstTransactions = new ListBox();
            lblTransactions = new Label();
            lblBalance = new Label();
            lblBalanceLabel = new Label();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            lblAmount = new Label();
            lblDescription = new Label();
            lblError = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            customerDetailsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeposit
            // 
            btnDeposit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeposit.Location = new Point(701, 222);
            btnDeposit.Margin = new Padding(3, 4, 3, 4);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(114, 30);
            btnDeposit.TabIndex = 0;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnWithdraw.Location = new Point(701, 276);
            btnWithdraw.Margin = new Padding(3, 4, 3, 4);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(114, 30);
            btnWithdraw.TabIndex = 1;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // lstTransactions
            // 
            lstTransactions.FormattingEnabled = true;
            lstTransactions.Location = new Point(27, 100);
            lstTransactions.Margin = new Padding(3, 4, 3, 4);
            lstTransactions.Name = "lstTransactions";
            lstTransactions.Size = new Size(529, 384);
            lstTransactions.TabIndex = 2;
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Location = new Point(27, 32);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(90, 20);
            lblTransactions.TabIndex = 3;
            lblTransactions.Text = "Transactions";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(536, 508);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(17, 20);
            lblBalance.TabIndex = 4;
            lblBalance.Text = "0";
            // 
            // lblBalanceLabel
            // 
            lblBalanceLabel.AutoSize = true;
            lblBalanceLabel.Location = new Point(441, 508);
            lblBalanceLabel.Name = "lblBalanceLabel";
            lblBalanceLabel.Size = new Size(64, 20);
            lblBalanceLabel.TabIndex = 5;
            lblBalanceLabel.Text = "Balance:";
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAmount.Location = new Point(701, 64);
            txtAmount.Margin = new Padding(3, 4, 3, 4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(229, 27);
            txtAmount.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(701, 140);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(229, 27);
            txtDescription.TabIndex = 7;
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(581, 68);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(65, 20);
            lblAmount.TabIndex = 8;
            lblAmount.Text = "Amount:";
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(581, 144);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description:";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(581, 334);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 68);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 11;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 68);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 12;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 68);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 13;
            label4.Text = "Balance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 68);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 14;
            label5.Text = "Description";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, customerDetailsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(971, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // customerDetailsToolStripMenuItem
            // 
            customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            customerDetailsToolStripMenuItem.Size = new Size(136, 24);
            customerDetailsToolStripMenuItem.Text = "Customer Details";
            customerDetailsToolStripMenuItem.Click += customerDetailsToolStripMenuItem_Click;
            // 
            // frmTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 600);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblError);
            Controls.Add(lblDescription);
            Controls.Add(lblAmount);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(lblBalanceLabel);
            Controls.Add(lblBalance);
            Controls.Add(lblTransactions);
            Controls.Add(lstTransactions);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTransactions";
            RightToLeft = RightToLeft.No;
            Text = "Banking App";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeposit;
        private Button btnWithdraw;
        private ListBox lstTransactions;
        private Label lblTransactions;
        private Label lblBalance;
        private Label lblBalanceLabel;
        private TextBox txtAmount;
        private TextBox txtDescription;
        private Label lblAmount;
        private Label lblDescription;
        private Label lblError;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem customerDetailsToolStripMenuItem;
    }
}