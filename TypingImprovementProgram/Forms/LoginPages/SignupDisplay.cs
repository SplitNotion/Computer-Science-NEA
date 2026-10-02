using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingImprovementProgram.Algorithms.UserProcessingAlgorithms;

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
            UserLogin userLogin = new UserLogin();

            userLogin.CreateAccount(textBoxSignUpUsername.Text, textBoxLoginPassword.Text);
        }
    }
}
