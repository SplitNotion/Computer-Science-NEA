using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingForm_App.Classes
{
    internal class Customer // class which creates user data for each customer
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustomerID { get; }

        public Customer(int customerID, string firstName, string lastName)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
        }


    }
}
