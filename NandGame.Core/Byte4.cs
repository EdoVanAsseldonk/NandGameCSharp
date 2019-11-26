using System;
using System.Diagnostics;

namespace NandGame.Core
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class Byte4
    {
        public Byte4(Byte2 high, Byte2 low)
        {
            High = high;
            Low = low;
        }

        public Byte4(long value)
        {
            var binary = Convert.ToString(value, 2).PadLeft(32, '0');
            High = new Byte2(binary.Substring(0, 16));
            Low = new Byte2(binary.Substring(16, 16));
        }

        public Byte4(string value)
        {
            High = new Byte2(value.Substring(0, 16));
            Low = new Byte2(value.Substring(16, 16));
        }


        public Byte2 High { get; set; }

        public Byte2 Low { get; set; }

        public override string ToString()
        {
            return $"{High}" +
                   $"{Low}";
        }

        public UInt32 ToInt32()
        {
            var binaryString = ToString();
            return Convert.ToUInt32(binaryString, 2);
        }

        private string DebuggerDisplay => $"{ToString()} = {ToInt32()}";

        public bool Sixteen => High.Zero;
    }
}