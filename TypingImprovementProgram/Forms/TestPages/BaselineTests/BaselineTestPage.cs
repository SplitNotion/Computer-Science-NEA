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
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Forms.SetupPages
{
    public partial class BaselineTestPage : UserControl
    {
        TypingDisplayControl display = new TypingDisplayControl();
        TypingTestManager typingTestManager = new TypingTestManager();
        BaselineTestGenerator generator = new BaselineTestGenerator();
        HesitationAnalyser hesitationAnalyser = new HesitationAnalyser();
        PerformanceAnalyser performanceAnalyser;

        bool testFinished = false;
        public int incorrectCounter { get; set; }
        public int totalCharacters { get; set; }
        public int totalCharacterAttempts { get; set; }
        public int totalWords { get; set; }
        public int totalBaselineWords { get; set; }
        public int typedWords { get; set; }

        public int userID;
        public bool isBaselineCompleted = false;

        public Dictionary<char, int> incorrectLetters = new Dictionary<char, int>();
        public Dictionary<string, int> incorrectBigrams = new Dictionary<string, int>();


        int currentIndex = 0;

        private Stopwatch totalTypingTimeStopwatch = new Stopwatch();
        public double totalTestSeconds = 0.0;



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
                if (currentIndex > 0)
                {
                    if (display.Characters[currentIndex - 1].Character != ' ')
                    {
                        display.Characters[currentIndex].State = CharacterState.Untyped;
                        display.Characters[currentIndex - 1].State = CharacterState.Current;
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
            currentIndex++; // move to next character


            // events at end of test
            if (currentIndex >= display.Characters.Count)
            {
                typingTestManager.StopTiming();
                totalTypingTimeStopwatch.Stop();
                testFinished = true;
                btnContinueBaselineTest.Visible = true;
                typedWords++;
                UpdateProgressLabel();
            }

            // updates the current character, word count and text position on the screen
            if (currentIndex < display.Characters.Count)
            {
                display.Characters[currentIndex].State = CharacterState.Current;
                keyboardVisualiserControl1.SetKeyColour(display.Characters[currentIndex].Character, incorrectCharacter);

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
                performanceAnalyser = new PerformanceAnalyser(this, hesitationAnalyser, typingTestManager);

                Controls.Remove(display);
                lbltypedWordProgressCounter.Visible = false;
                keyboardPanel.Visible = false;
                testFinished = true;

                DatabaseManager databaseManager = new DatabaseManager();
                databaseManager.CompletedBaselineTest(userID);

                this.FindForm().Hide();
                MainPagesForm mainPagesForm = new MainPagesForm(userID);
                mainPagesForm.Show();
            }
        }


    }
}
