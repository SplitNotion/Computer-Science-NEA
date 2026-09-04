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

        public PerformanceAnalyser(BaselineTestPage baselineTestPage)
        {
            incorrectCounter = baselineTestPage.incorrectCounter;
            totalCharactersCount = baselineTestPage.totalCharacters;
            totalCharacterAttempts = baselineTestPage.totalCharacterAttempts;
            totalWords = baselineTestPage.totalWords;
        }

        public void AnalyseTest()
        {
            double testAccuracy = ((totalCharactersCount - (double)incorrectCounter) / totalCharacterAttempts) * 100;
            testAccuracy = Math.Round(testAccuracy, 2);

        }

    }
}
