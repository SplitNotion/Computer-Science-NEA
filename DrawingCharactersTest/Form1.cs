using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingCharactersTest
{
    public partial class Form1 : Form
    {
        TypingDisplay display = new TypingDisplay();

        int currentIndex = 0;


        public Form1()
        {
            InitializeComponent();                 // following lines dictate where display is located on page and its size, then adds it

            KeyPreview = true;

            display.Location = new Point(20, 20);

            display.Size = new Size(2000, 100);


            Controls.Add(display);



            string text = "The quick brown fox jumps over the lazy dog"; // string to draw/write


            foreach (char c in text)
            {
                display.Characters.Add(new DisplayCharacter{Character = c}); // adds a new char object to the list
            }


            display.Characters[0].State = CharacterState.Current; // colours the first character blue


            display.Invalidate(); // calls to redraw (e.g. OnPaint method)


            KeyPress += Form1_KeyPress; // calls key press method
        }



        private void Form1_KeyPress(object? sender, KeyPressEventArgs e) // method which reacts to each keypress
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