using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Algorithms.WordAnalysis
{
    internal class WordAnalyser
    {
        public List<Word> AnalyseFile(string filePath)  // takes each word in file, puts each word into an array, then sends each word to get analysed (AnalyseWord)
        {
            string[] words = File.ReadAllLines(filePath);

            List<Word> analysedWords = new List<Word>();

            foreach (string wordText in words)
            {
                Word word = AnalyseWord(wordText);

                analysedWords.Add(word);
            }

            return analysedWords;
        }

        private static Word AnalyseWord(string text) // for each word in file (one at a time given by words array), it calculates the text, length and frequency of letters as part of word object
        {
            Word word = new Word();

            word.Text = text;
            word.Length = text.Length;

            word.LetterFrequency = new Dictionary<char, int>();


            foreach (char c in text)
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
            word.Difficulty.WordDifficultyCalculator(word);
            
            return word;
        }
    }
}
