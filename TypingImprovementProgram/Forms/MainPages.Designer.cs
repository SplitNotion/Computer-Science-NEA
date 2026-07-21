namespace TypingImprovementProgram.Forms
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSidebarDashboard = new Button();
            btnSidebarPractice = new Button();
            btnSidebarStatistics = new Button();
            btnSidebarPrevTests = new Button();
            btnSidebarHelp = new Button();
            btnSidebarSettings = new Button();
            btnSidebarSignout = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panelSidebar.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = SystemColors.ActiveCaptionText;
            panelSidebar.Controls.Add(flowLayoutPanel1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 673);
            panelSidebar.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Azure;
            flowLayoutPanel1.Controls.Add(btnSidebarDashboard);
            flowLayoutPanel1.Controls.Add(btnSidebarPractice);
            flowLayoutPanel1.Controls.Add(btnSidebarStatistics);
            flowLayoutPanel1.Controls.Add(btnSidebarPrevTests);
            flowLayoutPanel1.Controls.Add(btnSidebarHelp);
            flowLayoutPanel1.Controls.Add(btnSidebarSettings);
            flowLayoutPanel1.Controls.Add(btnSidebarSignout);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 30, 10, 15);
            flowLayoutPanel1.Size = new Size(220, 673);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnSidebarDashboard
            // 
            btnSidebarDashboard.FlatAppearance.BorderSize = 0;
            btnSidebarDashboard.FlatStyle = FlatStyle.Flat;
            btnSidebarDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSidebarDashboard.Location = new Point(13, 33);
            btnSidebarDashboard.Name = "btnSidebarDashboard";
            btnSidebarDashboard.Padding = new Padding(0, 5, 0, 5);
            btnSidebarDashboard.Size = new Size(200, 50);
            btnSidebarDashboard.TabIndex = 0;
            btnSidebarDashboard.Text = "Dashboard";
            btnSidebarDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarDashboard.UseVisualStyleBackColor = true;
            btnSidebarDashboard.Click += btnSidebarDashboard_Click;
            // 
            // btnSidebarPractice
            // 
            btnSidebarPractice.Dock = DockStyle.Top;
            btnSidebarPractice.FlatAppearance.BorderSize = 0;
            btnSidebarPractice.FlatStyle = FlatStyle.Flat;
            btnSidebarPractice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSidebarPractice.Location = new Point(13, 89);
            btnSidebarPractice.Name = "btnSidebarPractice";
            btnSidebarPractice.Padding = new Padding(0, 5, 0, 5);
            btnSidebarPractice.Size = new Size(200, 50);
            btnSidebarPractice.TabIndex = 1;
            btnSidebarPractice.Text = "Practice";
            btnSidebarPractice.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarPractice.UseVisualStyleBackColor = true;
            btnSidebarPractice.Click += btnSidebarPractice_Click;
            // 
            // btnSidebarStatistics
            // 
            btnSidebarStatistics.Dock = DockStyle.Top;
            btnSidebarStatistics.FlatAppearance.BorderSize = 0;
            btnSidebarStatistics.FlatStyle = FlatStyle.Flat;
            btnSidebarStatistics.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSidebarStatistics.Location = new Point(13, 145);
            btnSidebarStatistics.Name = "btnSidebarStatistics";
            btnSidebarStatistics.Size = new Size(200, 50);
            btnSidebarStatistics.TabIndex = 2;
            btnSidebarStatistics.Text = "Statistics";
            btnSidebarStatistics.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarStatistics.UseVisualStyleBackColor = true;
            // 
            // btnSidebarPrevTests
            // 
            btnSidebarPrevTests.Dock = DockStyle.Top;
            btnSidebarPrevTests.FlatAppearance.BorderSize = 0;
            btnSidebarPrevTests.FlatStyle = FlatStyle.Flat;
            btnSidebarPrevTests.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSidebarPrevTests.Location = new Point(13, 201);
            btnSidebarPrevTests.Name = "btnSidebarPrevTests";
            btnSidebarPrevTests.Size = new Size(200, 50);
            btnSidebarPrevTests.TabIndex = 3;
            btnSidebarPrevTests.Text = "Previous Tests";
            btnSidebarPrevTests.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarPrevTests.UseVisualStyleBackColor = true;
            // 
            // btnSidebarHelp
            // 
            btnSidebarHelp.Dock = DockStyle.Top;
            btnSidebarHelp.FlatAppearance.BorderSize = 0;
            btnSidebarHelp.FlatStyle = FlatStyle.Flat;
            btnSidebarHelp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSidebarHelp.Location = new Point(13, 257);
            btnSidebarHelp.Name = "btnSidebarHelp";
            btnSidebarHelp.Size = new Size(200, 50);
            btnSidebarHelp.TabIndex = 4;
            btnSidebarHelp.Text = "Help ";
            btnSidebarHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarHelp.UseVisualStyleBackColor = true;
            // 
            // btnSidebarSettings
            // 
            btnSidebarSettings.Dock = DockStyle.Top;
            btnSidebarSettings.FlatAppearance.BorderSize = 0;
            btnSidebarSettings.FlatStyle = FlatStyle.Flat;
            btnSidebarSettings.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSidebarSettings.Location = new Point(13, 313);
            btnSidebarSettings.Name = "btnSidebarSettings";
            btnSidebarSettings.Size = new Size(200, 50);
            btnSidebarSettings.TabIndex = 5;
            btnSidebarSettings.Text = "Settings";
            btnSidebarSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarSettings.UseVisualStyleBackColor = true;
            // 
            // btnSidebarSignout
            // 
            btnSidebarSignout.FlatAppearance.BorderSize = 0;
            btnSidebarSignout.FlatStyle = FlatStyle.Flat;
            btnSidebarSignout.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSidebarSignout.Location = new Point(13, 369);
            btnSidebarSignout.Name = "btnSidebarSignout";
            btnSidebarSignout.Padding = new Padding(0, 5, 0, 5);
            btnSidebarSignout.Size = new Size(200, 50);
            btnSidebarSignout.TabIndex = 6;
            btnSidebarSignout.Text = "Sign Out";
            btnSidebarSignout.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebarSignout.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelSidebar);
            MinimumSize = new Size(1280, 720);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPages";
            panelSidebar.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Button btnSidebarDashboard;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnSidebarPractice;
        private Button btnSidebarStatistics;
        private Button btnSidebarSignout;
        private Button btnSidebarSettings;
        private Button btnSidebarHelp;
        private Button btnSidebarPrevTests;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}