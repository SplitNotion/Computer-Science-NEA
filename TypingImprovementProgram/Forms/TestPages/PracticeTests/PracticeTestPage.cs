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
using TypingImprovementProgram.Forms.TestPages;
using TypingImprovementProgram.Models;
using TypingImprovementProgram.Interfaces;

namespace TypingImprovementProgram.Forms.SetupPages
{
    public partial class PracticeTestPage : UserControl, ITypingTest
    {
        TypingDisplayControl display = new TypingDisplayControl();
        TypingTestManager typingTestManager = new TypingTestManager();
        PracticeTestGenerator generator;    
        HesitationAnalyser hesitationAnalyser = new HesitationAnalyser();

        bool testFinished = false;
        public int incorrectCounter { get; set; }
        public int totalCharacters { get; set; }
        public int totalCharacterAttempts { get; set; }
        public int totalWords { get; set; }
        public int typedWords { get; set; }
        public int userID { get; set; }
        public double totalTestSeconds { get; set; }
        int currentIndex = 0;
        private Stopwatch totalTypingTimeStopwatch = new Stopwatch();
        private bool timerInUse = false;
        private int remainingTime;

        public int TotalWords => totalWords;
        public int TypedWords => typedWords;
        public string TestNote => "Practice Test";



        // this initialises the typing display control, including its dimensions and position, plus some other fields and variables
        public PracticeTestPage()
        {
            InitializeComponent();
            // this.BackColor = Color.FromArgb(20, 32, 45);
            lblCapsLockOnWarning.Visible = Control.IsKeyLocked(Keys.CapsLock);
            btnContinuePracticeTest.Visible = false;

            display.Location = new Point(30, 250);
            display.Size = new Size(1450, 200);
            TabStop = true;

            Controls.Add(display);

            totalCharacters = display.TotalCharacters;
            totalWords = display.TotalWords;

            KeyPress += PracticeTestPage_KeyPress; // calls key press method
        }

        public void InitialiseTest(string difficulty, int testTiming, int testWords, int userID)
        {
            this.userID = userID;

            generator = new PracticeTestGenerator(difficulty, testTiming, testWords);
            this.remainingTime = testTiming;
            CheckTimer();
            generator.GetLatestUserData(userID);

            LoadTest();
        }

        private void CheckTimer()
        {
            if (remainingTime != -1)
            {
                lblTimerDisplay.Visible = true;
                lblTimerDisplay.Text = Convert.ToString(remainingTime);
                lbltypedWordProgressCounter.Visible = false;
                timerInUse = true;
            }
        }


        private void LoadTest()
        {
            display.Characters.Clear();
            List<string> lines = generator.GeneratePracticeText();
            display.NumberOfLines = lines.Count;

            typingTestManager.LoadTest(lines, display);

            display.Characters[0].State = CharacterState.Current; // colours the first character blue
            keyboardVisualiserControl1.SetKeyColour(display.Characters[currentIndex].Character, null);

            display.MakeDisplayReady();
            totalWords = display.TotalWords;
            UpdateProgressLabel();

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

        private void PracticeTestPage_KeyPress(object? sender, KeyPressEventArgs e) // method which reacts to each keypress
        {
            if (currentIndex == 0)
            {
                typingTestManager.StartTiming();
                totalTypingTimeStopwatch.Start();
                typedWords = 0;

                if (timerInUse)
                {
                    testTimer.Start();
                }
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
                btnContinuePracticeTest.Visible = true;
                typedWords++;
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

        private void btnContinuePracticeTest_Click(object sender, EventArgs e)
        {
            display.Characters.Clear();
            currentIndex = 0;
            btnContinuePracticeTest.Visible = false;
            display.CurrentLine = 0;

            totalTestSeconds = totalTypingTimeStopwatch.Elapsed.TotalSeconds;
            hesitationAnalyser.AnalyseHesitaton(typingTestManager.timings);
            PerformanceAnalyser performanceAnalyser = new PerformanceAnalyser(this, hesitationAnalyser, typingTestManager);

            Controls.Remove(display);
            lbltypedWordProgressCounter.Visible = false;
            lblTimerDisplay.Visible = false;
            keyboardPanel.Visible = false;
            testFinished = true;
        }


        private void testTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;

            lblTimerDisplay.Text = TimeSpan.FromSeconds(remainingTime).ToString("ss");

            if (remainingTime <= 0)
            {
                testTimer.Stop();
                typingTestManager.StopTiming();
                totalTypingTimeStopwatch.Stop();
                testFinished = true;
                btnContinuePracticeTest.Visible = true;
                typedWords++;
            }

        }
    }
}
