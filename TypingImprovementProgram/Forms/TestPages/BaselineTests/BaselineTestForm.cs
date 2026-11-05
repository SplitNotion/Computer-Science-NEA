using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingImprovementProgram.Forms.LoginPages;

namespace TypingImprovementProgram.Forms.SetupPages
{
    public partial class BaselineTestForm : Form
    {
        private int userID = 0;
        public BaselineTestForm(int userID)
        {
            InitializeComponent();

            this.userID = userID;

            IntroductionPage introductionPage = new IntroductionPage();

            introductionPage.IfIntroductionAcceptClicked += IntroductionAcceptClicked; // calls method to show baseline test page, if accept button event is triggered by button

            ShowScreen(introductionPage); // calls method which shows the introduction page on load
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ShowScreen(UserControl screen)
        {
            panelScreen.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            panelScreen.Controls.Add(screen);
            screen.Focus();
        }

        private void IntroductionAcceptClicked(object sender, EventArgs e)
        {
            ShowScreen(new BaselineTestPage(userID));
        }

        private void introductionPage1_Load(object sender, EventArgs e)
        {

        }

        private void BaselineTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
