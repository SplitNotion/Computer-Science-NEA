using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Database;

namespace TypingImprovementProgram.Algorithms.TestGeneration
{
    internal class PracticeTestGenerator
    {
        private Dictionary<char, (double errorRate, bool hesitation)> problemLetters = new Dictionary<char, (double, bool)>();
        private Dictionary<string, (double errorRate, bool hesitation)> problemBigrams = new Dictionary<string, (double, bool)>();


        public PracticeTestGenerator()
        {

        }


        public void GetLatestUserData(int userID)
        {
            DatabaseManager databaseManager = new DatabaseManager();
            (problemLetters, problemBigrams) = databaseManager.GetLatestUserLetterBigramProblems(userID);

            int test = 4;
        }

        public void GeneratePracticeTest()
        {

        }


        //public List<string> GeneratePracticeText()
        //{

        //    List<string> linesTest = new List<string>();

        //    int startIndex = testNumber * 36;

        //    for (int line = 0; line < 4; line++)
        //    {
        //        List<string> tempWordList = new List<string>();

        //        for (int i = 0; i < 9; i++)
        //        {
        //            tempWordList.Add(shuffledBaselineWords[startIndex + line * 9 + i]);
        //        }

        //        string tempSentence = string.Join(" ", tempWordList);

        //        if (line != 3)
        //        {
        //            tempSentence += " ";
        //        }

        //        linesTest.Add(tempSentence);
        //    }


        //    return linesTest;

        //}


    }
}
