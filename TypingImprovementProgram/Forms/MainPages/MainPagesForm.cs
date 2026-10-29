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
using TypingImprovementProgram.Forms.MainPages;
using TypingImprovementProgram.Forms.SetupPages;

namespace TypingImprovementProgram.Forms
{
    public partial class MainPagesForm : Form
    {
        private int userID;

        public MainPagesForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;


            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Button btn)
                {
                    btn.Margin = new Padding(0, 10, 0, 10);
                    btn.Height = 75;
                }
            }
        }

        private void btnSidebarDashboard_Click(object sender, EventArgs e) // open dashboard page button click event
        {
            panelContent.Controls.Clear();
            DashboardPage dashboardPage = new DashboardPage();
            dashboardPage.Dock = DockStyle.Fill;
            panelContent.Controls.Add(dashboardPage);
            lblPageName.Text = "Dashboard";
        }

        private void btnSidebarPractice_Click(object sender, EventArgs e) // open practice button click event
        {
            panelContent.Controls.Clear();
            PracticePage practicePage = new PracticePage(userID);
            practicePage.Dock = DockStyle.Fill;
            panelContent.Controls.Add(practicePage);
            lblPageName.Text = "Practice";
        }

        private void btnSidebarStatistics_Click(object sender, EventArgs e) // open statistics page button event
        {
            panelContent.Controls.Clear();
            StatisticsPage statsPage = new StatisticsPage();
            statsPage.Dock = DockStyle.Fill;
            panelContent.Controls.Add(statsPage);
            lblPageName.Text = "Statistics";
        }

        private void btnSidebarPrevTests_Click(object sender, EventArgs e) // open previous tests page button event
        {
            panelContent.Controls.Clear();
            PreviousTestsPage prevTestsPage = new PreviousTestsPage();
            prevTestsPage.Dock = DockStyle.Fill;
            panelContent.Controls.Add(prevTestsPage);
            lblPageName.Text = "Previous Tests";
        }

        private void btnSidebarHelp_Click(object sender, EventArgs e) // open help page button event
        {
            panelContent.Controls.Clear();
            HelpPage helpPage = new HelpPage();
            helpPage.Dock = DockStyle.Fill;
            panelContent.Controls.Add(helpPage);
            lblPageName.Text = "Help";
        }

        private void btnSidebarSettings_Click(object sender, EventArgs e) // open settings page button event
        {
            panelContent.Controls.Clear();
            SettingsPage settingsPage = new SettingsPage();
            settingsPage.Dock = DockStyle.Fill;
            panelContent.Controls.Add(settingsPage);
            lblPageName.Text = "Settings";
        }

        private void btnSidebarSignout_Click(object sender, EventArgs e)
        {
            DialogResult userSelection = MessageBox.Show("   Are you sure you want to sign out?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == userSelection)
            {
                this.FindForm().Hide();
                LoginPageForm loginPageForm = new LoginPageForm();
                loginPageForm.Show();
            }
            else
            {
                return;
            }
        }



        private void dashboardPage1_Load_1(object sender, EventArgs e)
        {

        }

        private void MainPagesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
