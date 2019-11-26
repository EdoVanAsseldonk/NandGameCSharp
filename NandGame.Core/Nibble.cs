using System;

namespace NandGame.Core
{
    public class Nibble
    {
        public Nibble(Bit2 high, Bit2 low)
        {
            High = high;
            Low = low;
        }

        public Nibble(string value)
        {
            High = new Bit2(value.Substring(0,2));
            Low = new Bit2(value.Substring(2, 2));
        }

        /// <summary>
        /// Creates a Nibble from a value from 0 to 15
        /// </summary>
        /// <param name="value">0 to and including 15</param>
        public Nibble(byte value)
        {
            if (value > 15)
            {
                throw new ArgumentOutOfRangeException("value", "Value should be from 0 to (including) 15");
            }

            var binary = Convert.ToString(value, 2).PadLeft(4, '0');
            High = new Bit2(binary.Substring(0, 2));
            Low = new Bit2(binary.Substring(2, 2));
        }

        public Nibble(bool three,
                      bool two,
                      bool one,
                      bool zero)
        {
            High = new Bit2(three, two);
            Low = new Bit2(one, zero);
        }

        public bool Zero => Low.Low;

        public bool One => Low.High;

        public bool Two => High.Low;

        public bool Three => High.High;

        public Bit2 High { get; set; }

        public Bit2 Low { get; set; }

        public override string ToString()
        {
            return $"{Convert.ToInt32(Three)}" +
                   $"{Convert.ToInt32(Two)}" +
                   $"{Convert.ToInt32(One)}" +
                   $"{Convert.ToInt32(Zero)}";
        }

        public short ToShort()
        {
            return Convert.ToInt16(ToString(), 2);
        }
    }
}