using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Algorithms.WordAnalysis
{
    internal class WordBigramsSorter
    {
        public Dictionary<string, int> PossibleBigramsDictionary { get; set; }

        public WordBigramsSorter()
        {
            PossibleBigramsDictionary = new Dictionary<string, int>();
        }

        public void AddWordBigrams(Word word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                string bigram = word.Text.Substring(i, 2);

                if (PossibleBigramsDictionary.ContainsKey(bigram))
                {
                    PossibleBigramsDictionary[bigram]++;
                }
                else
                {
                    PossibleBigramsDictionary.Add(bigram, 1);
                }
            }
        }
    }
}
