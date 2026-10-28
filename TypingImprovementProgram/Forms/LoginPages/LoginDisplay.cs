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
using TypingImprovementProgram.Forms.MainPages;
using TypingImprovementProgram.Forms.SetupPages;

namespace TypingImprovementProgram.Forms.LoginPages
{
    public partial class LoginDisplay : UserControl
    {
        public event EventHandler IfCreateAccountClicked;
        DatabaseManager databaseManager = new DatabaseManager();

        public int userID { get; private set; }
        public bool baselineCompleted { get; private set; }

        public LoginDisplay()
        {
            InitializeComponent();
            //BackColor = Color.FromArgb(235, 255, 255, 255);
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            IfCreateAccountClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = textBoxLoginUsername.Text.Trim();
            string password = textBoxLoginPassword.Text.Trim();

            bool valid = false;
            valid = accountLoginValidator(username, password);

            if (valid)
            {
                if (!baselineCompleted)
                {
                    this.FindForm().Hide();

                    BaselineTestForm baselineTestForm = new BaselineTestForm(userID);
                    baselineTestForm.Show();
                }
            }
        }

        private bool accountLoginValidator(string username, string password)
        {
            string validationResult = databaseManager.ValidateLogin(username, password, out int getUserID, out bool getBaselineCompleted);

            if (username.Length == 0)
            {
                if (password.Length == 0)
                {
                    MessageBox.Show("  Boxes have been left blank!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("  Username has been left blank!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            else if (password.Length == 0)
            {
                MessageBox.Show("  Password has been left blank!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (validationResult == "Username not found")
            {
                MessageBox.Show("  Username not found!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (validationResult == "Incorrect Password")
            {
                MessageBox.Show("  Incorrect Password!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (validationResult == "Success")
            {
                userID = getUserID;
                baselineCompleted = getBaselineCompleted;
                return true;
            }
            return true;

        }
    }
}
