using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingForm_App.Classes
{
    internal class Transaction // class which manages/creates each line in the transaction box (e.g. 04/01/2025  -380   620   PlayStation 5 Purchase)
    {
        public DateTime Date { get; }
        public decimal Amount { get; }
        public decimal BalanceAfter { get; }
        public string Description { get; }
        public bool State { get; }

        public Transaction(DateTime date, decimal amount, decimal balanceAfter, string description, bool state)
        {
            Date = date;
            Amount = amount;
            BalanceAfter = balanceAfter;
            Description = description;
            State = state;
        }
    }
}
