using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Classes
{
    // Transaction class
    public class Transaction
    {
        public int TransactionId { get; }
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }
        public int CustomerId { get; }

        // Constructor
        public Transaction(int customerid, decimal amount, DateTime date, string note)
        {
            CustomerId = customerid;
            Amount = amount;
            Date = date;
            Notes = note;
        }
    }
}
