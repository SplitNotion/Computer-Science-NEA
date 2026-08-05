using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Algorithms.WordAnalysis
{
    internal class WordBigrams
    {
        public Dictionary<string, int> AllBigrams { get; set; }

        public WordBigrams()
        {
            AllBigrams = new Dictionary<string, int>();
            
        }

        public void AddWordBigrams(Word word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                string bigram = word.Text.Substring(i, 2);

                if (AllBigrams.ContainsKey(bigram))
                {
                    AllBigrams[bigram]++;
                }
                else
                {
                    AllBigrams.Add(bigram, 1);
                }
            }

            

        }
    }
}
