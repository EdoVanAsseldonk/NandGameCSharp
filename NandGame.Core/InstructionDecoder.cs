namespace NandGame.Core
{
    public static class InstructionDecoder
    {
        /// <summary>
        /// Bit 15 of the input indicates the kind of instruction:
        ///     Bit 15 | Instruction kind
        ///     -------+-----------------
        ///     0      | data
        ///     1      | computation
        ///
        /// For a data instruction, W(data word) should reflect the input, the a flag should be 1 and all other flags should be 0.
        /// For a computation instruction, the ci(computation instruction) flag should be 1, W should be 0. All other flags should be mapped from the bits in the input as follows:
        /// Input Output
        /// Bit Group   flag
        /// 14	(ignored)	-
        /// 13	(ignored)	-
        /// 12	source sm
        /// 11	computation zx
        /// 10	computation nx
        /// 9	computation zy
        /// 8	computation ny
        /// 7	computation f
        /// 6	computation no
        /// 5	destination a
        /// 4	destination d
        /// 3	destination* a
        /// 2	condition gt
        /// 1	condition eq
        /// 0	condition lt
        /// </summary>
        /// <param name="instruction"></param>
        /// <returns></returns>
        public static DecodedInstruction Decode(Byte2 instruction)
        {
            var isNegative = Arithmetics.IsLessThanZero(instruction);
            var inverted = Gates.Invert(isNegative);
            var s = Select16.Do(inverted, new Byte2(0), instruction);

            var instructionOrZero = Select16.Do(isNegative, new Byte2(0), instruction);

            return new DecodedInstruction(isNegative,
                                          s.Twelve,
                                          new Operation(s.Eleven, s.Ten, s.Nine, s.Eight, s.Seven, s.Six),
                                          new Destination(Gates.Or(inverted, s.Five), s.Four, s.Three),
                                          new Condition(s.Two, s.One, s.Zero),
                                          instructionOrZero);
        }

        public class Operation
        {
            public Operation(bool zx, bool nx, bool zy, bool ny, bool function, bool negateOutput)
            {
                this.zx = zx;
                this.nx = nx;
                this.zy = zy;
                this.ny = ny;
                Function = function;
                NegateOutput = negateOutput;
            }

            public bool zx { get; set; }

            public bool nx { get; set; }

            public bool zy { get; set; }

            public bool ny { get; set; }

            /// <summary>
            /// selects an operation:
            /// 0: output is X AND Y
            /// 1: output is X + Y
            /// </summary>
            public bool Function { get; set; }

            public bool NegateOutput { get; set; }

            public override string ToString()
            {
                var output = string.Empty;

                if (zx)
                {
                    output += "Set X to zero; ";
                }

                if (nx)
                {
                    output += "Negate X; ";
                }

                if (zy)
                {
                    output += "Set Y to zero; ";
                }

                if (ny)
                {
                    output += "Negate Y; ";
                }

                if (Function)
                {
                    output += "X + Y; ";
                }
                else
                {
                    output += "X AND Y; ";
                }

                if (NegateOutput)
                {
                    output += "Negate output;";
                }

                return output;
            }
        }

        public class Destination
        {
            public Destination(bool a, bool d, bool ram)
            {
                A = a;
                D = d;
                Ram = ram;
            }

            public bool A { get; set; }

            public bool D { get; set; }

            public bool Ram { get; set; }
        }

        public class DecodedInstruction
        {
            public DecodedInstruction(bool computationInstruction,
                                      bool sourceMemory,
                                      Operation operation,
                                      Destination destination,
                                      Condition condition,
                                      Byte2 w)
            {
                ComputationInstruction = computationInstruction;
                SourceMemory = sourceMemory;
                Operation = operation;
                Destination = destination;
                Condition = condition;
                this.w = w;
            }

            public bool ComputationInstruction { get; set; }

            public bool SourceMemory { get; set; }

            public Operation Operation { get; set; }

            public Destination Destination { get; set; }

            public Condition Condition { get; }

            public Byte2 w { get; set; }
        }
    }
}
