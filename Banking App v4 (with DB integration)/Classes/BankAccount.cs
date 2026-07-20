using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BankingApp.Classes
{
    // Bank Account parent class
    public class BankAccount
    {

        public string Number { get; set;  }
        public Customer Owner { get; set; }
        
        // Return the balance based on all the transactions on the account
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in _allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        // Returns the list of account transactions
        public List<Transaction> GetTransactions()
        {
            return _allTransactions;
        }

        // Constructor - sets the customer 'Owner' property
        public BankAccount(Customer customer)
        {
            Owner = customer;
        }

        private List<Transaction> _allTransactions = new List<Transaction>(); // A collection of all the bank transactions on the account

        // Adds a transaction to the internally maintained list
        public void AppendToTransactionList(Transaction transaction)
        {
            _allTransactions.Add(transaction);
        }

        // Makes a deposit transaction
        public Transaction MakeDeposit(decimal amount, DateTime date, string note)
        {
            // Validate that the deposit amount is greater than zero and that there are sufficient funds
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            Transaction deposit = new Transaction(Owner.CustomerId, amount, date, note);
            AddTransaction(deposit); // Save to the database
            _allTransactions.Add(deposit);

            return deposit;
        }

        // Makes a withdrawal transaction
        // virtual means that inheritance can work for this method, so the method can be overridden
        public virtual Transaction MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            // Validate that the withdrawal amount is greater than zero and that there are sufficient funds in the account
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }

            Transaction withdrawal = new Transaction(Owner.CustomerId, -amount, date, note);
            AddTransaction(withdrawal); // Save to the database
            _allTransactions.Add(withdrawal);

            return withdrawal;
        }

        // Outputs the account history
        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");

            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }

        // Adds a transaction to the database
        public void AddTransaction(Transaction thisTransaction)
        {

            using (var connection = new SqlConnection(GlobalConstants.connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO TRANSACTIONS (Amount, CustomerID, Notes, DateTime) VALUES (@Amount, @CustomerID, @Notes, @DateTime)";
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Amount", thisTransaction.Amount);
                    command.Parameters.AddWithValue("@CustomerID", thisTransaction.CustomerId);
                    command.Parameters.AddWithValue("@Notes", thisTransaction.Notes);
                    command.Parameters.AddWithValue("@DateTime", thisTransaction.Date);
                    command.ExecuteNonQuery();
                }
            }

            Debug.WriteLine("Transaction added successfully.\n");
        }
    }

}
