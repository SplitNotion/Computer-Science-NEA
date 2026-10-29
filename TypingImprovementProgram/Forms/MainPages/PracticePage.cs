using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingImprovementProgram.Forms.SetupPages;

namespace TypingImprovementProgram.Forms.MainPages
{
    public partial class PracticePage : UserControl
    {
        public PracticePage()
        {
            InitializeComponent();
        }

        private void btnGeneratePracticeTest_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            PracticeTestForm practiceTestForm = new PracticeTestForm(0);
            practiceTestForm.Show();


        }
    }
}
