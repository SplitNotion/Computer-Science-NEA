using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingImprovementProgram.Algorithms.UserProcessingAlgorithms;
using TypingImprovementProgram.Database;
using TypingImprovementProgram.Forms.SetupPages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TypingImprovementProgram.Forms.LoginPages
{
    public partial class SignupDisplay : UserControl
    {

        public event EventHandler IfReturnClicked;

        public SignupDisplay()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            IfReturnClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnCreateUserAccount_Click(object sender, EventArgs e)
        {
            string username = textBoxSignUpUsername.Text.Trim();
            string password = textboxSignUpPassword.Text.Trim();
            string confirmPassword = textBoxReenterPassword.Text.Trim();

            bool valid = false;

            valid = AccountCreationValidator(username, password, confirmPassword);

            if (valid)
            {
                DatabaseManager databaseManager = new DatabaseManager();
                int userID = databaseManager.InsertNewUserAccount(username, password);
                MessageBox.Show($"ID returned from database: {userID}");

                this.FindForm().Hide();

                BaselineTestForm baselineTestForm = new BaselineTestForm(userID);
                baselineTestForm.Show();
            }
        }

        private bool AccountCreationValidator(string username, string password, string confirmPassword)
        {

            #region empty textboxes event handling

            if (username.Length == 0)
            {
                if (password.Length == 0)
                {
                    if (confirmPassword.Length == 0)
                    {
                        MessageBox.Show("  Boxes have been left blank!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("  Username and Password has been left blank!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    if (confirmPassword.Length == 0)
                    {
                        MessageBox.Show("  Username and Confirm Password has been left blank!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("  Username has been left blank!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            else if (password.Length == 0)
            {
                if (confirmPassword.Length == 0)
                {
                    MessageBox.Show("  Password and Confirm Password has been left blank!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("  Password has been left blank!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (confirmPassword.Length == 0)
            {
                MessageBox.Show("  Confirm Password has been left blank!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            #endregion

            #region textbox inputs handling
            List<string> usernameErrors = new List<string>();
            List<string> passwordErrors = new List<string>();

            List<string> errors = new List<string>();

            if (username.Length < 5)
            {
                //usernameErrors.Add("   Username must be at least 5 characters long!");
                errors.Add("   Username must be at least 5 characters long!");
            }
            if (username.Contains(' '))
            {
                errors.Add("   Username must not contain whitepsace!");
            }

            if (errors.Count > 0)
            {
                errors.Add(" ");
            }

            if (password.Length < 5)
            {
                errors.Add("   Password must be at least 5 characters long!");
            }

            if (!password.Any(char.IsUpper))
            {
                errors.Add("   Password must contain at least one uppercase character!");
            }

            if (!password.Any(c => !char.IsLetterOrDigit(c)))
            {
                errors.Add("   Password must contain at least one special character!");
            }

            if (errors.Count > 0)
            {
                errors.Add(" ");
            }

            if (password != confirmPassword)
            {
                errors.Add("   Password and Confirm Password inputs must match!");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return false;
            }

            #endregion

            return true;
        }
    }
}
