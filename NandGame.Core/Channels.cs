namespace NandGame.Core
{
    public class Channels
    {
        public Channels(bool channel0, bool channel1)
        {
            Channel0 = channel0;
            Channel1 = channel1;
        }

        public bool Channel0 { get; set; }

        public bool Channel1 { get; set; }
    }
}