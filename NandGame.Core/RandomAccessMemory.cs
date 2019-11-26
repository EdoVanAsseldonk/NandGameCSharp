namespace NandGame.Core
{
    public class RandomAccessMemory
    {
        readonly Register16Bit _register0 = new Register16Bit();
        readonly Register16Bit _register1 = new Register16Bit();
        Byte2 _output0 = new Byte2(0);
        Byte2 _output1 = new Byte2(0);

        public Byte2 Do(bool address, bool store, Byte2 data, bool clock)
        {
            var storeAtBank1 = Gates.And(address, store);

            var invertedAddress = Gates.Invert(address);
            var storeAtBank0 = Gates.And(invertedAddress, store);
            
            _output1 = _register1.Do(storeAtBank1, data, clock);
            
            _output0 = _register0.Do(storeAtBank0, data, clock);

            var outputTotal = Select16.Do(address,
                                                _output1,
                                                _output0);

            return outputTotal;
        }

        public override string ToString()
        {
            return $"{_output0}-{_output1}";
        }
    }

    public class RandomAccessMemory2
    {
        private readonly RandomAccessMemory _ram0 = new RandomAccessMemory();
        private readonly RandomAccessMemory _ram1 = new RandomAccessMemory();

        public Byte2 Do(Bit2 address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.High);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.High, store);

            var output0 = _ram0.Do(address.Low, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address.Low, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.High,
                                                output1,
                                                output0);
            return outputTotal;
        }

        public override string ToString()
        {
            return $"{_ram0}-{_ram1}";
        }
    }

    public class RandomAccessMemory3
    {
        private readonly RandomAccessMemory2 _ram0 = new RandomAccessMemory2();
        private readonly RandomAccessMemory2 _ram1 = new RandomAccessMemory2();

        public Byte2 Do(Nibble address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.Two);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.Two, store);

            var output0 = _ram0.Do(address.Low, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address.Low, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.Two,
                                                output1,
                                                output0);
            return outputTotal;
        }

        public override string ToString()
        {
            return $"{_ram0}-{_ram1}";
        }
    }

    public class RandomAccessMemory4
    {
        private readonly RandomAccessMemory3 _ram0 = new RandomAccessMemory3();
        private readonly RandomAccessMemory3 _ram1 = new RandomAccessMemory3();

        public Byte2 Do(Nibble address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.Three);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.Three, store);

            var output0 = _ram0.Do(address, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.Three,
                                                output1,
                                                output0);
            return outputTotal;
        }

        public override string ToString()
        {
            return $"{_ram0}--{_ram1}";
        }
    }

    public class RandomAccessMemory5
    {
        private readonly RandomAccessMemory4 _ram0 = new RandomAccessMemory4();
        private readonly RandomAccessMemory4 _ram1 = new RandomAccessMemory4();

        public Byte2 Do(Byte address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.Four);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.Four, store);

            var output0 = _ram0.Do(address.Low, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address.Low, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.Four,
                                                output1,
                                                output0);
            return outputTotal;
        }

        public override string ToString()
        {
            return $"{_ram0}---{_ram1}";
        }
    }

    public class RandomAccessMemory6
    {
        private readonly RandomAccessMemory5 _ram0 = new RandomAccessMemory5();
        private readonly RandomAccessMemory5 _ram1 = new RandomAccessMemory5();

        public Byte2 Do(Byte address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.Five);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.Five, store);

            var output0 = _ram0.Do(address, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.Five,
                                                output1,
                                                output0);
            return outputTotal;
        }
    }

    public class RandomAccessMemory7
    {
        private readonly RandomAccessMemory6 _ram0 = new RandomAccessMemory6();
        private readonly RandomAccessMemory6 _ram1 = new RandomAccessMemory6();

        public Byte2 Do(Byte address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.Six);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.Six, store);

            var output0 = _ram0.Do(address, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.Six,
                                                output1,
                                                output0);
            return outputTotal;
        }
    }

    public class RandomAccessMemory8
    {
        private readonly RandomAccessMemory7 _ram0 = new RandomAccessMemory7();
        private readonly RandomAccessMemory7 _ram1 = new RandomAccessMemory7();

        public Byte2 Do(Byte address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.Seven);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.Seven, store);

            var output0 = _ram0.Do(address, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.Seven,
                                                output1,
                                                output0);
            return outputTotal;
        }
    }

    public class RandomAccessMemory9
    {
        private readonly RandomAccessMemory8 _ram0 = new RandomAccessMemory8();
        private readonly RandomAccessMemory8 _ram1 = new RandomAccessMemory8();

        public Byte2 Do(Byte2 address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.Eight);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.Eight, store);

            var output0 = _ram0.Do(address.Low, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address.Low, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.Eight,
                                                output1,
                                                output0);
            return outputTotal;
        }
    }

    public class RandomAccessMemory10
    {
        private readonly RandomAccessMemory9 _ram0 = new RandomAccessMemory9();
        private readonly RandomAccessMemory9 _ram1 = new RandomAccessMemory9();

        public Byte2 Do(Byte2 address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.Nine);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.Nine, store);

            var output0 = _ram0.Do(address, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.Nine,
                                                output1,
                                                output0);
            return outputTotal;
        }
    }

    public class RandomAccessMemory11
    {
        private readonly RandomAccessMemory10 _ram0 = new RandomAccessMemory10();
        private readonly RandomAccessMemory10 _ram1 = new RandomAccessMemory10();

        public Byte2 Do(Byte2 address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.Ten);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.Ten, store);

            var output0 = _ram0.Do(address, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.Ten,
                                                output1,
                                                output0);
            return outputTotal;
        }
    }

    public class RandomAccessMemory12
    {
        private readonly RandomAccessMemory11 _ram0 = new RandomAccessMemory11();
        private readonly RandomAccessMemory11 _ram1 = new RandomAccessMemory11();

        public Byte2 Do(Byte2 address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.Eleven);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.Eleven, store);

            var output0 = _ram0.Do(address, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.Eleven,
                                                output1,
                                                output0);
            return outputTotal;
        }
    }

    public class RandomAccessMemory13
    {
        private readonly RandomAccessMemory12 _ram0 = new RandomAccessMemory12();
        private readonly RandomAccessMemory12 _ram1 = new RandomAccessMemory12();

        public Byte2 Do(Byte2 address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.Twelve);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.Twelve, store);

            var output0 = _ram0.Do(address, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.Twelve,
                                                output1,
                                                output0);
            return outputTotal;
        }
    }

    public class RandomAccessMemory14
    {
        private readonly RandomAccessMemory13 _ram0 = new RandomAccessMemory13();
        private readonly RandomAccessMemory13 _ram1 = new RandomAccessMemory13();

        public Byte2 Do(Byte2 address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.Thirteen);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.Thirteen, store);

            var output0 = _ram0.Do(address, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.Thirteen,
                                                output1,
                                                output0);
            return outputTotal;
        }
    }

    public class RandomAccessMemory15
    {
        private readonly RandomAccessMemory14 _ram0 = new RandomAccessMemory14();
        private readonly RandomAccessMemory14 _ram1 = new RandomAccessMemory14();

        public Byte2 Do(Byte2 address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.Fourteen);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.Fourteen, store);

            var output0 = _ram0.Do(address, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.Fourteen,
                                                output1,
                                                output0);
            return outputTotal;
        }
    }

    public class RandomAccessMemory16
    {
        private readonly RandomAccessMemory15 _ram0 = new RandomAccessMemory15();
        private readonly RandomAccessMemory15 _ram1 = new RandomAccessMemory15();

        public Byte2 Do(Byte2 address, bool store, Byte2 data, bool clock)
        {
            var invertedAddress = Gates.Invert(address.Fifteen);
            var storeAtRam0 = Gates.And(invertedAddress, store);

            var storeAtRam1 = Gates.And(address.Fifteen, store);

            var output0 = _ram0.Do(address, storeAtRam0, data, clock);
            var output1 = _ram1.Do(address, storeAtRam1, data, clock);

            var outputTotal = Select16.Do(address.Fifteen,
                                                output1,
                                                output0);
            return outputTotal;
        }
    }

}