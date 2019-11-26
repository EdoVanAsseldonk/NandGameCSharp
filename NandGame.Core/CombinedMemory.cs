namespace NandGame.Core
{
    public class CombinedMemory
    {
        private readonly Register16Bit _registerA = new Register16Bit();
        private readonly Register16Bit _registerD = new Register16Bit();
        private readonly RandomAccessMemory16 _ram = new RandomAccessMemory16();

        //public CombinedMemoryOutput Do(bool storeA, bool storeD, bool storeRam, Byte2 data, bool clock)
        //{
        //    var registerOutputA = _registerA.Do(storeA, data, clock);
        //    var registerOutputD = _registerD.Do(storeD, data, clock);
        //    var ramOutput = _ram.Do(registerOutputA, storeRam, data, clock);

        //    return new CombinedMemoryOutput(registerOutputA, registerOutputD, ramOutput);
        //}

        public CombinedMemoryOutput Do(InstructionDecoder.Destination destination, Byte2 data, bool clock)
        {
            var registerOutputA = _registerA.Do(destination.A, data, clock);
            var registerOutputD = _registerD.Do(destination.D, data, clock);
            var ramOutput = _ram.Do(registerOutputA, destination.Ram, data, clock);

            return new CombinedMemoryOutput(registerOutputA, registerOutputD, ramOutput);
        }

        public class CombinedMemoryOutput
        {
            public CombinedMemoryOutput(Byte2 a, Byte2 d, Byte2 ram)
            {
                A = a;
                D = d;
                Ram = ram;
            }

            public Byte2 A { get; set; }

            public Byte2 D { get; set; }

            public Byte2 Ram { get; set; }
        }
    }
}
