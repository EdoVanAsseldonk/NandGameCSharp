using System;
using System.Diagnostics;

namespace NandGame.Core
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public class Byte8
    {
        public Byte8(Byte4 high, Byte4 low)
        {
            High = high;
            Low = low;
        }

        public Byte4 High { get; set; }

        public Byte4 Low { get; set; }

        public override string ToString()
        {
            return $"{High}" +
                   $"{Low}";
        }

        public long ToInt64()
        {
            var binaryString = ToString();
            return Convert.ToInt64(binaryString, 2);
        }

        private string DebuggerDisplay => $"{ToString()} = {ToInt64()}";
    }
}