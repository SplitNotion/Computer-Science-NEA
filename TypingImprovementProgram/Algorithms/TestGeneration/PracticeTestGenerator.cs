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
        DatabaseManager databaseManager = new DatabaseManager();
        Random random = new Random();

        public PracticeTestGenerator()
        {

        }


        public void GetLatestUserData(int userID)
        {

            (problemLetters, problemBigrams) = databaseManager.GetLatestUserLetterBigramProblems(userID);

            int test = 4;

            ChooseBigrams(problemBigrams);

        }

        private void ChooseBigrams(Dictionary<string, (double errorRate, bool hesitation)> problemBigrams)
        {
            double usageWeight;
            List<string> chosenBigrams = new List<string>();
            List<string> possibleWords = new List<string>();
            List<string> shuffledPossibleWords = new List<string>();
            List<string> usingWords = new List<string>();

            foreach (var bigram in problemBigrams)
            {
                usageWeight = bigram.Value.errorRate;

                if (usageWeight > 0.4 || bigram.Value.hesitation)
                {
                    chosenBigrams.Add(bigram.Key);
                }
            }
            

            foreach (string bigram in chosenBigrams)
            {
                possibleWords = databaseManager.GetWordsFromChosenBigrams(bigram);
                shuffledPossibleWords = possibleWords.OrderBy(x => random.Next()).ToList();

                for (int i = 0; i < 3; i++)
                {
                    usingWords.Add(shuffledPossibleWords[i]);
                }
            }

            List<string> remainingWords = databaseManager.GetRemainingRandomWords(20);
            usingWords.AddRange(remainingWords);

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
