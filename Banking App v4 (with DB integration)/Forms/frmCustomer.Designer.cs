namespace BankingApp
{
    partial class frmCustomer
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
            lblAbout = new Label();
            lblName = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            txtSurname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblCustomerId = new Label();
            SuspendLayout();
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.Location = new Point(30, 32);
            lblAbout.Margin = new Padding(4, 0, 4, 0);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(69, 25);
            lblAbout.TabIndex = 0;
            lblAbout.Text = "Details:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 151);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(101, 25);
            lblName.TabIndex = 1;
            lblName.Text = "First Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(168, 146);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(321, 31);
            txtName.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(305, 288);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(184, 38);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save and Close";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(168, 211);
            txtSurname.Margin = new Padding(4, 5, 4, 5);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(321, 31);
            txtSurname.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 216);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 4;
            label1.Text = "Surname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 84);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 6;
            label2.Text = "Customer Id:";
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Location = new Point(168, 84);
            lblCustomerId.Margin = new Padding(4, 0, 4, 0);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(174, 25);
            lblCustomerId.TabIndex = 7;
            lblCustomerId.Text = "<ID displayed here>";
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 537);
            Controls.Add(lblCustomerId);
            Controls.Add(label2);
            Controls.Add(txtSurname);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblAbout);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCustomer";
            Text = "Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAbout;
        private Label lblName;
        private TextBox txtName;
        private Button btnSave;
        private TextBox txtSurname;
        private Label label1;
        private Label label2;
        private Label lblCustomerId;
    }
}