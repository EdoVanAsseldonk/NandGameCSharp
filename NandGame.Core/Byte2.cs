using System;
using System.Diagnostics;

namespace NandGame.Core
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class Byte2
    {
        public Byte2(Byte high, Byte low)
        {
            High = high;
            Low = low;
        }

        public Byte2(short value)
        {
            var binary = Convert.ToString(value, 2).PadLeft(16, '0');
            High = new Byte(binary.Substring(0, 8));
            Low = new Byte(binary.Substring(8, 8));
        }

        public Byte2(string value)
        {
            if (value.Length < 16)
            {
                throw new Exception("value should be 16 bits");
            }

            High = new Byte(value.Substring(0, 8));
            Low = new Byte(value.Substring(8, 8));
        }

        public Byte2(bool fifteen,
                     bool fourteen,
                     bool thirteen,
                     bool twelve,
                     bool eleven,
                     bool ten,
                     bool nine,
                     bool eight,
                     bool seven,
                     bool six,
                     bool five,
                     bool four,
                     bool three,
                     bool two,
                     bool one,
                     bool zero)
        {
            High = new Byte(fifteen, fourteen, thirteen, twelve, eleven, ten, nine, eight);
            Low = new Byte(seven, six, five, four, three, two, one, zero);
        }

        public bool Zero => Low.Zero;

        public bool One => Low.One;

        public bool Two => Low.Two;

        public bool Three => Low.Three;

        public bool Four => Low.Four;

        public bool Five => Low.Five;

        public bool Six => Low.Six;

        public bool Seven => Low.Seven;

        public bool Eight => High.Zero;

        public bool Nine => High.One;

        public bool Ten => High.Two;

        public bool Eleven => High.Three;

        public bool Twelve => High.Four;

        public bool Thirteen => High.Five;

        public bool Fourteen => High.Six;

        public bool Fifteen => High.Seven;

        public Byte High { get; set; }

        public Byte Low { get; set; }

        public override string ToString()
        {
            return $"{High}" +
                   $"{Low}";
        }

        public int ToInt16()
        {
            var stringValue = ToString();
            return Convert.ToInt16(stringValue, 2);
        }

        public int ToUInt16()
        {
            var stringValue = ToString();
            return Convert.ToUInt16(stringValue, 2);
        }

        private string DebuggerDisplay => $"{ToString()} = {ToInt16()}";
    }
}