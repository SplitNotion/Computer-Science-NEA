using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Classes
{
    static class GlobalConstants
    {
        // Database connection string 
        public static string connectionString = "Server=(localdb)\\ProjectModels;Initial Catalog = dbBanking1; Integrated Security = True; Connect Timeout = 30;";

        public static int defaultCustomerID = 1;
    }
}
