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

        List<string> possibleWordsFromLetters = new List<string>();
        List<string> possibleWordsFromBigrams = new List<string>();
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
            switch (difficulty)
            {
                case "easy":
                    minimumDifficulty = 20;
                    maximumDifficulty = 50;
                    wordsPerLine = 15;
                    return;
                case "medium":
                    minimumDifficulty = 51;
                    maximumDifficulty = 65;
                    wordsPerLine = 15;
                    return;
                case "hard":
                    minimumDifficulty = 66; 
                    maximumDifficulty = 100;
                    wordsPerLine = 15;
                    return;
                default:
                    minimumDifficulty = 0;
                    maximumDifficulty = 100;
                    wordsPerLine = 15;
                    return;
            }
        }

        public void GetLatestUserData(int userID)
        {
            (problemLetters, problemBigrams) = databaseManager.GetLatestUserLetterBigramProblems(userID);
            ChooseBigrams(problemBigrams);
            ChooseLetters(problemLetters);
            MergeWordsForTest(possibleWordsFromBigrams, possibleWordsFromLetters);
        }



        private void ChooseLetters(Dictionary<char, (double errorRate, bool hesitation)> problemLetters)
        {
            double usageWeight;
            List<char> chosenLetters = new List<char>();

            foreach (var letter in problemLetters)
            {
                usageWeight = letter.Value.errorRate;

                if (usageWeight > 0.3 || letter.Value.hesitation)
                {
                    chosenLetters.Add(letter.Key);
                }
            }

            foreach (char letter in chosenLetters)
            {
                possibleWordsFromLetters = databaseManager.GetWordsFromChosenLetters(letter);
                possibleWordsFromLetters = possibleWordsFromLetters.OrderBy(x => random.Next()).ToList();
            }
        }


        private void ChooseBigrams(Dictionary<string, (double errorRate, bool hesitation)> problemBigrams)
        {
            double usageWeight;
            List<string> chosenBigrams = new List<string>();
            List<string> possibleWordsFromBigrams = new List<string>();

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
                possibleWordsFromBigrams = databaseManager.GetWordsFromChosenBigrams(bigram);
                possibleWordsFromBigrams = possibleWordsFromBigrams.OrderBy(x => random.Next()).ToList();
            }   
        }

        private void MergeWordsForTest(List<string> possibleWordsFromBigrams, List<string> possibleWordsFromLetters)
        {
            for (int i = 0; i < possibleWordsFromBigrams.Count; i++)
            {
                if (usingWords.Count >= testWords * 0.6)  // if number of words being used is over limit of 60%, stop
                {
                    break;
                }

                if (!usingWords.Contains(possibleWordsFromBigrams[i]))
                {
                    usingWords.Add(possibleWordsFromBigrams[i]);
                }
            }

            int addedLetterWords = 0;

            for (int i = 0; i < possibleWordsFromLetters.Count; i++)
            {
                if (addedLetterWords >= testWords * 0.2)  // if number of words being used is over limit of 20%, stop
                {
                    break;
                }

                if (!usingWords.Contains(possibleWordsFromLetters[i]))
                {
                    usingWords.Add(possibleWordsFromLetters[i]);
                    addedLetterWords++;
                }
            }

            if (testWords == -1)
            {
                testWords = random.Next(Math.Max(usingWords.Count, 25), 85 - usingWords.Count);  // min words = 25, max words = 85 on randomised number of words setting
            }
            if (testTiming != -1)
            {
                testWords = 99;  // sets number of words to max on a timed test
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

                tempSentence += " ";

                linesTest.Add(tempSentence);
            }

            return linesTest;

        }
    }
}
