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
    public partial class frmAbout : Form
    {
        private BankAccount account;

        public frmAbout(ref Customer customer)
        {
            InitializeComponent();

            this.account = customer.CurrentAccount;
            txtName.Text = account.Owner.FirstName;
            lblAbout.Text = "Hello " + account.Owner.FirstName + ". This is the About page.";
        }

        // Update the account owner's name
        private void btnSave_Click(object sender, EventArgs e)
        {
            account.Owner.FirstName = txtName.Text;
            lblAbout.Text = "Hello " + account.Owner + ". This is the About page.";
            this.Close();
        }
    }
}
