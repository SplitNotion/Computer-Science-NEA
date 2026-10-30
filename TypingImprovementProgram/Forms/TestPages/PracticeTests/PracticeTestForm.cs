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
    public partial class PracticeTestForm : Form
    {
        private int userID;
        public PracticeTestForm(int userID, string difficulty, int testTiming, int testWords)
        {
            InitializeComponent();
            this.userID = userID;

            practiceTestPage1.InitialiseTest(difficulty, testTiming, testWords, userID);

            ShowScreen(practiceTestPage1);

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

        private void introductionPage1_Load(object sender, EventArgs e)
        {

        }
        private void PracticeTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FindForm().Hide();
            MainPagesForm mainPagesForm = new MainPagesForm(userID);
            mainPagesForm.Show();
        }
    }
}
