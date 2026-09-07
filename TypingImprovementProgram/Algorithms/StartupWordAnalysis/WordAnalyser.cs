using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Models;
using TypingImprovementProgram.Database;


namespace TypingImprovementProgram.Algorithms.WordAnalysis
{
    internal class WordAnalyser
    {
        public WordBigramsSorter Bigrams { get; set; }
        DatabaseManager database = new DatabaseManager();


        // takes each word in file, puts each word into an array, then sends each word to get analysed (AnalyseWord)
        public List<Word> AnalyseFile(string filePath)  
        {
            string[] words = File.ReadAllLines(filePath);
            Bigrams = new WordBigramsSorter();

            List<Word> analysedWords = new List<Word>();

            // each word in file is sent to be analysed
            foreach (string wordText in words)  
            {
                Word word = AnalyseWord(wordText);
                Bigrams.AddWordBigrams(word);
                analysedWords.Add(word);
            }

            // each bigram that is contained in the bigram dictionary is inserted into the PossibleBigrams database table
            foreach (var bigram in Bigrams.PossibleBigramsDictionary)    
            {
                int id = database.InsertIntoPossibleBigrams(bigram.Key, bigram.Value);   // Each Bigram and its frequency is inserted into the PossibleBigrams table in the database. It also returns the BigramID for each bigram.

                database.BigramIDs.Add(bigram.Key, id);  // Adds the Bigram and its respective ID into a dictionary in the DatabaseManager class.
            }


            List<double> distances = new List<double>();
            List<double> totalScores = new List<double>();

            foreach (Word word in analysedWords)
            {
                distances.Add(word.Difficulty.AverageDistance);
                totalScores.Add(word.Difficulty.TotalScore);
            }

            double minDistance = distances.Min();
            double maxDistance = distances.Max();

            double minScore = totalScores.Min();
            double maxScore = totalScores.Max();
            double avergeScore = totalScores.Average();

            foreach (Word word in analysedWords)
            {
                word.Difficulty.CalculateDistanceScore(minDistance, maxDistance);
                database.InsertIntoTables(word);
            }

            return analysedWords;
        }








        // for each word in file (one at a time given by words array), it calculates the text, length and frequency of letters as part of word object
        private static Word AnalyseWord(string text) 
        {
            Word word = new Word();


            word.Text = text;
            word.Length = text.Length;

            word.LetterFrequency = new Dictionary<char, int>();


            foreach (char c in text) // calculates frequency of each letter in the word
            {
                if (word.LetterFrequency.ContainsKey(c))
                {
                    word.LetterFrequency[c]++;
                }
                else
                {
                    word.LetterFrequency[c] = 1;
                }
            }

            word.Difficulty = new WordDifficulty();
            word.Difficulty.WordDifficultyCalculator(word);  // word difficulty for each word is calculated
            
            return word;
        }
    }
}
