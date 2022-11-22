using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtelTest.TestHelper.Generator
{
    internal class IntegerGenerator : Generator<int>
    {
        const int PREROLL = 5;

        public IntegerGenerator(int seed) : base(seed, 0)
        {
            for (int i = 0; i < PREROLL; i++)
            {
                Next();
            }
        }

        public override int Next()
        {
            return RollInt();
        }

        public int Next(int max = int.MaxValue, int min = 0)
        {
            return RollInt(max, min);
        }
    }
}
