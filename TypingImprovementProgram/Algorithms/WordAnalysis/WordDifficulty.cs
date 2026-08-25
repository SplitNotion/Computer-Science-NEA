using System;
using System.Collections.Generic;
using System.IO;
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
            AlternatingScore +
            SameCharScore +
            SameFingerScore +
            RareCharScore +
            SameHandScore +
            DistanceScore;


        public void WordDifficultyCalculator(Word word)
        {
            double totalDistance = 0.0;
            int sameFingerCount = 0;
            int sameCharCount = 0;
            int sameHandCount = 0;
            int rareCharCount = 0;
            double reliability = 0;

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

                reliability = Math.Min((double)(word.Length - 1) / 5, 1.0);

                if (finger1 == finger2) // if fingers are the same (often difficult)
                {
                    sameFingerCount++;
                }
                if (firstChar == secondChar) // same letter (harder, as not expected)
                {
                    sameCharCount++;
                }
                if (hand1 == hand2) // if hands are same (easier)
                {
                    sameHandCount++;
                }
                if (hand1 != hand2) // if hand is different each letter (alternating hands)
                {
                    word.Difficulty.AlternatingHands += 1;
                }
                if (FingerMapping.rareCharacters.ContainsKey(firstChar))
                {
                    word.Difficulty.RareCharScore += FingerMapping.rareCharacters[firstChar];
                    rareCharCount++;
                }
            }


            float alternatingRatio = word.Difficulty.AlternatingHands / (word.Length - 1);
            word.Difficulty.AlternatingScore = (int)Math.Round((1 - alternatingRatio) * 20 * reliability); // score 1-20

            float sameFingerRatio = (float)sameFingerCount / (word.Length - 1);
            word.Difficulty.SameFingerScore = (int)Math.Round(sameFingerRatio * 40 * reliability);  // score 1-40
           
            float sameCharRatio = (float)sameCharCount / (word.Length - 1);
            word.Difficulty.SameCharScore = (int)Math.Round(sameCharRatio * 20 * reliability); // score 1-20

           // float sameHandRatio = (float)sameHandCount / (word.Length - 1);
           // word.Difficulty.SameHandScore = (int)Math.Round(sameHandRatio * 20 * reliability); // score 1-20

            if (rareCharCount != 0)
            {
                float rareCharRatio = (float)word.Difficulty.RareCharScore / rareCharCount;
                word.Difficulty.RareCharScore = (int)Math.Round((rareCharRatio / 10) * 20 * reliability); // score 1-20
            }
            else
            {
                word.Difficulty.RareCharScore = 0;
            }

            int rawLength = Math.Min(word.Length, 10);  
            word.Difficulty.LengthScore = (int)Math.Round((rawLength / 10.0) * 40); // score 1-15



        }


        private double CalculateCharDistance(char firstChar, char secondChar)
        {
            var charPosition1 = FingerMapping.KeyPositions[firstChar];
            var charPosition2 = FingerMapping.KeyPositions[secondChar];

            double xCoordDistance = charPosition2.X - charPosition1.X;
            double yCoordDistance = charPosition2.Y - charPosition1.Y;

            return Math.Sqrt((xCoordDistance * xCoordDistance) + (yCoordDistance * yCoordDistance));
        }

        public void CalculateDistanceScore(double minDistance, double maxDistance)     // calculates the Distance Score
        {
            double normalised = (AverageDistance - minDistance) / (maxDistance - minDistance);

            DistanceScore = (int)Math.Round(normalised * 60);      // Distance score 1-60
        }

    }
}
