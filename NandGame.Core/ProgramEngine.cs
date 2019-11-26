namespace NandGame.Core
{
    public class ProgramEngine
    {
        private readonly Counter _counter = new Counter();
        private readonly IReadOnlyMemory _rom;

        public ProgramEngine(IReadOnlyMemory rom)
        {
            _rom = rom;
        }

        public Byte2 Execute(bool jump, Byte2 address, bool clock)
        {
            var count = _counter.Do(jump, address, clock);
            return _rom.Read(count);
        }
    }
}