
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
            btnDeposit.Location = new Point(876, 278);
            btnDeposit.Margin = new Padding(4, 5, 4, 5);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(143, 38);
            btnDeposit.TabIndex = 0;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(876, 345);
            btnWithdraw.Margin = new Padding(4, 5, 4, 5);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(143, 38);
            btnWithdraw.TabIndex = 1;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // lstTransactions
            // 
            lstTransactions.FormattingEnabled = true;
            lstTransactions.ItemHeight = 25;
            lstTransactions.Location = new Point(34, 125);
            lstTransactions.Margin = new Padding(4, 5, 4, 5);
            lstTransactions.Name = "lstTransactions";
            lstTransactions.Size = new Size(660, 479);
            lstTransactions.TabIndex = 2;
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Location = new Point(34, 40);
            lblTransactions.Margin = new Padding(4, 0, 4, 0);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(108, 25);
            lblTransactions.TabIndex = 3;
            lblTransactions.Text = "Transactions";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(670, 635);
            lblBalance.Margin = new Padding(4, 0, 4, 0);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(22, 25);
            lblBalance.TabIndex = 4;
            lblBalance.Text = "0";
            // 
            // lblBalanceLabel
            // 
            lblBalanceLabel.AutoSize = true;
            lblBalanceLabel.Location = new Point(551, 635);
            lblBalanceLabel.Margin = new Padding(4, 0, 4, 0);
            lblBalanceLabel.Name = "lblBalanceLabel";
            lblBalanceLabel.Size = new Size(75, 25);
            lblBalanceLabel.TabIndex = 5;
            lblBalanceLabel.Text = "Balance:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(876, 80);
            txtAmount.Margin = new Padding(4, 5, 4, 5);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(285, 31);
            txtAmount.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(876, 175);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(285, 31);
            txtDescription.TabIndex = 7;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(726, 85);
            lblAmount.Margin = new Padding(4, 0, 4, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(81, 25);
            lblAmount.TabIndex = 8;
            lblAmount.Text = "Amount:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(726, 180);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(106, 25);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description:";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(726, 417);
            lblError.Margin = new Padding(4, 0, 4, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 25);
            lblError.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 11;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 85);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 12;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 85);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 13;
            label4.Text = "Balance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 85);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 14;
            label5.Text = "Description";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, customerDetailsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1214, 35);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(78, 29);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // customerDetailsToolStripMenuItem
            // 
            customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            customerDetailsToolStripMenuItem.Size = new Size(163, 29);
            customerDetailsToolStripMenuItem.Text = "Customer Details";
            customerDetailsToolStripMenuItem.Click += customerDetailsToolStripMenuItem_Click;
            // 
            // frmTransactions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 750);
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
            Margin = new Padding(4, 5, 4, 5);
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