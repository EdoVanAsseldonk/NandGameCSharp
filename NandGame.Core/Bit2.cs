namespace NandGame.Core
{
    public class Bit2
    {
        public Bit2(bool high, bool low)
        {
            High = high;
            Low = low;
        }

        public Bit2(string value)
        {
            High = value.Substring(0, 1) == "1";
            Low = value.Substring(1, 1) == "1";
        }

        public bool High { get; set; }

        public bool Low { get; set; }
    }
}