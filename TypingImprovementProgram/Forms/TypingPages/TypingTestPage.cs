using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingImprovementProgram.Forms.SetupPages;
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Forms.TypingPages
{
    public partial class TypingTestPage : UserControl
    {
        private TypingDisplayControl display = new TypingDisplayControl();

        private bool testFinished = false;

        public int incorrectCounter { get; set; }
        public int totalCharacters { get; set; }
        public int totalCharacterAttempts { get; set; }
        public int totalWords { get; set; }
        public int typedWords { get; set; }

        public Dictionary<char, int> incorrectLetters = new Dictionary<char, int>();
        public Dictionary<string, int> incorrectBigrams = new Dictionary<string, int>();

        public Dictionary<char, int> letterOpportunities = new Dictionary<char, int>();
        public Dictionary<string, int> bigramOpportunities = new Dictionary<string, int>();

        private int currentIndex = 0;

        private Stopwatch stopwatch = new Stopwatch();

        public List<KeystrokeTiming> timings { get; set; } = new List<KeystrokeTiming>();

        private TimeSpan previousKeyTime = TimeSpan.Zero;

        public double totalTestSeconds = 0.0;

        public TypingTestPage()
        {
            InitializeComponent();

            display.Location = new Point(30, 250);
            display.Size = new Size(1450, 200);

            TabStop = true;

            Controls.Add(display);

            KeyPress += TypingTestPage_KeyPress;
        }
    }
}
