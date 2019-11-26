namespace NandGame.Core
{
    public static class Select
    {

        public static bool Do(bool s, bool d1, bool d0)
        {
            var nand1 = Gates.Nand(s, d1);

            var nand2 = Gates.Nand(Gates.Invert(s), d0);

            return Gates.Nand(nand1, nand2);
        }
    }
}