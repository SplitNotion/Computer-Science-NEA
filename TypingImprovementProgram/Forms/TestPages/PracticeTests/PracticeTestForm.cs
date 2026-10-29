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
        private int userID = 0;
        public PracticeTestForm(int userID)
        {
            InitializeComponent();

            //StartPosition = FormStartPosition.Manual;
            //Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;
            //int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            //int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            //Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
            //Size = new Size(w, h);
            this.userID = userID;

            ShowScreen(new PracticeTestPage());

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

        private void BaselineTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
