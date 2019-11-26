using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.ArithmeticsTests
{
    public class AddAddByte4Tests
    {
        [Test]
        public void Test_0_plus_0()
        {
            // Arrange
            var a = new Byte4(0);
            var b = new Byte4(0);

            // Act
            var byteResult = Arithmetics.AddByte4(a, b, false);

            // Assert
            byteResult.ToInt64().Should().Be(0);
        }

        [Test]
        public void Test_0_plus_1()
        {
            // Arrange
            var a = new Byte4(0);
            var b = new Byte4(1);

            // Act
            var byteResult = Arithmetics.AddByte4(a, b, false);

            // Assert
            byteResult.ToInt64().Should().Be(1);
        }

        [Test]
        public void Test_0_plus_65535()
        {
            // Arrange
            var byteA = new Byte4(0);
            var byteB = new Byte4(65535);

            // Act
            var byteResult = Arithmetics.AddByte4(byteA, byteB, false);

            // Assert
            byteResult.ToInt64().Should().Be(65535);
        }

        [Test]
        public void Test_1_plus_1()
        {
            // Arrange
            var a = new Byte4(1);
            var b = new Byte4(1);

            // Act
            var byteResult = Arithmetics.AddByte4(a, b, false);

            // Assert
            byteResult.ToInt64().Should().Be(2);
        }

        [Test]
        public void Test_3_plus_3()
        {
            // Arrange
            var a = new Byte4(3);
            var b = new Byte4(3);

            // Act
            var byteResult = Arithmetics.AddByte4(a, b, false);

            // Assert
            byteResult.ToInt64().Should().Be(6);
        }

        [Test]
        public void Test_15_plus_15()
        {
            // Arrange
            var byteA = new Byte4(15);
            var byteB = new Byte4(15);

            // Act
            var byteResult = Arithmetics.AddByte4(byteA, byteB, false);

            // Assert
            byteResult.ToInt64().Should().Be(30);
        }

        [Test]
        public void Test_255_plus_255()
        {
            // Arrange
            var byteA = new Byte4(255);
            var byteB = new Byte4(255);

            // Act
            var byteResult = Arithmetics.AddByte4(byteA, byteB, false);

            // Assert
            byteResult.ToInt64().Should().Be(510);
        }

        [Test]
        public void Test_65535_plus_65535()
        {
            // Arrange
            var byteA = new Byte4(65535);
            var byteB = new Byte4(65535);

            // Act
            var byteResult = Arithmetics.AddByte4(byteA, byteB, false);

            // Assert
            byteResult.ToInt64().Should().Be(131070);
        }

        [Test]
        public void Test_65535_plus_2147483647()
        {
            // Arrange
            var byteA = new Byte4(65535);
            var byteB = new Byte4(2147483647);

            // Act
            var byteResult = Arithmetics.AddByte4(byteA, byteB, false);

            // Assert
            byteResult.ToInt64().Should().Be(2147549182);
        }

        [Test]
        public void Test_2147483647_plus_2147483647()
        {
            // Arrange
            var byteA = new Byte4(2147483647);
            var byteB = new Byte4(2147483647);

            // Act
            var byteResult = Arithmetics.AddByte4(byteA, byteB, false);

            // Assert
            byteResult.ToInt64().Should().Be(4294967294);
        }
    }
}