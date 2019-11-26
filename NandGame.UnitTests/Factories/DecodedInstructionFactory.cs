using NandGame.Core;

namespace NandGame.UnitTests.Factories
{
    public static class DecodedInstructionFactory
    {
        public static Byte2 CreateDataInstruction(Byte2 data)
        {
            return new Byte2("0" + data.ToString().Substring(1,15));
        }

        public static Byte2 CreateComputationInstruction(Byte2 data)
        {
            return new Byte2("1" + data.ToString().Substring(1, 15));
        }
    }
}