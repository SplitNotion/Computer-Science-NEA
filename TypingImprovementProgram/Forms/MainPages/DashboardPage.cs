using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingImprovementProgram.Database;

namespace TypingImprovementProgram.Forms
{
    public partial class DashboardPage : UserControl
    {
        DatabaseManager databaseManager = new DatabaseManager();
        public DashboardPage(int userID)
        {
            InitializeComponent();
            databaseManager.GetAccountDetails(userID, out string username);
            lblWelcomeUser.Text = $"Welcome, {username}!";
        }
    }
}
