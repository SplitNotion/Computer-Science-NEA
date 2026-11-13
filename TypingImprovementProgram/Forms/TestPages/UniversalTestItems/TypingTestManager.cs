using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Models;
using static System.Windows.Forms.LinkLabel;

namespace TypingImprovementProgram.Forms.TestPages.UniversalPages
{
    internal class TypingTestManager
    {
        public Dictionary<char, int> letterOpportunities = new Dictionary<char, int>();
        public Dictionary<string, int> bigramOpportunities = new Dictionary<string, int>();

        public void LoadTest(List<string> lines, TypingDisplayControl display)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                foreach (char c in lines[i])
                {
                    display.Characters.Add(new DisplayCharacter { Character = c, Line = i }); // adds a new char object to the list

                    if (letterOpportunities.ContainsKey(c))
                    {
                        letterOpportunities[c]++;
                    }
                    else
                    {
                        letterOpportunities.Add(c, 1);
                    }
                }

                // edit needed?
                for (int j = 0; j < lines[i].Length - 1; j++)
                {
                    string bigram = "" + lines[i][j] + lines[i][j + 1];

                    if (!bigram.Contains(" "))
                    {
                        if (bigramOpportunities.ContainsKey(bigram))
                        {
                            bigramOpportunities[bigram]++;
                        }
                        else
                        {
                            bigramOpportunities.Add(bigram, 1);
                        }
                    }
                }
            }
        }


        public List<KeystrokeTiming> timings { get; set; } = new List<KeystrokeTiming>();
        private Stopwatch stopwatch = new Stopwatch(); 
        private TimeSpan previousKeyTime = TimeSpan.Zero; 

        public void StartTiming()
        {
            previousKeyTime = TimeSpan.Zero;
            stopwatch.Restart();
        }

        public void RecordKey(char character)
        {
            TimeSpan currentTime = stopwatch.Elapsed;
            TimeSpan interval = TimeSpan.Zero;

            if (timings.Count > 0)
            {
                interval = currentTime - previousKeyTime;
            }

            timings.Add(new KeystrokeTiming
            {
                CharacterTyped = character,
                TimeSinceLastTypedKey = interval,
            });

            previousKeyTime = currentTime;
        }

        public void StopTiming()
        {
            stopwatch.Stop();
        }

        public bool MoveToNextCharacter(ref int currentIndex, List<DisplayCharacter> characters)
        {
            currentIndex++;

            if (currentIndex < characters.Count)
            {
                // updates the current character
                characters[currentIndex].State = CharacterState.Current;
                return true;
            }

            return false;
        }

        public bool BackspaceHandling(int currentIndex, List<DisplayCharacter> characters)
        {
            if (currentIndex < 0)
            {
                return false;
            }

            if (characters[currentIndex - 1].Character == ' ')
            {
                return false;
            }

            characters[currentIndex].State = CharacterState.Untyped;
            characters[currentIndex - 1].State = CharacterState.Current;

            return true;    
        }

        public Dictionary<char, int> incorrectLetters = new Dictionary<char, int>();
        public Dictionary<string, int> incorrectBigrams = new Dictionary<string, int>();
        public bool incorrectlyTyped = false;

        public char? CharacterBigramAttributeAssignment(char typedCharacter, int currentIndex, List<DisplayCharacter> characters, out int totalCorrectWordCharacters)
        {
            char expectedCharacter = characters[currentIndex].Character;
            totalCorrectWordCharacters = 0;
            bool charCorrect = false;
            
            if (typedCharacter == expectedCharacter)                  // if keypress is same as char on screen
            {
                characters[currentIndex].State = CharacterState.Correct;          // make correct
                charCorrect = true;
            }

            else
            {
                incorrectlyTyped = true;
                characters[currentIndex].State = CharacterState.Incorrect;        // make incorrect

                // adds incorrect character to a dictionary/increments occurences if it has been incorrectly typed
                char character = characters[currentIndex].Character;
                if (!incorrectLetters.ContainsKey(character))
                {
                    incorrectLetters.Add(character, 1);
                }
                else if (incorrectLetters.ContainsKey(character))
                {
                    incorrectLetters[character]++;
                }

                // adds incorrect bigrams (e.g. word => 'wo' and 'or') to a dictionary/increments occurences if it has been incorrectly typed
                if (currentIndex > 0 && characters[currentIndex - 1].Character != ' ' && characters[currentIndex].Character != ' ')
                {
                    string bigramBefore = "" + characters[currentIndex - 1].Character + characters[currentIndex].Character;

                    if (!incorrectBigrams.ContainsKey(bigramBefore))
                    {
                        incorrectBigrams.Add(bigramBefore, 1);
                    }
                    else if (incorrectBigrams.ContainsKey(bigramBefore) && (incorrectBigrams[bigramBefore] < bigramOpportunities[bigramBefore]))
                    {
                        incorrectBigrams[bigramBefore]++;
                    }
                }

                if (currentIndex < characters.Count - 1 && characters[currentIndex + 1].Character != ' ' && characters[currentIndex].Character != ' ')
                {
                    string bigramAfter = "" + characters[currentIndex].Character + characters[currentIndex + 1].Character;

                    if (!incorrectBigrams.ContainsKey(bigramAfter))
                    {
                        incorrectBigrams.Add(bigramAfter, 1);
                    }
                    else if (incorrectBigrams.ContainsKey(bigramAfter) && (incorrectBigrams[bigramAfter] < bigramOpportunities[bigramAfter]))
                    {
                        incorrectBigrams[bigramAfter]++;
                    }
                }
            }

            if (currentIndex == characters.Count - 1 || characters[currentIndex + 1].Character == ' ')
            {
                if (incorrectlyTyped == true)
                {
                    incorrectlyTyped = false;
                }
                else
                {
                    for (int i = currentIndex; i >= 0 && characters[i].Character != ' '; i--)
                    {
                        totalCorrectWordCharacters++;
                    }

                    if (currentIndex < characters.Count - 1)
                    {
                        totalCorrectWordCharacters++;
                    }
                }
            }

            if (charCorrect)
            {
                return null;
            }
            return expectedCharacter;
        }

        public void SharedContinueButtonFunctionality()
        {

        }
    }
}
