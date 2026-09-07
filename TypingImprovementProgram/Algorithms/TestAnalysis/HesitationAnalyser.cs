using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Algorithms.TestAnalysis
{
    internal class HesitationAnalyser
    {
        private List<KeystrokeTiming> timings = new List<KeystrokeTiming>();
        private List<KeystrokeTiming> baselineTimings = new List<KeystrokeTiming>();
        private Dictionary<char, double> letterMeanTimes = new Dictionary<char, double>();
        private Dictionary<char, int> letterCount = new Dictionary<char, int>();
        private Dictionary<char, double> letterTotals = new Dictionary<char, double>();

        private Dictionary<string, double> bigramMeanTimes = new Dictionary<string, double>();
        private Dictionary<string, int> bigramCount = new Dictionary<string, int>();
        private Dictionary<string, double> bigramTotals = new Dictionary<string, double>();

        private List<char> problemLetters = new List<char>();
        private List<string> problemBigrams = new List<string>();


        private double slowSpeedThreshold;

        public void AnalyseHesitaton(List<KeystrokeTiming> timings)
        {
            this.timings = timings;

            baselineTimings.Clear();

            foreach(KeystrokeTiming timing in timings)
            {
                baselineTimings.Add(timing);
            }

            letterMeanTimes.Clear();
            letterCount.Clear();
            letterTotals.Clear();

            bigramMeanTimes.Clear();
            bigramCount.Clear();
            bigramTotals.Clear();

            problemLetters.Clear();
            problemBigrams.Clear();


            AnalyseLetterHesitation();
            AnalyseBigramHesitation();
        }

        private void AnalyseLetterHesitation()
        {
            // calculates the threshold in which letter should be characterised as having hesitation (via standard deviation formula)
            double sumTimings = 0.0;  //  Σx
            int countTimings = baselineTimings.Count; // n
            double sumSquareTimings = 0.0; // Σx^2

            foreach (KeystrokeTiming timing in baselineTimings)
            {
                sumTimings += timing.TimeSinceLastTypedKey.TotalSeconds;

                sumSquareTimings += Math.Pow(timing.TimeSinceLastTypedKey.TotalSeconds, 2);
            }

            double meanTimings = sumTimings / countTimings; // Σx/n
            double standardDeviationTimings = Math.Sqrt((sumSquareTimings / countTimings) - Math.Pow((sumTimings / countTimings), 2)); // σ
            slowSpeedThreshold = meanTimings + standardDeviationTimings;


            foreach (KeystrokeTiming timing in baselineTimings)
            {
                char letter = timing.CharacterTyped;
                double seconds = timing.TimeSinceLastTypedKey.TotalSeconds;

                if (!letterTotals.ContainsKey(letter))
                {
                    letterTotals[letter] = 0;
                    letterCount[letter] = 0;
                }

                letterTotals[letter] += seconds;
                letterCount[letter]++;
            }

            foreach (char letter in letterTotals.Keys)
            {
                letterMeanTimes[letter] = letterTotals[letter] / letterCount[letter];
            }

            foreach (var letter in letterMeanTimes)
            {
                if (letter.Value > (meanTimings + (standardDeviationTimings * 0.635)))
                {
                    problemLetters.Add(letter.Key);
                }
            }
        }

        private void AnalyseBigramHesitation()
        {
            for (int i = 1; i < baselineTimings.Count; i++)
            {
                char previousLetter = baselineTimings[i - 1].CharacterTyped;
                char currentLetter = baselineTimings[i].CharacterTyped;

                string bigram = previousLetter + "" + currentLetter;

                double seconds = baselineTimings[i].TimeSinceLastTypedKey.TotalSeconds;

                if (!bigramTotals.ContainsKey(bigram))
                {
                    bigramTotals[bigram] = 0;
                    bigramCount[bigram] = 0;
                }

                bigramTotals[bigram] += seconds;
                bigramCount[bigram]++;
            }

            foreach (string bigram in bigramTotals.Keys)
            {
                bigramMeanTimes[bigram] = bigramTotals[bigram] / bigramCount[bigram];
            }

            foreach (var bigram in bigramMeanTimes)
            {
                if (bigram.Value > (slowSpeedThreshold * 0.95))
                {
                    problemBigrams.Add(bigram.Key);
                }
            }

            problemBigrams.RemoveAll(bigram => bigram.Contains(' '));
        }

    }
}
