using System;
using System.Diagnostics;

namespace NandGame.Core
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class Byte
    {
        

        public Byte(Nibble high, Nibble low)
        {
            High = high;
            Low = low;
        }

        public Byte(byte value)
        {
            var binary = Convert.ToString(value, 2).PadLeft(8, '0');
            High = new Nibble(binary.Substring(0, 4));
            Low = new Nibble(binary.Substring(4, 4));
        }

        public Byte(string value)
        {
            High = new Nibble(value.Substring(0, 4));
            Low = new Nibble(value.Substring(4, 4));
        }

        public Byte(bool seven,
                    bool six,
                    bool five,
                    bool four,
                    bool three,
                    bool two,
                    bool one,
                    bool zero)
        {
            High = new Nibble(seven, six, five, four);
            Low = new Nibble(three, two, one, zero);
        }

        public bool Zero => Low.Zero;

        public bool One => Low.One;

        public bool Two => Low.Two;

        public bool Three => Low.Three;

        public bool Four => High.Zero;

        public bool Five => High.One;

        public bool Six => High.Two;

        public bool Seven => High.Three;

        public Nibble High { get; }

        public Nibble Low { get; }

        public override string ToString()
        {
            return $"{High}" +
                   $"{Low}";
        }

        public short ToShort()
        {
            return Convert.ToInt16(ToString(), 2);
        }

        private string DebuggerDisplay => $"{ToString()} = {ToShort()}";
    }
}