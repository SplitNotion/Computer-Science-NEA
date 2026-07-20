using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TypingImprovementProgram.Algorithms.WordAnalysis
{
    internal class FingerMapping
    {
        public static Dictionary<char, Finger> Fingers { get; } = new Dictionary<char, Finger>()
    {
        {'q', Finger.LeftPinky },
        {'a', Finger.LeftPinky },
        {'z', Finger.LeftPinky },

        {'s', Finger.LeftRing },
        {'w', Finger.LeftRing },
        {'x', Finger.LeftRing },

        {'d', Finger.LeftMiddle },
        {'e', Finger.LeftMiddle },
        {'c', Finger.LeftMiddle },

        {'f', Finger.LeftIndex },
        {'r', Finger.LeftIndex },
        {'v', Finger.LeftIndex },
        {'g', Finger.LeftIndex },
        {'t', Finger.LeftIndex },
        {'b', Finger.LeftIndex },

        {'j', Finger.RightIndex },
        {'u', Finger.RightIndex },
        {'m', Finger.RightIndex },
        {'h', Finger.RightIndex },
        {'y', Finger.RightIndex },
        {'n', Finger.RightIndex },

        {'k', Finger.RightMiddle },
        {'i', Finger.RightMiddle },

        {'l', Finger.RightRing },
        {'o', Finger.RightRing },

        {'p', Finger.RightPinky }
    };

        public static Hand GetHand(Finger Fingers)
        {
            return Fingers switch
            {
                Finger.LeftPinky or
                Finger.LeftRing or
                Finger.LeftMiddle or
                Finger.LeftIndex => Hand.Left,

                Finger.RightIndex or
                Finger.RightMiddle or
                Finger.RightRing or
                Finger.RightPinky => Hand.Right
            };
        }

        public static Dictionary<char, int> rareCharacters = new Dictionary<char, int>()
    {
        {'z', 6 },
        {'q', 5 },
        {'x', 5 },
        {'j', 3 },
        {'k', 2 },
        {'v', 2 }
    };


    }
}
