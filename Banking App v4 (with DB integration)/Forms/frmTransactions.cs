using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingApp.Classes;

namespace BankingApp
{
    // Inherits from the Form class
    public partial class frmTransactions : Form
    {
        // Private member - allows the form to access all the properties of the customer
        private Customer customer;

        public frmTransactions()
        {
            InitializeComponent();

            // Set an event that gets triggered when the form is activated - i.e. when the 'About' form closes.
            this.Activated += new EventHandler(frmTransactions_Activated);

            // Get the customer
            decimal balance = 0;

            // Retrieve customer details. 
            // For now we just get the first record in the database
            // TODO: use a login page
            customer = new Customer(GlobalConstants.defaultCustomerID);


            // Trace log is useful for debugging
            //Trace.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            // Display all transactions in the listbox
            foreach (var item in customer.CurrentAccount.GetTransactions())
            {
                balance += item.Amount;
                lstTransactions.Items.Add(AddTransactiontoListBox(balance, item));
            }

            // Update the screen balance and account owner display
            lblBalance.Text = balance.ToString();
            lblTransactions.Text = "Transactions for " + customer.FirstName.ToString();

        }

        private void frmTransactions_Activated(object sender, EventArgs e)
        {
            // Code to execute when the form is activated - i.e. when the 'About' form closes.
            // Update the label because the owner name may have changed
            lblTransactions.Text = "Transactions for " + customer.FirstName.ToString();
        }

        // Add the transaction details to the listbox
        private static string AddTransactiontoListBox(decimal balance, Transaction? item)
        {
            return ($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
        }

        // Fired when the withdraw button is clicked
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction transaction = customer.CurrentAccount.MakeWithdrawal(Convert.ToDecimal(txtAmount.Text), DateTime.Now, txtDescription.Text);
                lstTransactions.Items.Add(AddTransactiontoListBox(customer.CurrentAccount.Balance, transaction));
                lblBalance.Text = customer.CurrentAccount.Balance.ToString();
                lblError.Text = ""; // Clear any previous error messages
            }
            catch (Exception ex)
            {
                // Handle validation errors
                lblError.Text = ex.Message;
            }

        }

        // Fired when the deposit button is clicked
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction transaction = customer.CurrentAccount.MakeDeposit(Convert.ToDecimal(txtAmount.Text), DateTime.Now, txtDescription.Text);
                lstTransactions.Items.Add(AddTransactiontoListBox(customer.CurrentAccount.Balance, transaction));
                lblBalance.Text = customer.CurrentAccount.Balance.ToString();
                lblError.Text = ""; // Clear any previous error messages
            }
            catch (Exception ex)
            {
                // Handle validation errors
                lblError.Text = ex.Message;
            }
        }

        // Display the About page
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pass a reference to the account object to the popup form
            frmAbout aboutPage = new frmAbout(ref customer);
            aboutPage.ShowDialog();
        }


        // Display the Customer Details page
        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pass a reference to the account object to the popup form
            frmCustomer customerPage = new frmCustomer(ref customer);
            customerPage.ShowDialog();
        }
    }
}
