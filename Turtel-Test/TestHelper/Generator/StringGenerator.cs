using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtelTest.TestHelper.Generator
{
    internal class StringGenerator : Generator<string>
    {
        CharGenerator charGenerator;

        public StringGenerator(int seed) : base(seed, 0)
        {
            charGenerator = new CharGenerator(seed);
        }

        public string Next(int maxLength = int.MaxValue, int minLegth = 1)
        {
            if (maxLength <= 0) throw new ArgumentException("Argument cant be less than 0", nameof(maxLength));
            if (minLegth <= 0 || minLegth > maxLength) throw new ArgumentException("Argument cant be less than 0", nameof(minLegth));

            int len = RollInt(maxLength, minLegth);
            char[] chars = new char[len];

            for (int iChar = 0; iChar < len; iChar++)
            {
                chars[iChar] = charGenerator.Next();
            }

            return new string(chars);
        }

        public override string Next()
        {
            return Next();
        }
    }
}
