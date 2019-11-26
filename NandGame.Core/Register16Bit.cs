namespace NandGame.Core
{
    /// <summary>
    /// A register stores and outputs data, but only change the output when the clock signal change from 0 to 1.
    /// </summary>
    public class Register16Bit
    {
        private readonly DataFlipFlop _dff0 = new DataFlipFlop();
        private readonly DataFlipFlop _dff1 = new DataFlipFlop();
        private readonly DataFlipFlop _dff2 = new DataFlipFlop();
        private readonly DataFlipFlop _dff3 = new DataFlipFlop();
        private readonly DataFlipFlop _dff4 = new DataFlipFlop();
        private readonly DataFlipFlop _dff5 = new DataFlipFlop();
        private readonly DataFlipFlop _dff6 = new DataFlipFlop();
        private readonly DataFlipFlop _dff7 = new DataFlipFlop();
        private readonly DataFlipFlop _dff8 = new DataFlipFlop();
        private readonly DataFlipFlop _dff9 = new DataFlipFlop();
        private readonly DataFlipFlop _dff10 = new DataFlipFlop();
        private readonly DataFlipFlop _dff11 = new DataFlipFlop();
        private readonly DataFlipFlop _dff12 = new DataFlipFlop();
        private readonly DataFlipFlop _dff13 = new DataFlipFlop();
        private readonly DataFlipFlop _dff14 = new DataFlipFlop();
        private readonly DataFlipFlop _dff15 = new DataFlipFlop();

        private Byte2 _currentValue = new Byte2(0);

        public Byte2 Do(bool st, Byte2 data, bool clock)
        {
            var dff0 = _dff0.Do(st, data.Zero, clock);
            var dff1 = _dff1.Do(st, data.One, clock);
            var dff2 = _dff2.Do(st, data.Two, clock);
            var dff3 = _dff3.Do(st, data.Three, clock);
            var dff4 = _dff4.Do(st, data.Four, clock);
            var dff5 = _dff5.Do(st, data.Five, clock);
            var dff6 = _dff6.Do(st, data.Six, clock);
            var dff7 = _dff7.Do(st, data.Seven, clock);
            var dff8 = _dff8.Do(st, data.Eight, clock);
            var dff9 = _dff9.Do(st, data.Nine, clock);
            var dff10 = _dff10.Do(st, data.Ten, clock);
            var dff11 = _dff11.Do(st, data.Eleven, clock);
            var dff12 = _dff12.Do(st, data.Twelve, clock);
            var dff13 = _dff13.Do(st, data.Thirteen, clock);
            var dff14 = _dff14.Do(st, data.Fourteen, clock);
            var dff15 = _dff15.Do(st, data.Fifteen, clock);

            _currentValue = new Byte2(dff15,
                                      dff14,
                                      dff13,
                                      dff12,
                                      dff11,
                                      dff10,
                                      dff9,
                                      dff8,
                                      dff7,
                                      dff6,
                                      dff5,
                                      dff4,
                                      dff3,
                                      dff2,
                                      dff1,
                                      dff0);

            return _currentValue;
        }

        public override string ToString()
        {
            return _currentValue.ToString();
        }
    }
}
