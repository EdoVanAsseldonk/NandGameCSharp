namespace NandGame.Core
{
    public static class Gates
    {
        public static bool Nand(bool a, bool b)
        {
            return !(a && b);
        }

        public static bool Invert(bool a)
        {
            return Nand(a, a);
        }

        public static Bit2 Invert2(Bit2 a)
        {
            return new Bit2(Invert(a.High), Invert(a.Low));
        }

        public static Nibble Invert4(Nibble a)
        {
            return new Nibble(Invert2(a.High), Invert2(a.Low));
        }

        public static Byte Invert8(Byte a)
        {
            return new Byte(Invert4(a.High), Invert4(a.Low));
        }

        public static Byte2 Invert16(Byte2 a)
        {
            return new Byte2(Invert8(a.High), Invert8(a.Low));
        }

        public static bool And(bool a, bool b)
        {
            return Nand(Nand(a, b),
                        Nand(a, b));
        }

        public static Bit2 And2(Bit2 a, Bit2 b)
        {
            return new Bit2(And(a.High, b.High),
                            And(a.Low, b.Low));
        }

        public static Nibble And4(Nibble a, Nibble b)
        {
            return new Nibble(And2(a.High, b.High),
                              And2(a.Low, b.Low));
        }

        public static Byte And8(Byte a, Byte b)
        {
            return new Byte(And4(a.High, b.High),
                            And4(a.Low, b.Low));
        }

        public static Byte2 And16(Byte2 a, Byte2 b)
        {
            return new Byte2(And8(a.High, b.High),
                             And8(a.Low, b.Low));
        }

        public static bool Or(bool a, bool b)
        {
            return Nand(Nand(a, a), 
                        Nand(b, b));
        }


        public static bool Xor(bool a, bool b)
        {
            var nandAb = Nand(a, b);
            var nand2 = Nand(a, nandAb);
            var nand3 = Nand(b, nandAb);

            return Nand(nand2, nand3);
        }
    }
}