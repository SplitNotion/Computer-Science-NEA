using BankingForm_App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingForm_App
{
    public partial class CustomerDetailsPopUp : Form
    {
        private BankAccount account;

        internal CustomerDetailsPopUp(ref BankAccount currentAccount)
        {
            InitializeComponent();
            this.account = currentAccount;
            welcomeMessagelbl.Text = "Welcome " + account.Owner.FirstName + ". You can update your details here.";
            customerIDlbl.Text = "Customer ID:         " + account.Owner.CustomerID;
            this.Text = "Customer Details";
        }
        private void CustomerDetailsPopUp_Load(object sender, EventArgs e)
        {

        }

        private void CustomerDetailsPopUpSaveBtn_Click(object sender, EventArgs e)
        {
            if (customerFirstNameText.Text.Length == 0 ^ customerLastNameText.Text.Length == 0)
            {
                MessageBox.Show("A box hasn't been filled!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!customerFirstNameText.Text.All(char.IsLetter) || !customerLastNameText.Text.All(char.IsLetter))
            {
                MessageBox.Show("Name must contain only letters!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (customerFirstNameText.Text.Length == 0 && customerLastNameText.Text.Length == 0)
            {
                this.Close();
            }

            else
            {
                account.Owner.FirstName = customerFirstNameText.Text;
                account.Owner.LastName = customerLastNameText.Text;
                this.Close();
            }

        }
    }
}
