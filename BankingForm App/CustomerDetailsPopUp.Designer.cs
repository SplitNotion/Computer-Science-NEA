namespace BankingForm_App
{
    partial class CustomerDetailsPopUp
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
            welcomeMessagelbl = new Label();
            customerIDlbl = new Label();
            customerFirstNameText = new TextBox();
            firstNamelbl = new Label();
            lastNamelbl = new Label();
            customerLastNameText = new TextBox();
            CustomerDetailsPopUpSaveBtn = new Button();
            SuspendLayout();
            // 
            // welcomeMessagelbl
            // 
            welcomeMessagelbl.AutoSize = true;
            welcomeMessagelbl.Location = new Point(14, 39);
            welcomeMessagelbl.Name = "welcomeMessagelbl";
            welcomeMessagelbl.Size = new Size(358, 20);
            welcomeMessagelbl.TabIndex = 0;
            welcomeMessagelbl.Text = "Welcome <name>. You can update your details here.";
            // 
            // customerIDlbl
            // 
            customerIDlbl.AutoSize = true;
            customerIDlbl.Location = new Point(57, 86);
            customerIDlbl.Name = "customerIDlbl";
            customerIDlbl.Size = new Size(226, 20);
            customerIDlbl.TabIndex = 1;
            customerIDlbl.Text = "Customer ID:         <customerID>";
            // 
            // customerFirstNameText
            // 
            customerFirstNameText.Location = new Point(164, 121);
            customerFirstNameText.Name = "customerFirstNameText";
            customerFirstNameText.Size = new Size(220, 27);
            customerFirstNameText.TabIndex = 2;
            // 
            // firstNamelbl
            // 
            firstNamelbl.AutoSize = true;
            firstNamelbl.Location = new Point(61, 124);
            firstNamelbl.Name = "firstNamelbl";
            firstNamelbl.Size = new Size(83, 20);
            firstNamelbl.TabIndex = 3;
            firstNamelbl.Text = "First Name:";
            // 
            // lastNamelbl
            // 
            lastNamelbl.AutoSize = true;
            lastNamelbl.Location = new Point(61, 164);
            lastNamelbl.Name = "lastNamelbl";
            lastNamelbl.Size = new Size(82, 20);
            lastNamelbl.TabIndex = 5;
            lastNamelbl.Text = "Last Name:";
            // 
            // customerLastNameText
            // 
            customerLastNameText.Location = new Point(164, 161);
            customerLastNameText.Name = "customerLastNameText";
            customerLastNameText.Size = new Size(220, 27);
            customerLastNameText.TabIndex = 4;
            // 
            // CustomerDetailsPopUpSaveBtn
            // 
            CustomerDetailsPopUpSaveBtn.Location = new Point(241, 207);
            CustomerDetailsPopUpSaveBtn.Name = "CustomerDetailsPopUpSaveBtn";
            CustomerDetailsPopUpSaveBtn.Size = new Size(143, 26);
            CustomerDetailsPopUpSaveBtn.TabIndex = 6;
            CustomerDetailsPopUpSaveBtn.Text = "Save and Close";
            CustomerDetailsPopUpSaveBtn.UseVisualStyleBackColor = true;
            CustomerDetailsPopUpSaveBtn.Click += CustomerDetailsPopUpSaveBtn_Click;
            // 
            // CustomerDetailsPopUp
            // 
            AcceptButton = CustomerDetailsPopUpSaveBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 400);
            Controls.Add(CustomerDetailsPopUpSaveBtn);
            Controls.Add(lastNamelbl);
            Controls.Add(customerLastNameText);
            Controls.Add(firstNamelbl);
            Controls.Add(customerFirstNameText);
            Controls.Add(customerIDlbl);
            Controls.Add(welcomeMessagelbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerDetailsPopUp";
            Text = "CustomerDetailsPopUp";
            Load += CustomerDetailsPopUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeMessagelbl;
        private Label customerIDlbl;
        private TextBox customerFirstNameText;
        private Label firstNamelbl;
        private Label lastNamelbl;
        private TextBox customerLastNameText;
        private Button CustomerDetailsPopUpSaveBtn;
    }
}