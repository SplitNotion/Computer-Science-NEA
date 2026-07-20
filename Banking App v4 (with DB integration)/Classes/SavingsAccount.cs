using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BankingApp.Classes
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; private set; }

        public SavingsAccount(Customer owner, decimal interestRate)
            : base(owner)
        {
            InterestRate = interestRate;
        }

        public void ApplyMonthlyInterest()
        {
            var interest = Balance * InterestRate / 100;
            MakeDeposit(interest, DateTime.Now, "Monthly interest");
        }

        // Example of polymorphism - different behaviour for this method on the child classes
        public override Transaction MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            
            throw new InvalidOperationException("You cannot withdraw directly from a Savings Account.");

        }
    }
}

