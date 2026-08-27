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
        public int testNumber = 0;
        Random random = new Random();
        private List<string> shuffledBaselineWords;

        public GenerateBaselineTest()
        {
            shuffledBaselineWords = baselineWords.OrderBy(x => random.Next()).ToList();
        }            

        private readonly List<string> baselineWords = new List<string>
        {
            "fresh", "each", "would", "about", "which", "set", "from", "post", "order",
            "group", "bug", "next", "bulk", "read", "eight", "tube", "pour", "myth",
            "ugly", "bingo", "pink", "ray", "mime", "cult", "aware", "higher", "gone",
            "void", "guilty", "wage", "start", "folk", "lift", "sandy", "brick", "bull",

            "semester", "people", "because", "pressure", "certain", "prayed", "example", "clause", "operate",
            "plasma", "spoken", "stretch", "toxic", "friends", "enable", "drain", "campus", "peace",
            "change", "flower", "urban", "leading", "assets", "jazz", "mostly", "preview", "viking",
            "grade", "swift", "medal", "destiny", "object", "survey", "achieve", "supreme", "rabbit",

            "amateur", "disassociate", "yesterday", "forgiven", "commission", "machinery", "subsitute", "arthritis", "designing",
            "backslide", "forbidden", "boulder", "asylum", "continent", "meeting", "infringement", "miniature", "algorithm",
            "technology", "absorbed", "chemical", "complicated", "village", "wellington", "pharmacy", "utilise", "unauthorised",
            "subjective", "experience", "keyboard", "language", "detailed", "disclaimer", "fundamental", "malpractice", "cellular"
        };

        public List<string> GenerateBaselineText()
        {

            List<string> linesTest = new List<string>();

            int startIndex = testNumber * 36;

            for (int line = 0; line < 4; line++)
            {
                List<string> tempWordList = new List<string>();

                for (int i = 0; i < 9; i++)
                {
                    tempWordList.Add(shuffledBaselineWords[startIndex + line * 9 + i]);
                }

                string tempSentence = string.Join(" ", tempWordList);

                if (line != 3)
                {
                    tempSentence += " ";
                }

                linesTest.Add(tempSentence);
            }

            testNumber++;

            return linesTest;

        }
    }
}
