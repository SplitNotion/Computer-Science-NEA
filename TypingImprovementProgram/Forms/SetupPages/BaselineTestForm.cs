using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingImprovementProgram.Forms.SetupPages
{
    public partial class BaselineTestForm : Form
    {
        public BaselineTestForm()
        {
            InitializeComponent();
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
        }

        private void IntroductionAcceptClicked(object sender, EventArgs e)
        {
            ShowScreen(new BaselineTestPage());
        }
    }
}
