using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingImprovementProgram.Algorithms.TestAnalysis;
using TypingImprovementProgram.Algorithms.TestGeneration;
using TypingImprovementProgram.Database;
using TypingImprovementProgram.Forms.TestPages;
using TypingImprovementProgram.Interfaces;
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Forms.SetupPages
{
    public partial class BaselineTestPage : UserControl, ITypingTest
    {
        TypingDisplayControl display = new TypingDisplayControl();
        TypingTestManager typingTestManager = new TypingTestManager();
        BaselineTestGenerator generator = new BaselineTestGenerator();
        HesitationAnalyser hesitationAnalyser = new HesitationAnalyser();
        DatabaseManager databaseManager = new DatabaseManager();

        bool testFinished = false;
        public int incorrectCounter { get; set; }
        public int totalCharacters { get; set; }
        public int totalCharacterAttempts { get; set; }
        public int totalWords { get; set; }
        public int totalBaselineWords { get; set; }
        public int typedWords { get; set; }
        public int userID { get; set; }
        public double totalTestSeconds { get; set; }
        int currentIndex = 0;
        private Stopwatch totalTypingTimeStopwatch = new Stopwatch();

        public int TotalWords => totalWords;
        public int TypedWords => typedWords;
        public string TestNote => "Baseline Test";

        // this initialises the typing display control, including its dimensions and position, plus some other fields and variables
        public BaselineTestPage(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            // this.BackColor = Color.FromArgb(20, 32, 45);
            lblCapsLockOnWarning.Visible = Control.IsKeyLocked(Keys.CapsLock);
            btnContinueBaselineTest.Visible = false;

            display.Location = new Point(30, 250);
            display.Size = new Size(1450, 200);
            TabStop = true;

            Controls.Add(display);
            LoadTest();

            totalCharacters = display.TotalCharacters;
            totalWords = display.TotalWords;

            UpdateProgressLabel();
            KeyPress += BaselineTestPage_KeyPress; // calls key press method
        }

        private void LoadTest()
        {
            display.Characters.Clear();
            List<string> lines = generator.GenerateBaselineText();
            display.NumberOfLines = lines.Count;

            typingTestManager.LoadTest(lines, display);

            display.Characters[0].State = CharacterState.Current; // colours the first character blue
            keyboardVisualiserControl1.SetKeyColour(display.Characters[currentIndex].Character, null);

            display.MakeDisplayReady();

            display.Invalidate(); // calls to redraw (e.g. OnPaint method)
            this.Focus();

        }

        public void UpdateProgressLabel()
        {
            lbltypedWordProgressCounter.Text = typedWords + "/" + totalWords;
        }

        private void CapsLockChecker(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                lblCapsLockOnWarning.Visible = Control.IsKeyLocked(Keys.CapsLock);
            }
        }

        private void BaselineTestPage_KeyPress(object? sender, KeyPressEventArgs e) // method which reacts to each keypress
        {
            if (currentIndex == 0)
            {
                typingTestManager.StartTiming();
                totalTypingTimeStopwatch.Start();
            }

            char? incorrectCharacter = null;

            if (testFinished)
            {
                return;
            }


            #region Backspace Key Function
            // allows for backspace, however disallowing over space between words
            if (e.KeyChar == (char)Keys.Back)
            {
                if (typingTestManager.BackspaceHandling(currentIndex, display.Characters) == true)
                {
                    currentIndex--;

                    if (currentIndex > 0 && display.Characters[currentIndex - 1].State == CharacterState.Incorrect)
                    {
                        keyboardVisualiserControl1.SetKeyColour(display.Characters[currentIndex].Character, display.Characters[currentIndex - 1].Character);
                    }
                    else
                    {
                        keyboardVisualiserControl1.SetKeyColour(display.Characters[currentIndex].Character, null);
                    }
                }
                display.Invalidate();
                return;
            }
            #endregion

            totalCharacterAttempts++;

            if (currentIndex < display.Characters.Count)
            {
                typingTestManager.RecordKey(display.Characters[currentIndex].Character);
            }

            incorrectCharacter = typingTestManager.CharacterBigramAttributeAssignment(e.KeyChar, currentIndex, display.Characters); // Character Assignment

            bool nextCharacterExists = typingTestManager.MoveToNextCharacter(ref currentIndex, display.Characters); // whether test can continue to next character, or test should end

            // end of test event
            if (!nextCharacterExists)
            {
                typingTestManager.StopTiming();
                totalTypingTimeStopwatch.Stop();
                testFinished = true;
                btnContinueBaselineTest.Visible = true;
                typedWords++;
                keyboardVisualiserControl1.ResetKeyColours();
                UpdateProgressLabel();
            }

            else
            {
                keyboardVisualiserControl1.SetKeyColour(display.Characters[currentIndex].Character, incorrectCharacter);

                // updates number of typed words
                if (display.Characters[currentIndex - 1].Character == ' ')
                {
                    typedWords++;
                    lbltypedWordProgressCounter.Text = typedWords + "/" + totalWords;
                }

                // shifts all text lines up when second row is completed
                if (display.Characters[currentIndex].Line > display.CurrentLine + 1)
                {
                    display.CurrentLine++;
                }
            }
            display.Invalidate();
        }


        private void btnContinueBaselineTest_Click(object sender, EventArgs e)
        {
            display.Characters.Clear();
            currentIndex = 0;
            btnContinueBaselineTest.Visible = false;
            display.CurrentLine = 0;
            typedWords = 0;

            if (generator.testNumber != 3)
            {
                testFinished = false;
                LoadTest();
                totalWords = display.TotalWords;
                totalBaselineWords += totalWords;
                UpdateProgressLabel();
            }

            else
            {
                totalBaselineWords += totalWords;
                totalTestSeconds = totalTypingTimeStopwatch.Elapsed.TotalSeconds;
                hesitationAnalyser.AnalyseHesitaton(typingTestManager.timings);
                PerformanceAnalyser performanceAnalyser = new PerformanceAnalyser(this, hesitationAnalyser, typingTestManager);

                Controls.Remove(display);
                lbltypedWordProgressCounter.Visible = false;
                keyboardPanel.Visible = false;
                testFinished = true;

                databaseManager.CompletedBaselineTest(userID);

                this.FindForm().Hide();
                MainPagesForm mainPagesForm = new MainPagesForm(userID);
                mainPagesForm.Show();
            }
        }


    }
}
