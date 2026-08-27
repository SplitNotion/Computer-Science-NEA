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
using TypingImprovementProgram.Algorithms.TestGeneration;
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Forms.SetupPages
{
    public partial class BaselineTestPage : UserControl
    {
        TypingDisplayControl display = new TypingDisplayControl();
        bool testFinished = false;

        int currentIndex = 0;

        public BaselineTestPage()  // this initialises the typing display control, including its dimensions and position
        {
            InitializeComponent();

            btnContinueBaselineTest.Visible = false;

            GenerateBaselineTest generator = new GenerateBaselineTest();

            List<string> lines = generator.GenerateBaselineText();


            display.Location = new Point(30, 300);
            display.Size = new Size(1450, 200);
            TabStop = true;

            Controls.Add(display);


            //List<string> lines = new List<string>
            //{ 
            //    "The quick brown fox jumps over the lazy dog not to be seen ",  
            //    "through the forest towards the mountain covered with snow ",
            //    "past the river and into the cave where the fox saw ",
            //    "something he soon wished he had never ever seen"
            //};


            for (int i = 0; i < lines.Count; i++)
            {
                foreach (char c in lines[i])
                {
                    display.Characters.Add(new DisplayCharacter { Character = c, Line = i }); // adds a new char object to the list
                }
            }


            display.Characters[0].State = CharacterState.Current; // colours the first character blue


            display.Invalidate(); // calls to redraw (e.g. OnPaint method)


            KeyPress += BaselineTestPage_KeyPress; // calls key press method


        }

        private void BaselineTestPage_KeyPress(object? sender, KeyPressEventArgs e) // method which reacts to each keypress
        {
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
            }

            currentIndex++;

            if (currentIndex >= display.Characters.Count)  // event for end of test
            {
                testFinished = true;
                btnContinueBaselineTest.Visible = true;
            }

            if (currentIndex < display.Characters.Count)
            {
                display.Characters[currentIndex].State = CharacterState.Current;

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
            
        }

    }
}
