using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.PlumbingTests
{
    public class RandomAccessMemoryTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var ram = new RandomAccessMemory();
            var byte2 = new Byte2(42);

            // Act
            var output = ram.Do(false, false, byte2, false);

            // Assert
            output.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var ram = new RandomAccessMemory();
            var byte2 = new Byte2(42);

            // Act
            ram.Do(false, false, byte2, false);
            ram.Do(false, true, byte2, false);
            var output = ram.Do(false, false, byte2, false);

            // Assert
            output.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var ram = new RandomAccessMemory();
            var byte2 = new Byte2(42);

            // Act
            ram.Do(false, false, byte2, false);
            ram.Do(false, true, byte2, false);
            var output = ram.Do(false, false, byte2, true);

            // Assert
            output.ToInt16().Should().Be(42);
        }

        [Test]
        public void Test4()
        {
            // Arrange
            var ram = new RandomAccessMemory();
            var byte2 = new Byte2(42);

            // Act
            ram.Do(false, false, byte2, false);
            ram.Do(false, true, byte2, false);
            ram.Do(false, true, byte2, true);
            var output = ram.Do(false, false, byte2, false);

            // Assert
            output.ToInt16().Should().Be(42);
        }
    }
}