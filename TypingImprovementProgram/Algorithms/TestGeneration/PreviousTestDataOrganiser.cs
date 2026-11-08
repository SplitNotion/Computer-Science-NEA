using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingImprovementProgram.Algorithms.TestGeneration
{
    internal class PreviousTestDataOrganiser
    {
        public Dictionary<char, (double errorRate, bool hesitation)> CombineLetterData(Dictionary<char, (double errorRate, bool hesitation)> previousTestLetters, Dictionary<char, (double errorRate, bool hesitation)> currentTestLetters)
        {
            Dictionary<char, (double, bool)> combinedLetterData = new Dictionary<char, (double, bool)>();

            if (previousTestLetters.Count == 0)
            {
                return currentTestLetters;
            }

            foreach (var letter in previousTestLetters)
            {
                double combinedRate = letter.Value.errorRate * 0.4;
                bool hesitation = letter.Value.hesitation;

                if (currentTestLetters.Contains(letter))
                {
                    combinedRate += currentTestLetters[letter.Key].errorRate * 0.6;

                    if (currentTestLetters[letter.Key].hesitation)
                    {
                        hesitation = true;
                    }
                }
                combinedLetterData.Add(letter.Key, (combinedRate, hesitation));
            }

            foreach (var letter in currentTestLetters)
            {
                if (!previousTestLetters.ContainsKey(letter.Key))
                {
                    combinedLetterData.Add(letter.Key, (letter.Value.errorRate, letter.Value.hesitation));
                }
            }
            return combinedLetterData;
        }

        public Dictionary<string, (double errorRate, bool hesitation)> CombineBigramData(Dictionary<string, (double errorRate, bool hesitation)> previousTestBigrams, Dictionary<string, (double errorRate, bool hesitation)> currentTestBigrams)
        {
            Dictionary<string, (double, bool)> combinedBigramData = new Dictionary<string, (double, bool)>();

            if (previousTestBigrams.Count == 0)
            {
                return currentTestBigrams;
            }

            foreach (var bigram in previousTestBigrams)
            {
                double combinedRate = bigram.Value.errorRate * 0.4;
                bool hesitation = bigram.Value.hesitation;

                if (currentTestBigrams.Contains(bigram))
                {
                    combinedRate += currentTestBigrams[bigram.Key].errorRate * 0.6;

                    if (currentTestBigrams[bigram.Key].hesitation)
                    {
                        hesitation = true;
                    }
                }
                combinedBigramData.Add(bigram.Key, (combinedRate, hesitation));
            }

            foreach (var letter in currentTestBigrams)
            {
                if (!previousTestBigrams.ContainsKey(letter.Key))
                {
                    combinedBigramData.Add(letter.Key, (letter.Value.errorRate, letter.Value.hesitation));
                }
            }
            return combinedBigramData;
        }



    }
}
