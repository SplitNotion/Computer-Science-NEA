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


        protected override void OnPaint(PaintEventArgs e) // is called automatically when control needs repainting
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

            float maxWidth = 1430;

            CheckLineWidth(e.Graphics, CurrentLine, maxWidth);
            CheckLineWidth(e.Graphics, CurrentLine + 1, maxWidth);
            CheckLineWidth(e.Graphics, CurrentLine + 2, maxWidth);

            foreach (DisplayCharacter character in Characters)
            {

                if (character.Line < CurrentLine || character.Line > CurrentLine + 2)
                {
                    continue;
                }

                if (character.Line == CurrentLine + 1 && !secondLineStarted)
                {
                    x = 20;
                    y = 74;

                    secondLineStarted = true;
                }

                else if (character.Line == CurrentLine + 2 && !thirdLineStarted)
                {
                    x = 20;
                    y = 128;

                    thirdLineStarted = true;
                }

                    Brush brush = Brushes.Gray;

                if ((character.State == CharacterState.Current) && (character.Character != ' '))  // caret jumps after each character
                {
                    e.Graphics.FillRectangle(
                        Brushes.Black,
                        x + 7,
                        y,
                        2,
                        FontHeight);
                }

                else if ((character.State == CharacterState.Current) && (character.Character == ' '))   // caret stays before space
                {
                    e.Graphics.FillRectangle(
                        Brushes.Black,  // colour
                        x + 4,          // x
                        y,              // y
                        2,              // width
                        FontHeight);    // height
                }

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

                e.Graphics.DrawString(                      // draws the character
                    character.Character.ToString(),
                    Font,
                    brush,
                    x,
                    y);

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
    }
}
