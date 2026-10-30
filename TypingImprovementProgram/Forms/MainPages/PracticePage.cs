using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingImprovementProgram.Algorithms.TestGeneration;
using TypingImprovementProgram.Forms.SetupPages;

namespace TypingImprovementProgram.Forms.MainPages
{
    public partial class PracticePage : UserControl
    {
        private int userID;

        public PracticePage(int userID)
        {
            InitializeComponent();

            this.userID = userID;
        }

        //    foreach (Button button in flowLayoutPanel3.Controls.OfType<Button>())
        //        {
        //            button.BackColor = Color.White;
        //        }
        //btnLength30Words.BackColor = Color.Gray;

        private void btnGeneratePracticeTest_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            PracticeTestForm practiceTestForm = new PracticeTestForm(0);
            practiceTestForm.Show();

            PracticeTestGenerator practiceTestGenerator = new PracticeTestGenerator();
            practiceTestGenerator.GetLatestUserData(userID);


        }

        private void btnDifficultyMixed_Click(object sender, EventArgs e)
        {

        }

        private void btnDifficultyEasy_Click(object sender, EventArgs e)
        {

        }

        private void btnDifficultyHard_Click(object sender, EventArgs e)
        {

        }

        private void btnDifficultyMedium_Click(object sender, EventArgs e)
        {

        }

        private void btnTimedNone_Click(object sender, EventArgs e)
        {

        }

        private void btnTimed15Sec_Click(object sender, EventArgs e)
        {

        }

        private void btnTimed30Sec_Click(object sender, EventArgs e)
        {

        }

        private void btnTimed1Min_Click(object sender, EventArgs e)
        {

        }

        private void btnLengthRandom_Click(object sender, EventArgs e)
        {

        }

        private void btnLength30Words_Click(object sender, EventArgs e)
        {

        }

        private void btnLength40Words_Click(object sender, EventArgs e)
        {

        }

        private void btnLengthCustom_Click(object sender, EventArgs e)
        {

        }
    }
}
