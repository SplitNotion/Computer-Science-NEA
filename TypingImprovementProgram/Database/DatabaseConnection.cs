using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingImprovementProgram.Database
{
    internal class DatabaseConnection // class that simply connects to SQL Server
    {
        public static string connectionString = "Server=(localdb)\\ProjectModels;Initial Catalog = dbTypingImprovement; Integrated Security = True; Connect Timeout = 30;";
    }
}
