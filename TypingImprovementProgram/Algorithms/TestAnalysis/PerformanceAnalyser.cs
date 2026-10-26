using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Forms.SetupPages;

namespace TypingImprovementProgram.Algorithms.TestAnalysis
{
    // this class is the final 'stepping stone' for assigning the user with personalised problem letters and bigrams.
    // After the data passes through this class, then we are left with two dictionaries containing all the problem letters and bigrams, to be sent to the user's database table.
    internal class PerformanceAnalyser 
    {
        private int incorrectCounter;
        private int totalCharactersCount;
        private int totalCharacterAttempts;
        private int totalWords;

        private Dictionary<char, int> letterOpportunities = new Dictionary<char, int>();
        private List<char> hesitatedLetters = new List<char>();
        private List<string> hesitatedBigrams = new List<string>();
        private Dictionary<char, int> incorrectLetters = new Dictionary<char, int>();
        private Dictionary<string, int> incorrectBigrams = new Dictionary<string, int>();

        private Dictionary<char, int> problemLetters = new Dictionary<char, int>();
        private Dictionary<string, int> problemBigrams = new Dictionary<string, int>();
        


        public PerformanceAnalyser(BaselineTestPage baselineTestPage, HesitationAnalyser hesitationAnalyser)
        {
            incorrectCounter = baselineTestPage.incorrectCounter;
            totalCharactersCount = baselineTestPage.totalCharacters;
            totalCharacterAttempts = baselineTestPage.totalCharacterAttempts;
            totalWords = baselineTestPage.totalWords;
            letterOpportunities = baselineTestPage.letterOpportunities;

            hesitatedLetters = hesitationAnalyser.hesitatedLetters;
            hesitatedBigrams = hesitationAnalyser.hesitatedBigrams;

            incorrectLetters = baselineTestPage.incorrectLetters;
            incorrectBigrams = baselineTestPage.incorrectBigrams;

            AnalyseTest();
        }

        public void AnalyseTest()
        {
            double testAccuracy = ((totalCharactersCount - (double)incorrectCounter) / totalCharacterAttempts) * 100;
            testAccuracy = Math.Round(testAccuracy, 2);


            // Adds total weighting for letters in test
            Dictionary<char, int> letterWeighting = new Dictionary<char, int>(incorrectLetters);  

            foreach (char letter in hesitatedLetters)
            {
                if (letterWeighting.ContainsKey(letter))
                {
                    letterWeighting[letter]++;
                }
                else
                {
                    letterWeighting.Add(letter, 1);
                }
            }

            foreach (var item in letterOpportunities)
            {
                char letter = item.Key;
                int opportunities = item.Value;

                if (opportunities < 5)
                {
                    continue;
                }

                int errors = incorrectLetters.ContainsKey(letter) ? incorrectLetters[letter] : 0;
                double errorRate = (double)errors / opportunities;

                double totalScore = 0.7 * errorRate;

            }



            // Adds total weighting for bigrams in test
            Dictionary<string, int> bigramWeighting = new Dictionary<string, int>(incorrectBigrams); 

            foreach (string bigram in hesitatedBigrams)
            {
                if (bigramWeighting.ContainsKey(bigram))
                {
                    bigramWeighting[bigram]++;
                }
                else
                {
                    bigramWeighting.Add(bigram, 1);
                }
            }

            int x = 3;

        }
    }
}
