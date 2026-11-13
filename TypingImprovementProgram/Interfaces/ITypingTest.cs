using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingImprovementProgram.Interfaces
{
    internal interface ITypingTest
    {
        int IncorrectCounter { get; }
        int TotalCharacterAttempts { get; }
        int TotalWords { get; }
        int UserID { get; }
        double TotalTestSeconds { get; }
        int TypedWords { get; }
        int TotalCorrectWordCharacters { get; }

        string TestNote { get; }

    }
}
