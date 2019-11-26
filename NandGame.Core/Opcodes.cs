namespace NandGame.Core
{
    public static class Opcodes
    {
        public static InstructionDecoder.Operation X()
        {
            return new InstructionDecoder.Operation(false, false, true, false, true, false);
        }

        public static InstructionDecoder.Operation Y()
        {
            return new InstructionDecoder.Operation(true, false, false, false, true, false);
        }

        public static InstructionDecoder.Operation XandY()
        {
            return new InstructionDecoder.Operation(false, false, false, false, false, false);
        }

        public static InstructionDecoder.Operation XorY()
        {
            return new InstructionDecoder.Operation(false, true, false, true, false, true);
        }

        public static InstructionDecoder.Operation ComplementX()
        {
            return new InstructionDecoder.Operation(false, true, true, false, true, false);
        }

        public static InstructionDecoder.Operation ComplementY()
        {
            return new InstructionDecoder.Operation(true, true, false, true, false, false);
        }

        public static InstructionDecoder.Operation Add()
        {
            return new InstructionDecoder.Operation(false, false, false, false, true, false);
        }
    }
}