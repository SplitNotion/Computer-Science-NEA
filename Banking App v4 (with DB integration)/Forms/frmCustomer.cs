using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BankingApp.Classes;

namespace BankingApp
{
    public partial class frmCustomer : Form
    {
        private BankAccount account;

        public frmCustomer(ref Customer customer)
        {
            InitializeComponent();

            this.account = customer.CurrentAccount;
            lblCustomerId.Text = account.Owner.CustomerId.ToString();
            txtName.Text = account.Owner.FirstName;
            txtSurname.Text = account.Owner.Surname;
            lblAbout.Text = "Hello " + account.Owner.FirstName + ". You can update your details here.";
        }

        // Update the account owner's name
        private void btnSave_Click(object sender, EventArgs e)
        {
            account.Owner.FirstName = txtName.Text;
            account.Owner.Surname = txtSurname.Text;
            this.Close();
        }
    }
}
