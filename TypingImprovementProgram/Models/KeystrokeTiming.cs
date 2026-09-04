using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingImprovementProgram.Models
{
    internal class KeystrokeTiming
    {
        public char CharacterTyped { get; set; }
        public TimeSpan TimeSinceLastTypedKey { get; set; }

    }
}
