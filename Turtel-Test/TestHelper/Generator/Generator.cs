using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtelTest.TestHelper.Generator
{
    internal abstract class Generator<T>
    {
        protected readonly int Seed;

        private int rollCount = 1;

        protected Generator(int seed, int lastInt)
        {
            Seed = seed;
            LastInt = lastInt;
        }

        protected int RollModifier
        {
            get
            {
                int n = rollCount++;
                if (rollCount == int.MaxValue) rollCount = 1;
                return n;
            }
        }

        protected int LastInt { get; set; }

        protected static uint CurrentCPUTicks { get { return (uint)Environment.TickCount; } }

        protected int RollInt(int mod = int.MaxValue, int min = 0)
        {
            LastInt = (int)(CurrentCPUTicks * (LastInt / rollCount) + Seed % mod + min);
            return LastInt;
        }

        public abstract T Next();


    }
}
