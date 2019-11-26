namespace NandGame.Core
{
    public class Counter
    {
        readonly Register16Bit register = new Register16Bit();
        private Byte2 _selectedData = new Byte2(0);
        Byte2 registeredOutput = new Byte2(0);
        Byte2 incremented = new Byte2(0);

        public Byte2 Do(bool store,  Byte2 data, bool clock)
        {
            var invertedClock = Gates.Invert(clock);

            incremented = Arithmetics.Increment(registeredOutput);

            _selectedData = Select16.Do(store,
                                              data,
                                              incremented);

            registeredOutput = register.Do(invertedClock,
                                           _selectedData,
                                           clock);
            
            return registeredOutput;
        }
    }
}