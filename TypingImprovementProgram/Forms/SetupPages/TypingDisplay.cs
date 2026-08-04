using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Forms.SetupPages
{
    public class TypingDisplay : Control
    {
        public List<DisplayCharacter> Characters { get; set; } = new List<DisplayCharacter>(); // stores each character being displayed as a list
        public TypingDisplay()
        {
            DoubleBuffered = true; // stops flickering, draws everything onto the screen at once

            Font = new Font("Consolas", 24); // sets font

            BackColor = Color.White; // sets colour of background to white
        }


        protected override void OnPaint(PaintEventArgs e) // is called automatically when control needs repainting
        {
            base.OnPaint(e);
            float x = 20;
            float y = 20;

            foreach (DisplayCharacter character in Characters)
            {
                Brush brush = Brushes.Gray;

                if ((character.State == CharacterState.Current) && (character.Character != ' '))  // caret jumps after each character
                {
                    e.Graphics.FillRectangle(
                        Brushes.Black,
                        x + 5,
                        y,
                        2,
                        FontHeight);
                }

                else if ((character.State == CharacterState.Current) && (character.Character == ' '))   // caret stays before space
                {
                    e.Graphics.FillRectangle(
                        Brushes.Black,
                        x + 2,
                        y,
                        2,
                        FontHeight);
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
                    x += size.Width + 10;                  // increases gap for space
                }
                else
                {
                    x += size.Width - 10;                  // decreases gap between letters
                }
            }


        }
    }
}
