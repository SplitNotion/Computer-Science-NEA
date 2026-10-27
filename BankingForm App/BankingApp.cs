using BankingForm_App.Classes;
using System.Drawing.Text;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace BankingForm_App
{
    public partial class BankingApp : Form
    {
        private BankAccount account;

        public BankingApp()
        {
            InitializeComponent();
            CreateListView();
            account = new BankAccount(1000);
            UIRefresh();
        }


        // creates ListView with Transactions listed (refreshes UI)
        private void UIRefresh() 
        {
            listTransactions.Items.Clear();

            foreach (var t in account.GetTransactions())
            {
                var item = new ListViewItem(t.Date.ToString("dd/MM/yyyy"));
                item.SubItems.Add(t.Amount.ToString());
                item.SubItems.Add(t.BalanceAfter.ToString());
                item.SubItems.Add(t.Description.ToString());

                if (t.State == true)
                {
                    item.SubItems.Add("Y");
                }
                listTransactions.Items.Add(item);
            }
            lblBalanceText.Text = account.Balance.ToString();
            listTransactions.Items[listTransactions.Items.Count - 1].EnsureVisible(); // keeps listview open at latest transactions (latest added row)
        }

        
        // creates list view w/ columns
        private void CreateListView()
        {
            listTransactions.Columns.Clear();
            listTransactions.Columns.Add("Date", 100, HorizontalAlignment.Center);
            listTransactions.Columns.Add("Amount", 80, HorizontalAlignment.Center);
            listTransactions.Columns.Add("Balance", 80, HorizontalAlignment.Center);
            listTransactions.Columns.Add("Description", 150);
            listTransactions.Columns.Add("In Debt?", 83, HorizontalAlignment.Center);
        }


        // deposit button event
        private void DepositButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(AmountText.Text);
                string description = DescriptionText.Text;
                account.MakeDeposit(amount, description);
                UIRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Amount must be a number.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // withdraw button event
        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(AmountText.Text);
                string description = DescriptionText.Text;
                account.MakeWithdrawal(amount, description);
                UIRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Amount must be a number.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // reset transaction data 
        private void ResetAccountButton_Click(object sender, EventArgs e)
        {
            account.GetTransactions().Clear();
            listTransactions.Items.Clear();
            account = new BankAccount(1000);
            UIRefresh();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BankingApp_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelDescription_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LabelAmount_Click(object sender, EventArgs e)
        {

        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerDetailsPopUp customerDetailsPopUp = new CustomerDetailsPopUp(ref account);
            customerDetailsPopUp.ShowDialog(); // only one is allowed to be opened at once
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userSelection = MessageBox.Show("Are you sure you want to sign-out? All data will be lost.", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (DialogResult.OK == userSelection)
            {
                LoginPage loginPage = new LoginPage();
                loginPage.StartPosition = FormStartPosition.Manual;
                loginPage.Location = this.Location;
                loginPage.FormClosed += (s, args) => this.Close();
                this.Hide();
                loginPage.Show();
            }
            else
            {
                return;
            }
        }
    }
}
