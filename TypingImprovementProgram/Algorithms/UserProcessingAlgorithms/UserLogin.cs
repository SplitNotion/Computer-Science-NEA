using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Database;

namespace TypingImprovementProgram.Algorithms.UserProcessingAlgorithms
{
    internal class UserLogin
    {
        DatabaseManager databaseManager = new DatabaseManager();

        public void CreateAccount(string username, string password)
        {
            databaseManager.InsertNewUserAccount(username, password);
        }

    }
}
