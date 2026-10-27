namespace BankingForm_App
{
    partial class BankingApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelAmount = new Label();
            LabelDescription = new Label();
            LabelTransactions = new Label();
            LabelBalance = new Label();
            AmountText = new TextBox();
            DescriptionText = new TextBox();
            DepositButton = new Button();
            WithdrawButton = new Button();
            labelBalanceText = new Label();
            lblBalanceText = new Label();
            listTransactions = new ListView();
            ResetAccountButton = new Button();
            menuStrip1 = new MenuStrip();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            customerDetailsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LabelAmount
            // 
            LabelAmount.AutoSize = true;
            LabelAmount.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            LabelAmount.Location = new Point(1085, 119);
            LabelAmount.Margin = new Padding(4, 0, 4, 0);
            LabelAmount.Name = "LabelAmount";
            LabelAmount.Size = new Size(154, 39);
            LabelAmount.TabIndex = 0;
            LabelAmount.Text = "Amount:";
            LabelAmount.Click += LabelAmount_Click;
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            LabelDescription.Location = new Point(1059, 215);
            LabelDescription.Margin = new Padding(4, 0, 4, 0);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(214, 39);
            LabelDescription.TabIndex = 1;
            LabelDescription.Text = "Description:";
            LabelDescription.Click += LabelDescription_Click;
            // 
            // LabelTransactions
            // 
            LabelTransactions.AutoSize = true;
            LabelTransactions.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            LabelTransactions.Location = new Point(97, 47);
            LabelTransactions.Margin = new Padding(4, 0, 4, 0);
            LabelTransactions.Name = "LabelTransactions";
            LabelTransactions.Size = new Size(229, 39);
            LabelTransactions.TabIndex = 3;
            LabelTransactions.Text = "Transactions";
            // 
            // LabelBalance
            // 
            LabelBalance.AutoSize = true;
            LabelBalance.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            LabelBalance.Location = new Point(683, 734);
            LabelBalance.Margin = new Padding(4, 0, 4, 0);
            LabelBalance.Name = "LabelBalance";
            LabelBalance.Size = new Size(160, 39);
            LabelBalance.TabIndex = 4;
            LabelBalance.Text = "Balance:";
            LabelBalance.Click += label4_Click;
            // 
            // AmountText
            // 
            AmountText.Location = new Point(1307, 119);
            AmountText.Margin = new Padding(4);
            AmountText.Name = "AmountText";
            AmountText.Size = new Size(528, 39);
            AmountText.TabIndex = 5;
            AmountText.TextChanged += textBox1_TextChanged;
            // 
            // DescriptionText
            // 
            DescriptionText.Location = new Point(1307, 194);
            DescriptionText.Margin = new Padding(4);
            DescriptionText.Multiline = true;
            DescriptionText.Name = "DescriptionText";
            DescriptionText.Size = new Size(528, 85);
            DescriptionText.TabIndex = 6;
            DescriptionText.TextChanged += DescriptionText_TextChanged;
            // 
            // DepositButton
            // 
            DepositButton.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepositButton.Location = new Point(1203, 348);
            DepositButton.Margin = new Padding(4);
            DepositButton.Name = "DepositButton";
            DepositButton.Size = new Size(420, 85);
            DepositButton.TabIndex = 7;
            DepositButton.Text = "Deposit";
            DepositButton.UseVisualStyleBackColor = true;
            DepositButton.Click += DepositButton_Click;
            // 
            // WithdrawButton
            // 
            WithdrawButton.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WithdrawButton.Location = new Point(1203, 457);
            WithdrawButton.Margin = new Padding(4);
            WithdrawButton.Name = "WithdrawButton";
            WithdrawButton.Size = new Size(420, 85);
            WithdrawButton.TabIndex = 8;
            WithdrawButton.Text = "Withdraw";
            WithdrawButton.UseVisualStyleBackColor = true;
            WithdrawButton.Click += WithdrawButton_Click;
            // 
            // labelBalanceText
            // 
            labelBalanceText.AutoSize = true;
            labelBalanceText.Location = new Point(938, 738);
            labelBalanceText.Margin = new Padding(6, 0, 6, 0);
            labelBalanceText.Name = "labelBalanceText";
            labelBalanceText.Size = new Size(0, 32);
            labelBalanceText.TabIndex = 9;
            // 
            // lblBalanceText
            // 
            lblBalanceText.AutoSize = true;
            lblBalanceText.Font = new Font("Microsoft Sans Serif", 13F);
            lblBalanceText.Location = new Point(873, 734);
            lblBalanceText.Margin = new Padding(6, 0, 6, 0);
            lblBalanceText.Name = "lblBalanceText";
            lblBalanceText.Size = new Size(109, 39);
            lblBalanceText.TabIndex = 10;
            lblBalanceText.Text = "label1";
            // 
            // listTransactions
            // 
            listTransactions.FullRowSelect = true;
            listTransactions.GridLines = true;
            listTransactions.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listTransactions.Location = new Point(97, 107);
            listTransactions.Margin = new Padding(6, 4, 6, 4);
            listTransactions.Name = "listTransactions";
            listTransactions.Size = new Size(920, 601);
            listTransactions.TabIndex = 11;
            listTransactions.TabStop = false;
            listTransactions.UseCompatibleStateImageBehavior = false;
            listTransactions.View = View.Details;
            listTransactions.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // ResetAccountButton
            // 
            ResetAccountButton.Font = new Font("Microsoft Sans Serif", 13.13F, FontStyle.Bold);
            ResetAccountButton.Location = new Point(97, 721);
            ResetAccountButton.Margin = new Padding(6, 4, 6, 4);
            ResetAccountButton.Name = "ResetAccountButton";
            ResetAccountButton.Size = new Size(319, 75);
            ResetAccountButton.TabIndex = 12;
            ResetAccountButton.TabStop = false;
            ResetAccountButton.Text = "Reset Account";
            ResetAccountButton.UseVisualStyleBackColor = true;
            ResetAccountButton.Click += ResetAccountButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { signOutToolStripMenuItem, aboutToolStripMenuItem, customerDetailsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1950, 44);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(128, 36);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(99, 36);
            aboutToolStripMenuItem.Text = "About";
            // 
            // customerDetailsToolStripMenuItem
            // 
            customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            customerDetailsToolStripMenuItem.Size = new Size(216, 36);
            customerDetailsToolStripMenuItem.Text = "Customer Details";
            customerDetailsToolStripMenuItem.Click += customerDetailsToolStripMenuItem_Click;
            // 
            // BankingApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1950, 1065);
            Controls.Add(ResetAccountButton);
            Controls.Add(listTransactions);
            Controls.Add(lblBalanceText);
            Controls.Add(labelBalanceText);
            Controls.Add(WithdrawButton);
            Controls.Add(DepositButton);
            Controls.Add(DescriptionText);
            Controls.Add(AmountText);
            Controls.Add(LabelBalance);
            Controls.Add(LabelTransactions);
            Controls.Add(LabelDescription);
            Controls.Add(LabelAmount);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BankingApp";
            Text = "Banking App";
            Load += BankingApp_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelAmount;
        private Label LabelDescription;
        private Label LabelTransactions;
        private Label LabelBalance;
        private TextBox AmountText;
        private TextBox DescriptionText;
        private Button DepositButton;
        private Button WithdrawButton;
        private Label labelBalanceText;
        private Label lblBalanceText;
        private ListView listTransactions;
        private Button ResetAccountButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem customerDetailsToolStripMenuItem;
    }
}
