namespace NandGame.Core
{
    /// <summary>
    /// A switch component channels a data bit through one of two output channels.
    /// </summary>
    public static class Switch
    {
        /// <summary>
        /// Sends a data bit to one of two output channels.
        /// </summary>
        /// <param name="s">Determines if the data bit is dispatched through c1 or c0</param>
        /// <param name="data">Data</param>
        public static Channels Do(bool s, bool data)
        {
            var invS = Gates.Invert(s);

            var channel0 = Gates.And(invS, data);
            var channel1 = Gates.And(s, data);

            return new Channels(channel0, channel1);
        }
    }
}