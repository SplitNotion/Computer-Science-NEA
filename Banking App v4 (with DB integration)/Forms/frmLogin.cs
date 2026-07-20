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
    public partial class frmLogin : Form
    {
        private CurrentAccount account;

        public frmLogin()
        {
            // TODO:
        }

        // Update the account owner's name
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblInformation.Text = "Hello. Please enter your details.";

            // TODO:

            //frmTransactions transactionsPage = new frmTransactions(ref account);
            //transactionsPage.ShowDialog();
            //this.Close();
        }
    }
}
