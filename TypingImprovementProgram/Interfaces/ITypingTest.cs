using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingImprovementProgram.Interfaces
{
    internal interface ITypingTest
    {
        int incorrectCounter { get; }
        int totalCharacterAttempts { get; }
        int totalWords { get; }
        int userID { get; }
        double totalTestSeconds { get; }
        int TypedWords { get; }
        int TotalWords { get; }
        string TestNote { get; }
    }
}
