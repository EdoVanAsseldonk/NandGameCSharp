using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.PlumbingTests
{
    public class LatchTests
    {
        //Input         Effect          Output
        //  st  d
        //  1	0	    set out to 0	out
        //  1	1	    set out to 1	out
        //  0	1	    -	            out
        //  0	0	    -	            out

        [Test]
        public void Test1()
        {
            var output = new Latch().Do(true, false);
            output.Should().BeFalse();
        }

        [Test]
        public void Test2()
        {
            var output = new Latch().Do(true, true);
            output.Should().BeTrue();
        }

        [Test]
        public void Test3()
        {
            var output = new Latch().Do(false, true);

            output.Should().BeFalse();
        }

        [Test]
        public void Test4()
        {
            var output = new Latch().Do(false, false);
            output.Should().BeFalse();
        }

        [Test]
        public void Test5()
        {
            // Arrange
            var latch = new Latch();

            // Act
            latch.Do(false, false);
            latch.Do(true, false);
            var output = latch.Do(true, true);

            // Assert
            output.Should().BeTrue();
        }

        [Test]
        public void Test6()
        {
            // Arrange
            var latch = new Latch();

            // Act
            latch.Do(false, false);
            latch.Do(true, false);
            latch.Do(true, true);
            var output = latch.Do(false, true);

            // Assert
            output.Should().BeTrue();
        }

        [Test]
        public void Test7()
        {
            // Arrange
            var latch = new Latch();

            // Act
            latch.Do(false, false);
            latch.Do(true, false);
            latch.Do(true, true);
            latch.Do(false, true);
            var output = latch.Do(false, false);

            // Assert
            output.Should().BeTrue();
        }
    }
}