using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Database;

namespace TypingImprovementProgram.Algorithms.TestAnalysis
{
    internal class TestSaver
    {
        DatabaseManager databaseManager = new DatabaseManager();

        private Dictionary<char, (double, bool)> problemLetters = new Dictionary<char, (double, bool)>();
        private Dictionary<string, (double, bool)> problemBigrams = new Dictionary<string, (double, bool)>();


        public TestSaver(PerformanceAnalyser performanceAnalyser)
        {
            problemLetters.Clear();
            problemBigrams.Clear();

            problemLetters = performanceAnalyser.problemLetters;
            problemBigrams = performanceAnalyser.problemBigrams;
        }

        public int SaveTest(int userID, string testNote, int WPM, int testAccuracy)
        {
            return databaseManager.SaveTestResults(userID, testNote, WPM, testAccuracy, problemLetters, problemBigrams);
        }

    }
}
