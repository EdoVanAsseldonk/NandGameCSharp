using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.ArithmeticsTests
{
    public class SubtractTests
    {
        [Test]
        public void Test_0_subtract_0()
        {
            // Arrange
            var a = new Byte2(0);
            var b = new Byte2(0);

            // Act
            var byteResult = Arithmetics.Subtract(a, b);

            // Assert
            byteResult.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test_0_subtract_1()
        {
            // Arrange
            var a = new Byte2(0);
            var b = new Byte2(1);

            // Act
            var byteResult = Arithmetics.Subtract(a, b);

            // Assert
            byteResult.ToInt16().Should().Be(-1);
        }


        [Test]
        public void Test_0_subtract_minus_1()
        {
            // Arrange
            var a = new Byte2(0);
            var b = new Byte2(-1);

            // Act
            var byteResult = Arithmetics.Subtract(a, b);

            // Assert
            byteResult.ToInt16().Should().Be(1);
        }

        [Test]
        public void Test_0_subtract_maxvalue()
        {
            // Arrange
            var a = new Byte2(0);
            var b = new Byte2(short.MaxValue);

            // Act
            var byteResult = Arithmetics.Subtract(a, b);

            // Assert
            byteResult.ToInt16().Should().Be(short.MinValue + 1);
        }

        [Test]
        public void Test_0_subtract_minvalue()
        {
            // Arrange
            var a = new Byte2(0);
            var b = new Byte2(short.MinValue);

            // Act
            var byteResult = Arithmetics.Subtract(a, b);

            // Assert
            byteResult.ToInt16().Should().Be(short.MinValue);
        }

        [Test]
        public void Test_MinValue_subtract_1()
        {
            // Arrange
            var a = new Byte2(short.MinValue);
            var b = new Byte2(1);

            // Act
            var byteResult = Arithmetics.Subtract(a, b);

            // Assert
            byteResult.ToInt16().Should().Be(short.MaxValue);
        }
    }
}