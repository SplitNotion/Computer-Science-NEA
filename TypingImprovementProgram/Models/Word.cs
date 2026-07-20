using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Algorithms.WordAnalysis;

namespace TypingImprovementProgram.Models
{
    internal class Word
    {
        public string Text { get; set; }
        public int Length { get; set; }
        public Dictionary<char, int> LetterFrequency { get; set; }
        public WordDifficulty Difficulty { get; set; }


        public override string ToString()
        {
            string output = "";

            output += $"Word: {Text}\n";
            output += $"Length: {Length}\n";

            output += $"Word Score: {(int)Difficulty.TotalScore}\n";
            output += "Letter Frequency:\n";

            foreach (var letter in LetterFrequency)
            {
                output += $"{letter.Key}: {letter.Value}\n";
            }

            return output;
        }

    }
}
