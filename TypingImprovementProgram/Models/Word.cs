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
        
    }
}
