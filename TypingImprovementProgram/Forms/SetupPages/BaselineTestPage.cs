using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Forms.SetupPages
{
    public partial class BaselineTestPage : UserControl
    {
        TypingDisplayControl display = new TypingDisplayControl();

        int currentIndex = 0;

        public BaselineTestPage()
        {
            InitializeComponent();

            display.Location = new Point(20, 20);

            display.Size = new Size(1000, 100);

            TabStop = true;

            Controls.Add(display);

            string text = "The quick brown fox jumps over the lazy dog"; // string to draw/write


            foreach (char c in text)
            {
                display.Characters.Add(new DisplayCharacter { Character = c }); // adds a new char object to the list
            }


            display.Characters[0].State = CharacterState.Current; // colours the first character blue


            display.Invalidate(); // calls to redraw (e.g. OnPaint method)


            KeyPress += BaselineTestPage_KeyPress; // calls key press method


        }

        private void BaselineTestPage_KeyPress(object? sender, KeyPressEventArgs e) // method which reacts to each keypress
        {

            if (currentIndex >= display.Characters.Count)
                return; // stops method


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


            if (currentIndex < display.Characters.Count)
            {
                display.Characters[currentIndex].State = CharacterState.Current;
            }

            display.Invalidate();
        }

    }
}
