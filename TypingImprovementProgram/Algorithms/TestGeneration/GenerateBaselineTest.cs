using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Database;

namespace TypingImprovementProgram.Algorithms.TestGeneration
{
    internal class GenerateBaselineTest
    {

        private readonly List<string> baselineWords = new List<string>
        {
            "fresh", "each", "would", "about", "which", "set", "from", "post", "order",
            "group", "bug", "next", "bulk", "read", "eight", "tube", "pour", "myth",
            "ugly", "bingo", "pink", "ray", "mime", "cult", "aware", "higher", "gone",
            "void", "guilty", "wage", "start", "folk", "lift", "sandy", "brick", "bull",

            "semester", "people", "because", "pressure", "certain", "prayed", "example", "clause", "operate",
            "plasma", "spoken", "stretch", "toxic", "friends", "enable", "claim", "campus", "peace",
            "change", "flower", "urban", "leading", "assets", "jazz", "mostly", "preview", "viking",
            "grade", "swift", "medal", "destiny", "object", "survey", "achieve", "supreme", "rabbit",

            "amateur", "disassociate", "yesterday", "forgiven", "commission", "machinery", "subsitute", "arthritis", "designing",
            "backslide", "forbidden", "boulder", "asylum", "continent", "meeting", "infringement", "miniature", "algorithm",
            "technology", "absorbed", "chemical", "complicated", "village", "wellington", "pharmacy", "utilise", "unauthorised",
            "subjective", "experience", "keyboard", "language", "detailed", "disclaimer", "fundamental", "malpractice", "cellular"
        };

        public List<string> GenerateBaselineText()
        {
            Random random = new Random();

            List<string> shuffledBaselineWords = baselineWords.OrderBy(x => random.Next()).ToList();

            List<string> linesTest = new List<string>();


            for (int line = 0; line < 4; line++)
            {
                List<string> tempWordList = new List<string>();

                for (int i = 0; i < 9; i++)
                {
                    tempWordList.Add(shuffledBaselineWords[line * 9 + i]);
                }

                string tempSentence = string.Join(" ", tempWordList);
                tempSentence += " ";

                linesTest.Add(tempSentence);
            }

            shuffledBaselineWords.RemoveRange(0, 27);

            return linesTest;

        }
    }
}
