using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtelTest.TestHelper.Generator
{
    internal class CharGenerator : Generator<char>
    {
        const int PREROLL = 5;
        public CharGenerator(int seed) : base(seed, 0)
        {
            for (int i = 0; i < PREROLL; i++)
            {
                _ = Next();
            }
        }

        public override char Next()
        {
            int nChar = RollInt(25, 65);
            int bigMod = RollInt(10);
            if (bigMod >= 5) nChar += 7;

            return (char)nChar;
        }
    }
}
