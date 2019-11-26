namespace NandGame.Core
{
    public class ControlUnit
    {
        private readonly CombinedMemory _memory = new CombinedMemory();
        private Byte2 _aluOutput = new Byte2(0);
        private Byte2 _selectedBasedOnComputationInstruction = new Byte2(0);
        private CombinedMemory.CombinedMemoryOutput _memoryOutput = new CombinedMemory.CombinedMemoryOutput(new Byte2(0), new Byte2(0), new Byte2(0));
        public ControlUnitOutput Do(Byte2 data, bool clock)
        {
            var decodedInstruction = InstructionDecoder.Decode(data);

            var selectedSourceMemory =
                Select16.Do(decodedInstruction.SourceMemory,
                            _memoryOutput.Ram,
                            _memoryOutput.A);

            _aluOutput =
                ArithmeticLogicUnit.Do(decodedInstruction.Operation,
                                       _memoryOutput.D,
                                       selectedSourceMemory);

            _selectedBasedOnComputationInstruction =
                Select16.Do(decodedInstruction.ComputationInstruction,
                            _aluOutput,
                            decodedInstruction.w);
            
            _memoryOutput = _memory.Do(decodedInstruction.Destination,
                                      _selectedBasedOnComputationInstruction,
                                      clock);
           
            var isCondition =
                ArithmeticLogicUnit.Evaluate(decodedInstruction.Condition,
                                             _aluOutput);

            return new ControlUnitOutput(isCondition, _memoryOutput.A);
        }

        public class ControlUnitOutput
        {
            public ControlUnitOutput(bool j, Byte2 a)
            {
                J = j;
                A = a;
            }

            public bool J { get; set; }

            public Byte2 A { get; set; }
        }
    }
}
