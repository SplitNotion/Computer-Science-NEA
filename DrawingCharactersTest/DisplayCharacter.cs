using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingCharactersTest
{
    public class DisplayCharacter
    {
        public char Character { get; set; } // stores the actual char or space for each char object

        public CharacterState State { get; set; } = CharacterState.Untyped; // gives each char object a state (untyped)
    }
}
