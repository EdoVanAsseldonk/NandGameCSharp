namespace NandGame.Core
{
    /// <summary>
    /// A 2-bit register works like a data flip-flop, except two bits (d1 and d0) are stored and emitted instead of one.
    /// </summary>
    public class Register2Bit
    {
        private readonly DataFlipFlop _dff0 = new DataFlipFlop();
        private readonly DataFlipFlop _dff1 = new DataFlipFlop();

        /// <summary>
        ///  Stores and emits a 16-bit word, synchronized by a clock signal.
        /// </summary>
        /// <param name="st">Store: yes/no</param>
        /// <param name="data">data that needs to be stored</param>
        /// <param name="clock">Clock signal</param>
        /// <returns>The previously stored values</returns>
        //public Bit2 Do(bool st, bool d0, bool d1, bool clock)
        //{
        //    return new Bit2(_dff1.Do(st, d1, clock),
        //                    _dff2.Do(st, d0, clock));
        //}

        public Bit2 Do(bool st, Bit2 data, bool clock)
        {
            return new Bit2(_dff0.Do(st, data.High, clock),
                            _dff1.Do(st, data.Low, clock));
        }
    }
}