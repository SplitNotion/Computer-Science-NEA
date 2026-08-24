using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Models;


namespace TypingImprovementProgram.Algorithms.WordAnalysis
{
    internal class WordDifficulty
    {
        public float AlternatingHands { get; set; }
        public double AverageDistance { get; set; }
        public int DistanceScore { get; set; }


        public int LengthScore { get; set; }
        public float AlternatingScore { get; set; }
        public int SameCharScore { get; set; }
        public int RareCharScore { get; set; }
        public int SameFingerScore { get; set; }
        public int SameHandScore { get; set; }


        public double TotalScore =>
            LengthScore +
            (0.35 * AlternatingScore) +
            SameCharScore +
            SameFingerScore +
            RareCharScore +
            DistanceScore;


        public void WordDifficultyCalculator(Word word)
        {
            double totalDistance = 0.0;

            for (int i = 0; i < word.Length - 1; i++)
            {
                char firstChar = word.Text[i];
                char secondChar = word.Text[i + 1];

                Finger finger1 = FingerMapping.Fingers[firstChar];
                Finger finger2 = FingerMapping.Fingers[secondChar];

                Hand hand1 = FingerMapping.GetHand(finger1);
                Hand hand2 = FingerMapping.GetHand(finger2);

                totalDistance += CalculateCharDistance(firstChar, secondChar);
                AverageDistance = totalDistance / (word.Length - 1);

                if (finger1 == finger2) // if fingers are the same (often difficult)
                {
                    word.Difficulty.SameFingerScore += 2;
                }
                if (firstChar == secondChar) // same letter (harder, as not expected)
                {
                    word.Difficulty.SameCharScore += 3;
                }

                if (hand1 == hand2) // if hands are same (easier)
                {
                    word.Difficulty.SameHandScore -= 1;
                }
                if (hand1 != hand2) // if hand is different each letter (alternating hands)
                {
                    word.Difficulty.AlternatingHands += 1;
                }
                if (FingerMapping.rareCharacters.ContainsKey(firstChar))
                {
                    word.Difficulty.RareCharScore += FingerMapping.rareCharacters[firstChar];
                }
            }
            if (word.Length >= 4)
            {
                word.Difficulty.LengthScore += Math.Min(word.Length * 3, 50);
            }
            else
            {
                word.Difficulty.LengthScore += 2;
            }

            float alternatingRatio = word.Difficulty.AlternatingHands / (word.Length - 1);
            word.Difficulty.AlternatingScore = (1 - alternatingRatio) * 15; // max score of +15

        }


        private double CalculateCharDistance(char firstChar, char secondChar)
        {
            var charPosition1 = FingerMapping.KeyPositions[firstChar];
            var charPosition2 = FingerMapping.KeyPositions[secondChar];

            double xCoordDistance = charPosition2.X - charPosition1.X;
            double yCoordDistance = charPosition2.Y - charPosition1.Y;

            return Math.Sqrt((xCoordDistance * xCoordDistance) + (yCoordDistance * yCoordDistance));
        }

        public void CalculateDistanceScore(double minDistance, double maxDistance)
        {
            double normalised = (AverageDistance - minDistance) / (maxDistance - minDistance);

            DistanceScore = (int)Math.Round(normalised * 15);      // Distance score 1-15
        }

    }
}
