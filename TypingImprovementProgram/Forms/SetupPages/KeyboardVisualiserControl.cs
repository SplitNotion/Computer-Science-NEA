using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingImprovementProgram.Forms.SetupPages
{
    public partial class KeyboardVisualiserControl : UserControl
    {
        private List<KeyboardKey> keys = new List<KeyboardKey>();

        public KeyboardVisualiserControl()
        {
            InitializeComponent();
            this.Font = new Font("Arial", 24);
            CreateKeyboard();
        }

        private void CreateKeyboard()
        {
            keys.Clear();   // deletes keys to be redrawn if resized

            //int keyWidth = 45;
            //int keyHeight = 45;
            int gap = 5;

            int availableWidth = (Width - 30) - (9 * gap);
            int keyWidth = (availableWidth) / 10;

            int keyHeight = keyWidth - 20;

            string[] rows =
            { 
              "QWERTYUIOP",
              "ASDFGHJKL",
              "ZXCVBNM,."
            };

            for (int row = 0; row < rows.Length; row++)  // loops through rows
            {
                for (int column = 0; column < rows[row].Length; column++)  // loops through each character in each row
                {
                    int x = 15 + column * (keyWidth + gap);
                    int y = (row * (keyHeight + gap)) + 25;

                    if (row == 1)
                    {
                        x += (int)Math.Round(((keyWidth + gap) * 0.25));
                    }

                    else if (row == 2)
                    {
                        x += (int)Math.Round(((keyWidth + gap) * 0.75));
                    }


                    Rectangle rectangle = new Rectangle (
                        x,
                        y,
                        keyWidth, 
                        keyHeight);

                    keys.Add(new KeyboardKey(rows[row][column].ToString(), rectangle));
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            //using (Pen pen = new Pen(Color.Black, 3))
            //{
            //    e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            //}

            foreach (KeyboardKey key in keys)
            {
                using (Brush brush = new SolidBrush(Color.LightGray))
                {
                    g.FillRectangle(brush, key.Bounds);
                }

                using (Pen pen = new Pen(Color.Black))
                {
                    g.DrawRectangle(pen, key.Bounds);
                }

                using (Brush textBrush = new SolidBrush(Color.Black))
                {
                    StringFormat stringFormat = new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center,
                    };

                    g.DrawString(key.Text, Font, textBrush, key.Bounds, stringFormat);
                }
                
            }
        }



    }

    public class KeyboardKey
    {
        public string Text { get; set; }
        public Rectangle Bounds { get; set; }

        public KeyboardKey(string text, Rectangle bounds)
        {
            Text = text;
            Bounds = bounds;
        }
    }


}
