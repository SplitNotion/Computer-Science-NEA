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
        public WordBigrams Bigrams { get; set; }
        DatabaseManager database = new DatabaseManager();


        public List<Word> AnalyseFile(string filePath)  // takes each word in file, puts each word into an array, then sends each word to get analysed (AnalyseWord)
        {
            string[] words = File.ReadAllLines(filePath);
            Bigrams = new WordBigrams();

            List<Word> analysedWords = new List<Word>();

            foreach (string wordText in words)  // each word in file is sent to be analysed
            {
                Word word = AnalyseWord(wordText);
                Bigrams.AddWordBigrams(word);
                analysedWords.Add(word);
            }

            foreach (var bigram in Bigrams.AllBigrams)
            {
                database.InsertIntoPossibleBigrams(bigram.Key);
            }

            return analysedWords;
        }

        private static Word AnalyseWord(string text) // for each word in file (one at a time given by words array), it calculates the text, length and frequency of letters as part of word object
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
