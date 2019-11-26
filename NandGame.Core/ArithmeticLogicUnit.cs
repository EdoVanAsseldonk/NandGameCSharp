namespace NandGame.Core
{
    public static class ArithmeticLogicUnit
    {
        public static Byte2 Do(InstructionDecoder.Operation operation,
                               Byte2 dataX,
                               Byte2 dataY)
        {
            var transformedDataX = UnaryArithmeticLogicUnit.Do(operation.zx, operation.nx, dataX);

            var transformedDataY = UnaryArithmeticLogicUnit.Do(operation.zy, operation.ny, dataY);

            var and = Gates.And16(transformedDataX, transformedDataY);

            var add = Arithmetics.AddByte2(transformedDataX, transformedDataY, false);

            var selected = Select16.Do(operation.Function, add.Low, and);

            var inverted = Gates.Invert16(selected);

            var output = Select16.Do(operation.NegateOutput, inverted, selected);

            return output;
        }

        public static bool Evaluate(Condition condition, Byte2 data)
        {
            var isLessThanZero = Arithmetics.IsLessThanZero(data);
            var andIsLessThanZero = Gates.And(condition.LessThanZero, isLessThanZero);

            var equalsZero = Arithmetics.EqualsZero(data);
            var andIsEqualToZero = Gates.And(condition.EqualToZero, equalsZero);

            var isGreaterThanZero = Gates.And(condition.GreaterThanZero,
                                              Gates.And(Gates.Invert(isLessThanZero),
                                                        Gates.Invert(equalsZero)));

            var lessOrEqual = Gates.Or(andIsLessThanZero, andIsEqualToZero);

            var lessOrEqualOrGreater = Gates.Or(lessOrEqual, isGreaterThanZero);

            return lessOrEqualOrGreater;
        }
    }
}