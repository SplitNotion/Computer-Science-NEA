using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Forms.SetupPages
{
    public class TypingDisplayControl : Control
    {
        public List<DisplayCharacter> Characters { get; set; } = new List<DisplayCharacter>(); // stores each character being displayed as a list
        public int CurrentLine { get; set; }
        public int TotalCharacters => Characters.Count;
        public int TotalWords { get; private set; }

        public TypingDisplayControl()
        {
            DoubleBuffered = true; // stops flickering, draws everything onto the screen at once

            TabStop = false;
            Font = new Font("Consolas", 30); // sets font

            BackColor = Color.White; // sets colour of background to white
        }

        #region OverflowPreventionFunctions
        private void CheckLineWidth(Graphics graphics, int lineNumber, float maxWidth)
        {
            List<DisplayCharacter> lineCharacters = Characters.Where(c => c.Line == lineNumber).ToList();


            while (CalculateLineWidth(graphics, lineCharacters) > maxWidth)
            {
                RemoveLastWord(lineCharacters);
            }

            foreach (DisplayCharacter character in Characters.Where(c => c.Line == lineNumber).ToList())
            {
                if (!lineCharacters.Contains(character))
                {
                    Characters.Remove(character);
                }
            };

        }

        private float CalculateLineWidth(Graphics graphics, List<DisplayCharacter> characters)
        {
            float width = 0;

            foreach (DisplayCharacter character in characters)
            {
                SizeF size = graphics.MeasureString(character.Character.ToString(), Font);

                if (character.Character == ' ')
                {
                    width += size.Width + 8;
                }
                else
                {
                    width += size.Width - 14;
                }
            }
            return width;
        }

        private void RemoveLastWord(List<DisplayCharacter> characters)
        {
            if (characters.Last().Character == ' ')
            {
                characters.RemoveAt(characters.Count - 1);
            }

            while ((characters.Count > 0) && characters.Last().Character != ' ')
            {
                characters.RemoveAt(characters.Count - 1);
            }

        }
        #endregion


        // Method which calls the Overflow Prevention Functions, and then gets total word count
        public void MakeDisplayReady()
        {
            using (Graphics graphics = CreateGraphics())
            {
                float maxWidth = 1430;

                CheckLineWidth(graphics, CurrentLine, maxWidth);
                CheckLineWidth(graphics, CurrentLine + 1, maxWidth);
                CheckLineWidth(graphics, CurrentLine + 2, maxWidth);
                CheckLineWidth(graphics, CurrentLine + 3, maxWidth);

                TotalWords = GetTotalWordCount();
            }
            Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e) // is called automatically when control needs repainting - does not happen immediately, hence separate MakeDisplayReady() method
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(Color.Black, 3))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }

            float x = 20; // moves text left/right on control
            float y = 20; // moves text up/down on control

            bool secondLineStarted = false;
            bool thirdLineStarted = false;

            foreach (DisplayCharacter character in Characters)
            {
                // Ignore characters which are on a previous line, or a few lines ahead
                if (character.Line < CurrentLine || character.Line > CurrentLine + 2)
                {
                    continue;
                }

                // begin second line if next character is on next line, and new line has not already been started
                if (character.Line == CurrentLine + 1 && !secondLineStarted)
                {
                    x = 20;
                    y = 74;

                    secondLineStarted = true;
                }

                // begin third line if next character is on next line, and new line has not already been started
                else if (character.Line == CurrentLine + 2 && !thirdLineStarted)
                {
                    x = 20;
                    y = 128;

                    thirdLineStarted = true;
                }

                Brush brush = Brushes.Gray;


                // caret jumps after each character
                if ((character.State == CharacterState.Current) && (character.Character != ' '))  
                {
                    e.Graphics.FillRectangle(
                        Brushes.Black,
                        x + 7,
                        y,
                        2,
                        FontHeight);
                }

                // caret stays before space
                else if ((character.State == CharacterState.Current) && (character.Character == ' '))   
                {
                    e.Graphics.FillRectangle(
                        Brushes.Black,  // colour
                        x + 4,          // x
                        y,              // y
                        2,              // width
                        FontHeight);    // height
                }


                // manages character colours based on state
                switch (character.State)
                {
                    case CharacterState.Current:
                        brush = Brushes.Blue;
                        break;

                    case CharacterState.Correct:
                        brush = Brushes.Green;
                        break;

                    case CharacterState.Incorrect:
                        brush = Brushes.Red;
                        break;

                    default:
                        brush = Brushes.Gray;
                        break;
                }


                // draws the character
                e.Graphics.DrawString(                      
                    character.Character.ToString(),
                    Font,
                    brush,
                    x,
                    y);

                // measures the length of each character
                SizeF size = e.Graphics.MeasureString(character.Character.ToString(), Font);
                if (character.Character == ' ')
                {
                    x += size.Width + 8;                  // increases gap for space
                }
                else
                {
                    x += size.Width - 14;                  // decreases gap between letters
                }
            }
        }

        private int GetTotalWordCount()
        {
            int totalWords = 0;

            if (Characters[Characters.Count - 1].Character == ' ')
            {
                totalWords--;
            } 

            foreach (DisplayCharacter character in Characters)
            {
                if (character.Character == ' ')
                {
                    totalWords++;
                }
            }
            return totalWords + 1;
        }


    }
}
