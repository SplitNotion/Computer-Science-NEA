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

namespace TypingImprovementProgram.Forms.MainPages
{
    public partial class SettingsPage : UserControl
    {
        DatabaseManager databaseManager = new DatabaseManager();

        public SettingsPage(int userID)
        {
            InitializeComponent();
            ShowUserAccountDetails(userID);
        }

        private void ShowUserAccountDetails(int userID)
        {
            lblUserID.Text = $"Your UserID = {userID}";
            databaseManager.GetAccountDetails(userID, out string username);
            lblUsername.Text = $"Your Username = {username}";
        }
    }
}
