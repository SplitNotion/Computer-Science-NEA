using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Models;

namespace TypingImprovementProgram.Algorithms.TestAnalysis
{
    internal class HesitationAnalyser
    {
        private List<KeystrokeTiming> timings = new List<KeystrokeTiming>();
        private Dictionary<char, double> letterMeanTimes = new Dictionary<char, double>();
        private Dictionary<char, int> letterCount = new Dictionary<char, int>();
        private Dictionary<char, double> letterTotals = new Dictionary<char, double>();

        private List<char> problemLetters = new List<char>();

        private double slowSpeedThreshold;

        public void AnalyseHesitaton(List<KeystrokeTiming> timings)
        {
            this.timings = timings;

            double sumTimings = 0.0;  //  Σx
            int countTimings = timings.Count; // n
            double sumSquareTimings = 0.0; // Σx^2

            foreach (KeystrokeTiming timing in timings)
            {
                sumTimings += timing.TimeSinceLastTypedKey.TotalSeconds;

                sumSquareTimings += Math.Pow(timing.TimeSinceLastTypedKey.TotalSeconds, 2);
            }

            double meanTimings = sumTimings / countTimings; // Σx/n
            double standardDeviationTimings = Math.Sqrt((sumSquareTimings / countTimings) - Math.Pow((sumTimings / countTimings), 2)); // σ


            slowSpeedThreshold = meanTimings + standardDeviationTimings;

            foreach (KeystrokeTiming timing in timings)
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
                if (letter.Value > (slowSpeedThreshold * 0.725))
                {
                    problemLetters.Add(letter.Key);
                }
            }


        }

    }
}
