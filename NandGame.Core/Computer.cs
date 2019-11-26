namespace NandGame.Core
{
    public class Computer
    {
        private readonly ProgramEngine _programEngine;
        private readonly ControlUnit _controlUnit = new ControlUnit();
        private Byte2 _programEngineOutput = new Byte2(0);
        private ControlUnit.ControlUnitOutput _controlUnitOutput = new ControlUnit.ControlUnitOutput(false, new Byte2(0));

        public Computer(IReadOnlyMemory rom)
        {
            _programEngine = new ProgramEngine(rom);
        }

        public void Run()
        {
            bool clock = false;
            while (true)
            {
                _programEngineOutput = _programEngine.Execute(_controlUnitOutput.J, _controlUnitOutput.A, clock);
                _controlUnitOutput = _controlUnit.Do(_programEngineOutput, clock);
                clock = !clock;
            }
        }
    }
}