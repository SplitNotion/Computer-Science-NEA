using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingImprovementProgram.Algorithms.WordAnalysis;
using TypingImprovementProgram.Database;
using TypingImprovementProgram.Forms.SetupPages;
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Forms.LoginPages
{
    public partial class LoginPageForm : Form
    {
        public LoginPageForm()
        {
            InitializeComponent();

            LoginDisplay loginDisplay = new LoginDisplay();

            loginDisplay.IfCreateAccountClicked += CreateAccountClicked;

            ShowScreen(loginDisplay);
        }

        private void CreateAccountClicked(object sender, EventArgs e)
        {
            SignupDisplay signupDisplay = new SignupDisplay();

            signupDisplay.IfReturnClicked += ReturnClicked;

            ShowScreen(signupDisplay);
        }

        private void ReturnClicked(object sender, EventArgs e)
        {

            LoginDisplay loginDisplay = new LoginDisplay();

            loginDisplay.IfCreateAccountClicked += CreateAccountClicked;

            ShowScreen(loginDisplay);
        }

        public void ShowScreen(UserControl screen)
        {
            panelLoginPage.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            panelLoginPage.Controls.Add(screen);
            screen.Focus();
        }

        private void LoginPageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
