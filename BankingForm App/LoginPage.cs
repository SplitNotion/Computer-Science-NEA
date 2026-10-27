using BankingForm_App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BankingForm_App
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = Convert.ToString(txtboxUsername.Text.Trim()).ToLower();
            string password = Convert.ToString(txtboxPassword.Text.Trim().ToLower());
            bool blank = true;

            if (username.Length == 0)
            {
                if (password.Length == 0)
                {
                    MessageBox.Show("Username and Password has been left blank!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Username has been left blank!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (password.Length == 0)
            {
                MessageBox.Show("Password has been left blank!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidateLogin(username, password) == true)
            {
                labelincorrectWarning.Hide();
                BankingApp bankingApp = new BankingApp();
                bankingApp.Text = $"Banking App - {char.ToUpper(username[0])}" + $"{username.Substring(1, username.Length - 1)}";
                bankingApp.StartPosition = FormStartPosition.Manual;
                bankingApp.Location = this.Location;
                bankingApp.FormClosed += (s, args) => this.Close(); // stops program when banking app closes
                bankingApp.Show();
                this.Hide();
            }
            else
            {
                labelincorrectWarning.Show();
            }
        }

        private static bool ValidateLogin(string username, string password)
        {


            List<User> users = new List<User>()
            {
                new User("Benjy", "password"),
                new User("Admin", "1234"),
                new User("caspie", "spicylemon")
            };

            User user = users.FirstOrDefault(u => u.Username.ToLower() == username && u.Password.ToLower() == password); // sorts through list

            if (user != null)
            {
                return true;
            }
            return false;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username: admin\nPassword: 1234", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
