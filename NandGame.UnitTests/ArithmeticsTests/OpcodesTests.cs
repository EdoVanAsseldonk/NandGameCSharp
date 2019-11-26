using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.ArithmeticsTests
{
    public class OpcodesTests
    {
        [Test]
        public void X_should_return_X()
        {
            // Arrange
            var opcodeX = Opcodes.X();

            // Act
            var output = ArithmeticLogicUnit.Do(opcodeX, new Byte2(42), new Byte2(127));

            // Assert
            output.ToInt16().Should().Be(42);
        }

        [Test]
        public void Y_should_return_Y()
        {
            // Arrange
            var opcodeX = Opcodes.Y();

            // Act
            var output = ArithmeticLogicUnit.Do(opcodeX, new Byte2(42), new Byte2(127));

            // Assert
            output.ToInt16().Should().Be(127);
        }

        [Test]
        public void XandY_should_return_bitwise_and()
        {
            // Arrange
            var opcodeX = Opcodes.XandY();

            // Act
            var output = ArithmeticLogicUnit.Do(opcodeX, new Byte2("0000000010010011"), new Byte2("0000000010100011"));

            // Assert
            output.ToString().Should().Be("0000000010000011");
        }

        [Test]
        public void XorY_should_return_bitwise_or()
        {
            // Arrange
            var opcodeX = Opcodes.XorY();

            // Act
            var output = ArithmeticLogicUnit.Do(opcodeX, new Byte2("1000000000000001"), new Byte2("0100000000000011"));

            // Assert
            output.ToString().Should().Be("1100000000000011");
        }

        [Test]
        public void Bitwise_complement_x_should_return_negative_x_minus_1()
        {
            // Arrange
            var opcodeX = Opcodes.ComplementX();

            // Act
            var output = ArithmeticLogicUnit.Do(opcodeX, new Byte2(27), new Byte2(42));

            // Assert
            output.ToInt16().Should().Be(-28);
        }

        [Test]
        public void Bitwise_complement_y_should_return_negative_y_minus_1()
        {
            // Arrange
            var opcode = Opcodes.ComplementY();

            // Act
            var output = ArithmeticLogicUnit.Do(opcode, new Byte2(27), new Byte2(42));

            // Assert
            output.ToInt16().Should().Be(-43);
        }

        [Test]
        public void Add_should_return_x_plus_y()
        {
            // Arrange
            var opcode = Opcodes.Add();

            // Act
            var output = ArithmeticLogicUnit.Do(opcode, new Byte2(27), new Byte2(45));

            // Assert
            output.ToInt16().Should().Be(72);
        }
    }
}