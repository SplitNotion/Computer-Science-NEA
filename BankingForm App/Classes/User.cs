using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingForm_App.Classes
{
    internal class User // class which sets usernames and passwords for login page
    {
        public string Username { get; }
        public string Password { get; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
