using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.ArithmeticsTests
{
    public class IncrementTests
    {
        [Test]
        public void Test_0_increment()
        {
            // Arrange
            var a = new Byte2(0);

            // Act
            var byteResult = Arithmetics.Increment(a);

            // Assert
            byteResult.ToInt16().Should().Be(1);
        }

        [Test]
        public void Test_1_increment()
        {
            // Arrange
            var a = new Byte2(1);

            // Act
            var byteResult = Arithmetics.Increment(a);

            // Assert
            byteResult.ToInt16().Should().Be(2);
        }

        [Test]
        public void Test_minus_1_increment()
        {
            // Arrange
            var a = new Byte2(-1);

            // Act
            var byteResult = Arithmetics.Increment(a);

            // Assert
            byteResult.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test_MaxValue_increment()
        {
            // Arrange
            var a = new Byte2(short.MaxValue);

            // Act
            var byteResult = Arithmetics.Increment(a);

            // Assert
            byteResult.ToInt16().Should().Be(short.MinValue);
        }

        [Test]
        public void Test_MinValue_increment()
        {
            // Arrange
            var a = new Byte2(short.MinValue);

            // Act
            var byteResult = Arithmetics.Increment(a);

            // Assert
            byteResult.ToInt16().Should().Be(short.MinValue + 1);
        }
    }
}