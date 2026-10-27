using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingForm_App.Classes
{
    internal class BankAccount
    {

        private static int s_accountNumberSeed = 1000000000;
        private static int s_accountOwnerCustomerID;
        private static string s_accountOwnerFirstName = "Benjy";
        private static string s_accountOwnerLastName = "Konig";

        public decimal Balance { get; set; }
        public bool State { get; set; }
        private List<Transaction> Transactions { get; } = new(); // list of objects containing all transactions
        public Customer Owner { get; set; }


        // creates initial balance and initialises owner data
        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
            s_accountOwnerCustomerID = s_accountNumberSeed;
            Owner = new Customer(s_accountOwnerCustomerID, s_accountOwnerFirstName, s_accountOwnerLastName);
            s_accountNumberSeed++;
            Transactions.Add(new Transaction(DateTime.Now, initialBalance, Balance, "Initial Balance", State));
        }


        // allows transactions to be set (and cleared)
        public List<Transaction> GetTransactions()
        {
            return Transactions;
        }

        // makes deposit transaction
        public void MakeDeposit(decimal amount, string description)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount to deposit must be positive");
            }

            Balance = Balance + amount;
            if (Balance < 0)
            {
                State = true;
            }
            else
            {
                State = false;
            }
            Transactions.Add(new Transaction(DateTime.Now, amount, Balance, description, State));
        }

        // makes withdrawal transaction
        public void MakeWithdrawal(decimal amount, string description)
        {
            if (amount <= 0 )
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount to withdraw must be positive");
            }
            Balance = Balance - amount;

            if (Balance < 0)
            {
                State = true;
            }
            else
            {
                State = false;
            }
            amount = amount * -1;
            Transactions.Add(new Transaction(DateTime.Now, amount, Balance, description, State));

        }

    }
}
