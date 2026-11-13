using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingImprovementProgram.Interfaces;

namespace TypingImprovementProgram.Forms.TestPages.UniversalTestItems
{
    public abstract class TypingTestBase : UserControl, ITypingTest
    {
        public int incorrectCounter { get; set; }
        public int totalCharacters { get; set; }
        public int totalCharacterAttempts { get; set; }
        public int totalWords { get; set; }
        public int typedWords { get; set; }
        public int totalCorrectWordCharacters { get; set; }
        public int userID { get; set; }
        public double totalTestSeconds { get; set; }


        public int IncorrectCounter => incorrectCounter;
        public int TotalCharacters => totalCharacters;
        public int TotalCharacterAttempts => totalCharacterAttempts;
        public int TotalWords => totalWords;
        public int TypedWords => typedWords;
        public int TotalCorrectWordCharacters => totalCorrectWordCharacters;
        public int UserID => userID;
        public double TotalTestSeconds => totalTestSeconds;

        public abstract string TestNote { get; }

    }
}
