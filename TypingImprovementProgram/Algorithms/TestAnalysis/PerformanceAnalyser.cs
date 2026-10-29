using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Forms.SetupPages;
using TypingImprovementProgram.Models;

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
        private int userID = 0;
        private bool isBaselineCompleted = false;
        private string testNote = "";
        private double totalSeconds;

        private Dictionary<char, int> letterOpportunities = new Dictionary<char, int>();
        private Dictionary<string, int> bigramOpportunities = new Dictionary<string, int>();
        private List<char> hesitatedLetters = new List<char>();
        private List<string> hesitatedBigrams = new List<string>();
        private Dictionary<char, int> incorrectLetters = new Dictionary<char, int>();
        private Dictionary<string, int> incorrectBigrams = new Dictionary<string, int>();

        public Dictionary<char, (double, bool)> problemLetters { get; private set; } = new Dictionary<char, (double, bool)>();
        public Dictionary<string, (double, bool)> problemBigrams { get; private set; } = new Dictionary<string, (double, bool)>();
        public bool isBaselineTest { get; private set; }


       
        private Dictionary<string, double> testLetters = new Dictionary<string, double>(); // can delete once problem boundary multipliers are finalised

        public PerformanceAnalyser(BaselineTestPage baselineTestPage, HesitationAnalyser hesitationAnalyser)
        {
            incorrectCounter = baselineTestPage.incorrectCounter;
            totalCharactersCount = baselineTestPage.totalCharacters;
            totalCharacterAttempts = baselineTestPage.totalCharacterAttempts;
            totalWords = baselineTestPage.totalBaselineWords;
            letterOpportunities = baselineTestPage.letterOpportunities;
            bigramOpportunities = baselineTestPage.bigramOpportunities;
            userID = baselineTestPage.userID;
            isBaselineCompleted = baselineTestPage.isBaselineCompleted;

            totalSeconds = baselineTestPage.totalTestSeconds;

            hesitatedLetters = hesitationAnalyser.hesitatedLetters;
            hesitatedBigrams = hesitationAnalyser.hesitatedBigrams;

            incorrectLetters = baselineTestPage.incorrectLetters;
            incorrectBigrams = baselineTestPage.incorrectBigrams;

            AnalyseTest();
        }

        public void AnalyseTest()
        {

            double testAccuracy = ((totalCharacterAttempts - (double)incorrectCounter) / totalCharacterAttempts) * 100;
            testAccuracy = Math.Round(testAccuracy, 2);

            double WPM = totalWords / (totalSeconds / 60);
            WPM = Math.Round(WPM, 1);


            // Adds total weighting for letters in test
            Dictionary<char, int> letterWeighting = new Dictionary<char, int>(incorrectLetters);  

            //foreach (char letter in hesitatedLetters)
            //{
            //    if (letterWeighting.ContainsKey(letter))
            //    {
            //        letterWeighting[letter]++;
            //    }
            //    else
            //    {
            //        letterWeighting.Add(letter, 1);
            //    }
            //}

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

            //foreach (string bigram in hesitatedBigrams)
            //{
            //    if (bigramWeighting.ContainsKey(bigram))
            //    {
            //        bigramWeighting[bigram]++;
            //    }
            //    else
            //    {
            //        bigramWeighting.Add(bigram, 1);
            //    }
            //}

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

            // defines whether each test record in database relates to a baseline test or user practice test
            if (isBaselineCompleted)
            {
                testNote = "Practice Test";
            }
            else
            {
                testNote = "Baseline Test";
            }

            // initialises all test data to be saved after data is analysed and finalised
            TestSaver testSaver = new TestSaver(this);
            testSaver.SaveTest(userID, testNote, (int)WPM, (int)testAccuracy);
            
        }
    }
}
