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
    public partial class IntroductionPage : UserControl
    {
        public event EventHandler IfIntroductionAcceptClicked;

        public IntroductionPage()
        {
            InitializeComponent();
        }

        private void btnIntroductionAccept_Click(object sender, EventArgs e)
        {
            IfIntroductionAcceptClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
