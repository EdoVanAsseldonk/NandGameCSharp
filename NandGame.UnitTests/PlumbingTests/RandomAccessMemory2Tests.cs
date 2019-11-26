using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.PlumbingTests
{
    public class RandomAccessMemory2Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var ram = new RandomAccessMemory2();
            var byte2 = new Byte2(42);
            var address = new Bit2(false, false);

            // Act
            var output = ram.Do(address, true, byte2, false);

            // Assert
            output.ToInt16().Should().Be(0);
        }



        [Test]
        public void Test4()
        {
            // Arrange
            var ram = new RandomAccessMemory2();
            var byte2 = new Byte2(42);
            var address = new Bit2(false, false);

            // Act
            ram.Do(address, false, byte2, false);
            ram.Do(address, true, byte2, false);
            ram.Do(address, true, byte2, true);
            var output = ram.Do(address, false, byte2, false);

            // Assert
            output.ToInt16().Should().Be(42);
        }

        [Test]
        public void Store_different_values_at_different_addresses()
        {
            // Arrange
            var ram = new RandomAccessMemory2();
            var byte2A = new Byte2(42);
            var byte2B = new Byte2(3);
            var byte2C = new Byte2(999);

            var addressA = new Bit2(false, false);
            var addressB = new Bit2(false, true);

            // Act
            ram.Do(addressA, false, byte2A, false);
            ram.Do(addressA, true, byte2A, false);
            ram.Do(addressA, true, byte2A, true);

            ram.Do(addressB, true, byte2B, false);
            ram.Do(addressB, true, byte2B, true);

            var output = ram.Do(addressA, false, byte2C, false);

            // Assert
            output.ToInt16().Should().Be(42);
        }

        [Test]
        public void Store_different_values_at_different_addresses2()
        {
            // Arrange
            var ram = new RandomAccessMemory2();
            var byte2A = new Byte2(42);
            var byte2B = new Byte2(3);
            var byte2C = new Byte2(999);

            var addressA = new Bit2(false, false);
            var addressB = new Bit2(true, true);

            // Act
            ram.Do(addressA, false, byte2A, false);
            ram.Do(addressA, true, byte2A, false);
            ram.Do(addressA, true, byte2A, true);

            ram.Do(addressB, true, byte2B, false);
            ram.Do(addressB, true, byte2B, true);

            var output = ram.Do(addressB, false, byte2C, false);

            // Assert
            output.ToInt16().Should().Be(3);
        }

        [Test]
        public void Store_different_values_at_different_addresses3()
        {
            // Arrange
            var ram = new RandomAccessMemory4();
            var byte2A = new Byte2(42);
            var byte2B = new Byte2(3);
            var byte2C = new Byte2(999);

            var addressA = new Nibble(2);
            var addressB = new Nibble(7);

            // Act
            ram.Do(addressA, false, byte2A, false);
            ram.Do(addressA, true, byte2A, false);
            ram.Do(addressA, true, byte2A, true);

            ram.Do(addressB, true, byte2B, false);
            ram.Do(addressB, true, byte2B, true);

            var output = ram.Do(addressB, false, byte2C, false);

            // Assert
            output.ToInt16().Should().Be(3);
        }

        [Test]
        public void Store_different_values_at_different_addresses4()
        {
            // Arrange
            var ram = new RandomAccessMemory5();
            var byte2A = new Byte2(42);
            var byte2B = new Byte2(3);
            var byte2C = new Byte2(999);

            var addressA = new Byte(2);
            var addressB = new Byte(255);

            // Act
            ram.Do(addressA, false, byte2A, false);
            ram.Do(addressA, true, byte2A, false);
            ram.Do(addressA, true, byte2A, true);

            ram.Do(addressB, true, byte2B, false);
            ram.Do(addressB, true, byte2B, true);

            var output = ram.Do(addressB, false, byte2C, false);

            // Assert
            output.ToInt16().Should().Be(3);
        }
    }
}