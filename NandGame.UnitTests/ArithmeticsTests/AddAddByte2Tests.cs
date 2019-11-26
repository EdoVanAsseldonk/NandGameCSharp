using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.ArithmeticsTests
{
    public class AddAddByte2Tests
    {
        [Test]
        public void Test_0_plus_0()
        {
            // Arrange
            var a = new Byte2(0);
            var b = new Byte2(0);

            // Act
            var byteResult = Arithmetics.AddByte2(a, b, false);

            // Assert
            byteResult.ToInt32().Should().Be(0);
        }

        [Test]
        public void Test_0_plus_1()
        {
            // Arrange
            var a = new Byte2(0);
            var b = new Byte2(1);

            // Act
            var byteResult = Arithmetics.AddByte2(a, b, false);

            // Assert
            byteResult.ToInt32().Should().Be(1);
        }

        [Test]
        public void Test_0_plus_32767()
        {
            // Arrange
            var byteA = new Byte2(0);
            var byteB = new Byte2(32767);

            // Act
            var byteResult = Arithmetics.AddByte2(byteA, byteB, false);

            // Assert
            byteResult.ToInt32().Should().Be(32767);
        }

        [Test]
        public void Test_1_plus_1()
        {
            // Arrange
            var a = new Byte2(1);
            var b = new Byte2(1);

            // Act
            var byteResult = Arithmetics.AddByte2(a, b, false);

            // Assert
            byteResult.ToInt32().Should().Be(2);
        }

        [Test]
        public void Test_3_plus_3()
        {
            // Arrange
            var a = new Byte2(3);
            var b = new Byte2(3);

            // Act
            var byteResult = Arithmetics.AddByte2(a, b, false);

            // Assert
            byteResult.ToInt32().Should().Be(6);
        }

        [Test]
        public void Test_15_plus_15()
        {
            // Arrange
            var byteA = new Byte2(15);
            var byteB = new Byte2(15);

            // Act
            var byteResult = Arithmetics.AddByte2(byteA, byteB, false);

            // Assert
            byteResult.ToInt32().Should().Be(30);
        }

        [Test]
        public void Test_255_plus_255()
        {
            // Arrange
            var byteA = new Byte2(255);
            var byteB = new Byte2(255);

            // Act
            var byteResult = Arithmetics.AddByte2(byteA, byteB, false);

            // Assert
            byteResult.ToInt32().Should().Be(510);
        }

        [Test]
        public void Test_32767_plus_32767()
        {
            // Arrange
            var byteA = new Byte2(32767);
            var byteB = new Byte2(32767);

            // Act
            var byteResult = Arithmetics.AddByte2(byteA, byteB, false);

            // Assert
            byteResult.ToInt32().Should().Be(65534);
        }
    }
}