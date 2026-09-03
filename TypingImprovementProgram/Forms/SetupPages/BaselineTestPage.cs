using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingImprovementProgram.Algorithms.TestAnalysis;
using TypingImprovementProgram.Algorithms.TestGeneration;
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Forms.SetupPages
{
    public partial class BaselineTestPage : UserControl
    {
        TypingDisplayControl display = new TypingDisplayControl();
        BaselineTestGenerator generator = new BaselineTestGenerator();
        UserPerformanceAnalyser performanceAnalyser;


        bool testFinished = false;
        public int incorrectCounter { get; set; }
        public int totalCharacters { get; set; }
        public int totalCharacterAttempts { get; set; }
        public int totalWords { get; set; }
        public int typedWords { get; set; }


        int currentIndex = 0;

        public BaselineTestPage()  // this initialises the typing display control, including its dimensions and position
        {
            InitializeComponent();

            // this.BackColor = Color.FromArgb(20, 32, 45);

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

            for (int i = 0; i < lines.Count; i++)
            {
                foreach (char c in lines[i])
                {
                    display.Characters.Add(new DisplayCharacter { Character = c, Line = i }); // adds a new char object to the list
                }
            }

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

        private void BaselineTestPage_KeyPress(object? sender, KeyPressEventArgs e) // method which reacts to each keypress
        {
            totalCharacterAttempts++;
            char? incorrectCharacter = null;

            if (testFinished)
            {
                return;
            }

            if (e.KeyChar == (char)Keys.Back)                     // allows for backspace, disallowing over space between words
            {
                if (currentIndex > 0)
                {
                    if (display.Characters[currentIndex - 1].Character != ' ')
                    {
                        display.Characters[currentIndex].State = CharacterState.Untyped;
                        display.Characters[currentIndex - 1].State = CharacterState.Current;
                        currentIndex--;

                        if (currentIndex > 0 && display.Characters[currentIndex - 1].State  == CharacterState.Incorrect)
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


            if (e.KeyChar == display.Characters[currentIndex].Character)                  // if keypress is same as char on screen
            {
                display.Characters[currentIndex].State = CharacterState.Correct;          // make correct
            }

            else
            {
                display.Characters[currentIndex].State = CharacterState.Incorrect;        // make incorrect
                incorrectCharacter = display.Characters[currentIndex].Character;
                incorrectCounter += 1;
            }

            currentIndex++;

            if (currentIndex >= display.Characters.Count)  // event for end of test
            {
                testFinished = true;
                btnContinueBaselineTest.Visible = true;
                typedWords++;
                UpdateProgressLabel();
            }

            if (currentIndex < display.Characters.Count)
            {
                display.Characters[currentIndex].State = CharacterState.Current;
                keyboardVisualiserControl1.SetKeyColour(display.Characters[currentIndex].Character, incorrectCharacter);

                if (display.Characters[currentIndex - 1].Character == ' ')
                {
                    typedWords++;
                    lbltypedWordProgressCounter.Text = typedWords + "/" + totalWords;
                }

                if (display.Characters[currentIndex].Line > display.CurrentLine + 1)     // shifts all text lines up when second row is completed
                {
                    display.CurrentLine++;
                }
            }

            display.Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnContinueBaselineTest_Click(object sender, EventArgs e)
        {

            if (performanceAnalyser == null)
            {
                performanceAnalyser = new UserPerformanceAnalyser(this);
            }
            performanceAnalyser.AnalyseTest();

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
                UpdateProgressLabel();
            }
            else
            {
                Controls.Remove(display);
                //keyboardPanel.Controls.Remove(keyboardVisualiserControl1);
                keyboardPanel.Visible = false;
                testFinished = true;
            }
        }

    }
}
