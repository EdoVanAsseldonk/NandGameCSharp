using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.PlumbingTests
{
    //      Input                                   Output
    //      zx  nx  zy  ny  f   no  X   Y
    //1     1	0	1	0	1	0	27	65532	    0	    ✔
    //2     1	1	1	1	1	1	27	65532	    1	    ✔
    //3     1	1	1	0	1	0	27	65532	    65535	✔
    //4     0	0	1	1	0	0	27	65532	    27	    ✔
    //5     1	1	0	0	0	0	27	65532	    65532	✔
    //6     0	0	1	1	0	1	27	65520	    65508	✔
    //7     1	1	0	0	0	1	27	65520	    15	    ✔
    //8     0	0	1	1	1	1	27	65532	    65509	✔
    //9     1	1	0	0	1	1	27	65532	    4	    ✔
    //10    0	1	1	1	1	1	27	65532	    28	    ✔
    public class ArithmeticLogicUnitTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var byte2X = new Byte2(27);
            var byte2Y = new Byte2(-4);
            var operation = new InstructionDecoder.Operation(true, false, true, false, true, false);

            // Act
            var output = ArithmeticLogicUnit.Do(operation, byte2X, byte2Y);

            // Assert
            output.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var byte2X = new Byte2(27);
            var byte2Y = new Byte2(-4);
            var operation = new InstructionDecoder.Operation(true, true, true, true, true, true);

            // Act
            var output = ArithmeticLogicUnit.Do(operation, byte2X, byte2Y);

            // Assert
            output.ToInt16().Should().Be(1);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var byte2X = new Byte2(27);
            var byte2Y = new Byte2(-4);
            var operation = new InstructionDecoder.Operation(true, true, true, false, true, false);

            // Act
            var output = ArithmeticLogicUnit.Do(operation, byte2X, byte2Y);

            // Assert
            output.ToInt16().Should().Be(-1);
        }

        [Test]
        public void Test4()
        {
            // Arrange
            var byte2X = new Byte2(27);
            var byte2Y = new Byte2(-4);
            var operation = new InstructionDecoder.Operation(false, false, true, true, false, false);

            // Act
            var output = ArithmeticLogicUnit.Do(operation, byte2X, byte2Y);

            // Assert
            output.ToInt16().Should().Be(27);
        }

        [Test]
        public void Test5()
        {
            // Arrange
            var byte2X = new Byte2(27);
            var byte2Y = new Byte2(-4);
            var operation = new InstructionDecoder.Operation(true, true, false, false, false, false);

            // Act
            var output = ArithmeticLogicUnit.Do(operation, byte2X, byte2Y);

            // Assert
            output.ToUInt16().Should().Be(65532);
        }

        [Test]
        public void Test6()
        {
            // Arrange
            var byte2X = new Byte2(27);
            var byte2Y = new Byte2(-16);
            var operation = new InstructionDecoder.Operation(false, false, true, true, false, true);

            // Act
            var output = ArithmeticLogicUnit.Do(operation, byte2X, byte2Y);

            // Assert
            output.ToUInt16().Should().Be(65508);
        }

        [Test]
        public void Test7()
        {
            // Arrange
            var byte2X = new Byte2(27);
            var byte2Y = new Byte2(-16);
            var operation = new InstructionDecoder.Operation(true, true, false, false, false, true);

            // Act
            var output = ArithmeticLogicUnit.Do(operation, byte2X, byte2Y);

            // Assert
            output.ToUInt16().Should().Be(15);
        }

        [Test]
        public void Test8()
        {
            // Arrange
            var byte2X = new Byte2(27);
            var byte2Y = new Byte2(-4);
            var operation = new InstructionDecoder.Operation(false, false, true, true, true, true);

            // Act
            var output = ArithmeticLogicUnit.Do(operation, byte2X, byte2Y);

            // Assert
            output.ToUInt16().Should().Be(65509);
        }

        [Test]
        public void Test9()
        {
            // Arrange
            var byte2X = new Byte2(27);
            var byte2Y = new Byte2(-4);
            var operation = new InstructionDecoder.Operation(true, true, false, false, true, true);

            // Act
            var output = ArithmeticLogicUnit.Do(operation, byte2X, byte2Y);

            // Assert
            output.ToUInt16().Should().Be(4);
        }

        [Test]
        public void Test10()
        {
            // Arrange
            var byte2X = new Byte2(27);
            var byte2Y = new Byte2(-4);
            var operation = new InstructionDecoder.Operation(false, true, true, true, true, true);

            // Act
            var output = ArithmeticLogicUnit.Do(operation, byte2X, byte2Y);

            // Assert
            output.ToUInt16().Should().Be(28);
        }
    }
}
