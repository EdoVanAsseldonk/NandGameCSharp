namespace NandGame.Core
{
    public class DataFlipFlop
    {
        readonly Latch _latch1 = new Latch();
        readonly Latch _latch2 = new Latch();

        /// <summary>
        /// A latch component stores and outputs a single bit.
        /// When st(store) is 1, the value on d is stored and emitted.
        /// When st is 0, the value of d is ignored, and the previously stored value is still emitted.
        /// </summary>
        /// <param name="st">Store: yes/no</param>
        /// <param name="d">Data</param>
        /// <param name="clock">Clock signal</param>
        /// <returns>The previously stored value</returns>
        public bool Do(bool st, bool d, bool clock)
        {
            var invertedCLock = Gates.Invert(clock);

            var storeButNotClockTick = Gates.And(st, invertedCLock);

            var output = _latch1.Do(storeButNotClockTick, d);

            return _latch2.Do(clock, output);
        }
    }
}