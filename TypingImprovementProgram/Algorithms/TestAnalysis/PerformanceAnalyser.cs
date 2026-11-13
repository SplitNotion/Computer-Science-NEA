using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Forms.SetupPages;
using TypingImprovementProgram.Forms.TestPages.UniversalPages;
using TypingImprovementProgram.Interfaces;
using TypingImprovementProgram.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TypingImprovementProgram.Algorithms.TestAnalysis
{
    // This class is the final 'stepping stone' for assigning the user with personalised problem letters and bigrams.
    // After the data passes through this class, then we are left with two dictionaries containing all the problem letters and bigrams, to be sent to the user's database table.
    internal class PerformanceAnalyser
    {
        private readonly ITypingTest typingTest;

        private Dictionary<char, int> letterOpportunities = new Dictionary<char, int>();
        private Dictionary<string, int> bigramOpportunities = new Dictionary<string, int>();
        private List<char> hesitatedLetters = new List<char>();
        private List<string> hesitatedBigrams = new List<string>();
        private Dictionary<char, int> incorrectLetters = new Dictionary<char, int>();
        private Dictionary<string, int> incorrectBigrams = new Dictionary<string, int>();
        public Dictionary<char, (double, bool)> problemLetters { get; private set; } = new Dictionary<char, (double, bool)>();
        public Dictionary<string, (double, bool)> problemBigrams { get; private set; } = new Dictionary<string, (double, bool)>();

       
        private Dictionary<string, double> testLetters = new Dictionary<string, double>(); // can delete once problem boundary multipliers are finalised

        public PerformanceAnalyser(ITypingTest typingTest, HesitationAnalyser hesitationAnalyser, TypingTestManager typingTestManager)
        {
            this.typingTest = typingTest;

            hesitatedLetters = hesitationAnalyser.hesitatedLetters;
            hesitatedBigrams = hesitationAnalyser.hesitatedBigrams;

            letterOpportunities = typingTestManager.letterOpportunities;
            bigramOpportunities = typingTestManager.bigramOpportunities;
            incorrectLetters = typingTestManager.incorrectLetters;
            incorrectBigrams = typingTestManager.incorrectBigrams;

            AnalyseTest();
        }


        public void AnalyseTest()
        {
            double testAccuracy = ((typingTest.TotalCharacterAttempts - (double)typingTest.IncorrectCounter) / typingTest.TotalCharacterAttempts) * 100;
            testAccuracy = Math.Round(testAccuracy, 2);
            
            double netWPM;
            // changes WPM calculation depending on whether its part of a timed test or not
            if (typingTest.TypedWords < typingTest.TotalWords)  // timed
            {

                netWPM = (typingTest.TotalCorrectWordCharacters / 5.0) * (60.0 / typingTest.TotalTestSeconds);  // Total number of characters in correctly typed words normalised to 5 words (+ space) in 60 seconds

                netWPM = Math.Round(netWPM, 1);
            }
            else // not timed
            {
                netWPM = (typingTest.TotalCorrectWordCharacters / 5.0) * (60.0 / typingTest.TotalTestSeconds);
                netWPM = Math.Round(netWPM, 1);
            }

            // Adds total weighting for letters in test
            Dictionary<char, int> letterWeighting = new Dictionary<char, int>(incorrectLetters);  

            foreach (var item in letterOpportunities)
            {
                char letter = item.Key;
                int opportunities = item.Value;

                if (opportunities < 5 || letter == ' ')
                {
                    continue;
                }

                int errors = incorrectLetters.ContainsKey(letter) ? incorrectLetters[letter] : 0;
                double errorRate = ((double)errors / opportunities);
                bool hesitated = hesitatedLetters.Contains(letter);

                // testLetters.Add(letter, errorRate);

                if (opportunities >= 5 && (errorRate >= 0.02 && hesitated))
                {
                    problemLetters.Add(letter, (errorRate, true));
                }

                else if (opportunities >= 5 && errorRate >= 0.04)
                {
                    problemLetters.Add(letter, (errorRate, false));
                }
            }


            // Adds total weighting for bigrams in test
            Dictionary<string, int> bigramWeighting = new Dictionary<string, int>(incorrectBigrams);
            foreach (var item in bigramOpportunities)
            {
                string bigram = item.Key;
                int opportunities = item.Value;

                if (opportunities < 3 || bigram.Contains(" "))
                {
                    continue;
                }

                int errors = incorrectBigrams.ContainsKey(bigram) ? incorrectBigrams[bigram] : 0;
                double errorRate = ((double)errors / opportunities);
                bool hesitated = hesitatedBigrams.Contains(bigram);

                //testLetters.Add(bigram, errorRate);

                if (opportunities >= 3 && (errorRate >= 0.15 && hesitated))
                {
                    problemBigrams.Add(bigram, (errorRate, true));
                }

                else if (opportunities >= 3 && errorRate >= 0.25)
                {
                    problemBigrams.Add(bigram, (errorRate, false));
                }
            }

            // initialises all test data to be saved after data is analysed and finalised
            TestSaver testSaver = new TestSaver(this);
            testSaver.SaveTest(typingTest.UserID, typingTest.TestNote, (int)netWPM, (int)testAccuracy);
            
        }
    }
}
