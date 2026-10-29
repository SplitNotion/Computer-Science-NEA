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
                else
                {
                    this.FindForm().Hide();

                    MainPagesForm mainPagesForm = new MainPagesForm(userID);
                    mainPagesForm.Show();
                }
            }
        }


        // validates the details inputted into the login page textboxes, whilst also retrieving the user's ID and whether they have completed the baseline test on successful login
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

            switch (validationResult)
            {
                case "Username not found":
                    MessageBox.Show("  Username not found!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;

                case "Incorrect Password":
                    MessageBox.Show("  Username not found!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;

                case "Success":
                    userID = getUserID;
                    baselineCompleted = getBaselineCompleted;
                    return true;

                default:
                    MessageBox.Show("Login Validation Failed. Please contact program developer.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
            }
        }
    }
}
