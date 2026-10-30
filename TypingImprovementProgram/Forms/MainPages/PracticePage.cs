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

        private string difficulty = "mixed";
        private int testTiming = -1;
        private int testWords = -1;


        public PracticePage(int userID)
        {
            InitializeComponent();

            this.userID = userID;
            HideCustomLengthInputs();
        }

        private void btnGeneratePracticeTest_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            

            if (testWords == 99)
            {
                testWords = Convert.ToInt32(txtBoxCustomLength.Text);
            }

            PracticeTestForm practiceTestForm = new PracticeTestForm(userID, difficulty, testTiming, testWords);
            practiceTestForm.Show();

            // PracticeTestForm practiceTestForm1 = new PracticeTestForm(userID);
            // practiceTestForm1.Show();

            // PracticeTestPage practiceTestPage = new PracticeTestPage();
            // practiceTestPage.InitialiseTest(difficulty, testTiming, testWords, userID);
        }


        private void btnDifficultyMixed_Click(object sender, EventArgs e)
        {
            foreach (Button button in flowLayoutPanel1.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }
            btnDifficultyMixed.BackColor = Color.Gray;
            difficulty = "mixed";
        }

        private void btnDifficultyEasy_Click(object sender, EventArgs e)
        {
            foreach (Button button in flowLayoutPanel1.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }
            btnDifficultyEasy.BackColor = Color.Gray;
            difficulty = "easy";
        }

        private void btnDifficultyMedium_Click(object sender, EventArgs e)
        {
            foreach (Button button in flowLayoutPanel1.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }
            btnDifficultyMedium.BackColor = Color.Gray;
            difficulty = "medium";
        }

        private void btnDifficultyHard_Click(object sender, EventArgs e)
        {
            foreach (Button button in flowLayoutPanel1.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }
            btnDifficultyHard.BackColor = Color.Gray;
            difficulty = "hard";
        }

        private void btnTimedNone_Click(object sender, EventArgs e)
        {
            foreach (Button button in flowLayoutPanel2.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }
            btnTimedNone.BackColor = Color.Gray;
            EnableLengthButtons();
            testTiming = -1;
        }

        private void btnTimed15Sec_Click(object sender, EventArgs e)
        {
            foreach (Button button in flowLayoutPanel2.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }
            btnTimed15Sec.BackColor = Color.Gray;
            DisableLengthButtons();
            testTiming = 15;
        }

        private void btnTimed30Sec_Click(object sender, EventArgs e)
        {
            foreach (Button button in flowLayoutPanel2.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }
            btnTimed30Sec.BackColor = Color.Gray;
            DisableLengthButtons();
            testTiming = 30;
        }

        private void btnTimed1Min_Click(object sender, EventArgs e)
        {
            foreach (Button button in flowLayoutPanel2.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }
            btnTimed1Min.BackColor = Color.Gray;
            DisableLengthButtons();
            testTiming = 60;
        }

        private void btnLengthRandom_Click(object sender, EventArgs e)
        {
            foreach (Button button in flowLayoutPanel3.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }
            btnLengthRandom.BackColor = Color.Gray;
            HideCustomLengthInputs();
            testWords = -1;
        }

        private void btnLength30Words_Click(object sender, EventArgs e)
        {
            foreach (Button button in flowLayoutPanel3.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }
            btnLength30Words.BackColor = Color.Gray;
            HideCustomLengthInputs();
            testWords = 30;
        }

        private void btnLength40Words_Click(object sender, EventArgs e)
        {
            foreach (Button button in flowLayoutPanel3.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }
            btnLength40Words.BackColor = Color.Gray;
            HideCustomLengthInputs();
            testWords = 40;
        }

        private void btnLengthCustom_Click(object sender, EventArgs e)
        {
            foreach (Button button in flowLayoutPanel3.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }
            btnLengthCustom.BackColor = Color.Gray;
            txtBoxCustomLength.Visible = true;
            lblCustomLength.Visible = true;
            testWords = 99;
        }

        private void HideCustomLengthInputs()
        {
            txtBoxCustomLength.Visible = false;
            lblCustomLength.Visible = false;
        }

        private void DisableLengthButtons()
        {
            foreach (Button button in flowLayoutPanel3.Controls.OfType<Button>())
            {
                button.BackColor = Color.DimGray;
                button.Enabled = false;
            }
            HideCustomLengthInputs();
        }

        private void EnableLengthButtons()
        {
            foreach (Button button in flowLayoutPanel3.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
                button.Enabled = true;
            }
            btnLengthRandom.BackColor = Color.Gray;
        }
    }
}
