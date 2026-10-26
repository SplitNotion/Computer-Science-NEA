using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Forms.SetupPages;

namespace TypingImprovementProgram.Algorithms.TestAnalysis
{
    internal class PerformanceAnalyser
    {
        private int incorrectCounter;
        private int totalCharactersCount;
        private int totalCharacterAttempts;
        private int totalWords;

        private List<char> hesitatedLetters = new List<char>();
        private List<string> hesitatedBigrams = new List<string>();

        public PerformanceAnalyser(BaselineTestPage baselineTestPage, HesitationAnalyser hesitationAnalyser)
        {
            incorrectCounter = baselineTestPage.incorrectCounter;
            totalCharactersCount = baselineTestPage.totalCharacters;
            totalCharacterAttempts = baselineTestPage.totalCharacterAttempts;
            totalWords = baselineTestPage.totalWords;

            hesitatedLetters = hesitationAnalyser.hesitatedLetters;
            hesitatedBigrams = hesitationAnalyser.hesitatedBigrams;
        }

        public void AnalyseTest()
        {
            double testAccuracy = ((totalCharactersCount - (double)incorrectCounter) / totalCharacterAttempts) * 100;
            testAccuracy = Math.Round(testAccuracy, 2);
        }

        public void MistakeAnalyser(Dictionary<char, int> incorrectLetters, Dictionary<string, int> incorrectBigrams)
        {
            int test = 3;


        }

    }
}
