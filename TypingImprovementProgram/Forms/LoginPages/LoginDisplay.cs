using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingImprovementProgram.Forms.MainPages;

namespace TypingImprovementProgram.Forms.LoginPages
{
    public partial class LoginDisplay : UserControl
    {
        public LoginDisplay()
        {
            InitializeComponent();
            //BackColor = Color.FromArgb(235, 255, 255, 255);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            LoginDisplay loginPage = new LoginDisplay();
            practicePage.Dock = DockStyle.Fill;
            panelContent.Controls.Add(practicePage);
            lblPageName.Text = "Practice";
        }
    }
}
