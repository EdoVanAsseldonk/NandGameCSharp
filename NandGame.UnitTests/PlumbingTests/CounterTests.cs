using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.PlumbingTests
{
    public class CounterTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var counter = new Counter();
            var byte2 = new Byte2(0);

            // Act
            var output = counter.Do(false, byte2, false);

            // Assert
            output.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var counter = new Counter();
            var data = new Byte2(0);

            // Act
            counter.Do(false, data, false);
            var output = counter.Do(false, data, true);

            // Assert
            output.ToInt16().Should().Be(1);
        }


        [Test]
        public void Test3()
        {
            // Arrange
            var counter = new Counter();
            var data = new Byte2(0);

            // Act
            counter.Do(false, data, false);
            counter.Do(false, data, true);
            counter.Do(false, data, false);
            counter.Do(false, data, true);
            counter.Do(false, data, false);
            counter.Do(false, data, true);
            var output = counter.Do(false, data, false);

            // Assert
            output.ToInt16().Should().Be(3);
        }

        [Test]
        public void Test4()
        {
            // Arrange
            var counter = new Counter();
            var data = new Byte2(0);

            // Act
            counter.Do(true, data, false);
            counter.Do(true, data, true);
            counter.Do(true, data, false);
            counter.Do(true, data, true);
            counter.Do(true, data, false);
            counter.Do(true, data, true);
            var output = counter.Do(false, data, false);

            // Assert
            output.ToInt16().Should().Be(0);
        }
    }
}