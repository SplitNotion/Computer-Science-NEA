using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TypingImprovementProgram.Models
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

        public static Dictionary<char, (double X, double Y)> KeyPositions = new()
        {
            ['q'] = (0, 0),
            ['w'] = (1, 0),
            ['e'] = (2, 0),
            ['r'] = (3, 0),
            ['t'] = (4, 0),
            ['y'] = (5, 0),
            ['u'] = (6, 0),
            ['i'] = (7, 0),
            ['o'] = (8, 0),
            ['p'] = (9, 0),

            ['a'] = (0.5, 1),
            ['s'] = (1.5, 1),
            ['d'] = (2.5, 1),
            ['f'] = (3.5, 1),
            ['g'] = (4.5, 1),
            ['h'] = (5.5, 1),
            ['j'] = (6.5, 1),
            ['k'] = (7.5, 1),
            ['l'] = (8.5, 1),

            ['z'] = (1, 2),
            ['x'] = (2, 2),
            ['c'] = (3, 2),
            ['v'] = (4, 2),
            ['b'] = (5, 2),
            ['n'] = (6, 2),
            ['m'] = (7, 2)
        };

    }
}
