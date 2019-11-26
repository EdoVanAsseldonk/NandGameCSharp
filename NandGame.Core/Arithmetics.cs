namespace NandGame.Core
{
    public static class Arithmetics
    {
        public static Bit2 HalfAdder(bool a, bool b)
        {
            var nandAb = Gates.Nand(a, b);

            var nand1 = Gates.Nand(a, nandAb);
            var nand2 = Gates.Nand(b, nandAb);

            var nand3 = Gates.Nand(nand1, nand2);

            var nand5 = Gates.Nand(nandAb, nandAb);

            return new Bit2(nand5, nand3);
        }

        public static Bit2 Add(bool a, bool b, bool c)
        {
            var xorAb = Gates.Xor(a, b);

            var xorAbc = Gates.Xor(xorAb, c);

            var and = Gates.And(xorAb, c);

            var andAb = Gates.And(a, b);

            return new Bit2(Gates.Or(and, andAb), xorAbc);
        }

        public static Nibble AddTwoBits(Bit2 a, Bit2 b, bool c)
        {
            var add1 = Add(a.Low, b.Low, c);

            var add2 = Add(a.High, b.High, add1.High);

            return new Nibble(new Bit2(false, add2.High), new Bit2(add2.Low, add1.Low));
        }

        public static Byte AddNibble(Nibble a, Nibble b, bool c)
        {
            var add1 = AddTwoBits(a.Low, b.Low, c);

            var add2 = AddTwoBits(a.High, b.High, add1.Two);


            var high = new Nibble(new Bit2(false, false),
                                  new Bit2(add2.High.High, add2.High.Low));

            var low = new Nibble(new Bit2(add2.Low.High, add2.Low.Low),
                                 new Bit2(add1.Low.High, add1.Low.Low));

            var nibble = new Byte(high, low);

            return nibble;
        }

        public static Byte2 AddByte(Byte a, Byte b, bool c)
        {
            var addLow = AddNibble(a.Low, b.Low, c);

            var addHigh = AddNibble(a.High, b.High, addLow.Four);

            var high = new Byte(new Nibble(new Bit2(false, false),
                                           new Bit2(false, false)),
                                addHigh.High);

            var low = new Byte(addHigh.Low,
                               addLow.Low);

            var byte2 = new Byte2(high, low);

            return byte2;
        }

        public static Byte4 AddByte2(Byte2 a, Byte2 b, bool c)
        {
            var addLow = AddByte(a.Low, b.Low, c);

            var addHigh = AddByte(a.High, b.High, addLow.Eight);

            var emptyByte = new Byte(new Nibble(new Bit2(false, false),
                                                new Bit2(false, false)),
                                     new Nibble(new Bit2(false, false),
                                                new Bit2(false, false)));

            var high = new Byte2(emptyByte,
                                 addHigh.High);

            var low = new Byte2(addHigh.Low,
                                addLow.Low);

            var byte4 = new Byte4(high, low);

            return byte4;
        }

        public static Byte8 AddByte4(Byte4 a, Byte4 b, bool c)
        {
            var addLow = AddByte2(a.Low, b.Low, c);

            var addHigh = AddByte2(a.High, b.High, addLow.Sixteen);

            var emptyByte = new Byte(new Nibble(new Bit2(false, false),
                                                new Bit2(false, false)),
                                     new Nibble(new Bit2(false, false),
                                                new Bit2(false, false)));
            var emptyByte2 = new Byte2(emptyByte, emptyByte);

            var high = new Byte4(emptyByte2,
                                 addHigh.High);

            var low = new Byte4(addHigh.Low,
                                addLow.Low);

            var byte8 = new Byte8(high, low);

            return byte8;
        }

        public static Byte2 Increment(Byte2 a)
        {
            return AddByte2(a, new Byte2(1), false).Low;
        }

        public static Byte2 Subtract(Byte2 a, Byte2 b)
        {
            var inverted = Gates.Invert16(b);
            var incremented = Increment(inverted);

            return AddByte2(a, incremented, false).Low;
        }

        public static bool EqualsZero(Bit2 a)
        {
            var orA = Gates.Or(a.High, a.Low);
            return Gates.Invert(orA);
        }

        public static bool EqualsZero(Nibble a)
        {
            var eq0high = EqualsZero(a.High);
            var eq0low = EqualsZero(a.Low);

            return Gates.And(eq0high, eq0low);
        }

        public static bool EqualsZero(Byte a)
        {
            var eq0high = EqualsZero(a.High);
            var eq0low = EqualsZero(a.Low);

            return Gates.And(eq0high, eq0low);
        }

        public static bool EqualsZero(Byte2 a)
        {
            var eq0high = EqualsZero(a.High);
            var eq0low = EqualsZero(a.Low);

            return Gates.And(eq0high, eq0low);
        }

        public static bool IsLessThanZero(Byte2 a)
        {
            return a.Fifteen;
        }
    }
}
