namespace NandGame.Core
{
    public static class UnaryArithmeticLogicUnit
    {
        public static Byte2 Do(bool zero, bool negate, Byte2 data)
        {
            var selectZero = Select16.Do(zero, new Byte2(0), data);

            var selectNegate = Select16.Do(negate, Gates.Invert16(selectZero), selectZero);

            return selectNegate;
        }
    }
}
