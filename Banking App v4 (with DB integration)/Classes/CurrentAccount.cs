using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BankingApp.Classes
{
    public class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; private set; }

        public CurrentAccount(Customer owner, decimal overdraftLimit)
            : base(owner)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override Transaction MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");

            if (Balance - amount < -OverdraftLimit)
                throw new InvalidOperationException("Overdraft limit exceeded");

            var withdrawal = new Transaction(Owner.CustomerId,-amount, date, note);
            AddTransaction(withdrawal); // Save to the database
            GetTransactions().Add(withdrawal);
            return withdrawal;
        }
    }
}

