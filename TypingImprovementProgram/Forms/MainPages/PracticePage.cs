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

        private void btnGeneratePracticeTest_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            PracticeTestForm practiceTestForm = new PracticeTestForm(0);
            practiceTestForm.Show();

            PracticeTestGenerator practiceTestGenerator = new PracticeTestGenerator();
            practiceTestGenerator.GetLatestUserData(userID);


        }
    }
}
