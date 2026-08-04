using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingCharactersTest
{
    public class TypingDisplay : Control
    {
        public List<DisplayCharacter> Characters { get; set; } = new List<DisplayCharacter>(); // stores each character being displayed as a list

        public TypingDisplay()
        {
            DoubleBuffered = true; // stops flickering, draws everything onto the screen at once

            Font = new Font("Consolas", 24); // sets font

            BackColor = Color.White; // sets colour of background
        }

        protected override void OnPaint(PaintEventArgs e) // is called automatically when control needs repainting
        {
            base.OnPaint(e);

            float x = 20;
            float y = 20;


            foreach (DisplayCharacter character in Characters) // goes through each character at a time
            {
                Brush brush = Brushes.Gray; // assume each char is initially grey

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
                    case CharacterState.Correct:
                        brush = Brushes.Green;
                        break;

                    case CharacterState.Incorrect:
                        brush = Brushes.Red;
                        break;

                    case CharacterState.Current:
                        brush = Brushes.Blue;
                        break;
                }
     

                e.Graphics.DrawString(                   // draws the character
                    character.Character.ToString(),
                    Font,
                    brush,
                    x,
                    y
                );

                // SizeF is a class which measures the width and height of a character. MeasureString measures these values from a character of a specified font + size.

                SizeF size = e.Graphics.MeasureString(character.Character.ToString(), Font);
                if (character.Character == ' ')
                {
                    x += size.Width + 10; // increases gap for space
                }
                else
                {
                    x += size.Width - 10; // decreases gap between letters
                }
            }
        }
    }
}
