using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Database;
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Algorithms.TestGeneration
{
    internal class PracticeTestGenerator
    {
        private Dictionary<char, (double errorRate, bool hesitation)> problemLetters = new Dictionary<char, (double, bool)>();
        private Dictionary<string, (double errorRate, bool hesitation)> problemBigrams = new Dictionary<string, (double, bool)>();
        DatabaseManager databaseManager = new DatabaseManager();
        Random random = new Random();

        private string difficulty;
        private int testTiming;
        private int testWords;
        private int minimumDifficulty;
        private int maximumDifficulty;
        private int wordsPerLine;

        private List<String> usingWords = new List<string>();

        public PracticeTestGenerator(string difficulty, int testTiming, int testWords)
        {
            this.difficulty = difficulty; 
            this.testTiming = testTiming;
            this.testWords = testWords;

            OrganiseDifficutly(difficulty);
        }



        private void OrganiseDifficutly(string difficulty)
        {
            // 20-45, 46-65, 66-100

            switch (difficulty)
            {
                case "easy":
                    minimumDifficulty = 20;
                    maximumDifficulty = 45;
                    wordsPerLine = 10;
                    return;
                case "medium":
                    minimumDifficulty = 46;
                    maximumDifficulty = 65;
                    wordsPerLine = 7;
                    return;
                case "hard":
                    minimumDifficulty = 66; 
                    maximumDifficulty = 100;
                    wordsPerLine = 5;
                    return;
                default:
                    minimumDifficulty = 0;
                    maximumDifficulty = 100;
                    wordsPerLine = 8;
                    return;
            }
        }

        public void GetLatestUserData(int userID)
        {
            (problemLetters, problemBigrams) = databaseManager.GetLatestUserLetterBigramProblems(userID);

            ChooseBigrams(problemBigrams);

        }

        private void ChooseBigrams(Dictionary<string, (double errorRate, bool hesitation)> problemBigrams)
        {
            double usageWeight;
            List<string> chosenBigrams = new List<string>();
            List<string> possibleWords = new List<string>();
            List<string> shuffledPossibleWords = new List<string>();

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

                for (int i = 0; i < Math.Min(5, shuffledPossibleWords.Count); i++)
                {
                    if (testWords != -1)
                    {
                        if (usingWords.Count >= testWords * 0.6)
                        {
                            break;
                        }
                        break;
                    }

                    else if (usingWords.Count >= random.Next(20, 35))
                    {
                        break;
                    }

                    if (!usingWords.Contains(shuffledPossibleWords[i]))
                    {
                       usingWords.Add(shuffledPossibleWords[i]);
                    }
                }

                if (testWords != -1)
                {
                    if (usingWords.Count >= testWords * 0.6)
                    {
                        break;
                    }
                    break;
                }
            }

            if (testWords == -1)
            {
                testWords = random.Next(usingWords.Count, 99 - usingWords.Count);
            }

            List<string> remainingWords = databaseManager.GetRemainingRandomWords((testWords - usingWords.Count), minimumDifficulty, maximumDifficulty);
            usingWords.AddRange(remainingWords);
            usingWords = usingWords.OrderBy(x => random.Next()).ToList();
        }

        public List<string> GeneratePracticeText()
        {
            List<string> linesTest = new List<string>();

            int numberOfLines = (int)Math.Ceiling((double)usingWords.Count / wordsPerLine);

            for (int line = 0; line < numberOfLines; line++)
            {
                List<string> tempWordList = new List<string>();

                for (int i = 0; i < wordsPerLine; i++)
                {
                    int wordIndex = (line * wordsPerLine) + i;

                    if (wordIndex < usingWords.Count)
                    {
                        tempWordList.Add(usingWords[wordIndex]);
                    }
                }

                string tempSentence = string.Join(" ", tempWordList);

                if (line != numberOfLines - 1)
                {
                    tempSentence += " ";
                }

                linesTest.Add(tempSentence);
            }

            int tesdwadts = 4;

            return linesTest;

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
