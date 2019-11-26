using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.PlumbingTests
{
    public class DataFlipFlopTests
    {
        [Test]
        public void Test1()
        {
            var output = new DataFlipFlop().Do(false, false, false);
            output.Should().BeFalse();
        }

        [Test]
        public void Test2()
        {
            var output = new DataFlipFlop().Do(false, false, true);
            output.Should().BeFalse();
        }

        [Test]
        public void Test3()
        {
            var output = new DataFlipFlop().Do(false, true, false);
            output.Should().BeFalse();
        }

        [Test]
        public void Test4()
        {
            var output = new DataFlipFlop().Do(false, true, true);
            output.Should().BeFalse();
        }


        [Test]
        public void Test5()
        {
            var output = new DataFlipFlop().Do(true, false, false);
            output.Should().BeFalse();
        }

        [Test]
        public void Test6()
        {
            var output = new DataFlipFlop().Do(true, false, true);
            output.Should().BeFalse();
        }

        [Test]
        public void Test7()
        {
            var output = new DataFlipFlop().Do(true, true, false);
            output.Should().BeFalse();
        }

        [Test]
        public void Test8()
        {
            var output = new DataFlipFlop().Do(true, true, true);
            output.Should().BeFalse();
        }

        [Test]
        public void Test9()
        {
            var dataFlipFlop = new DataFlipFlop();

            dataFlipFlop.Do(true, false, false);
            dataFlipFlop.Do(true, true, false);
            var output = dataFlipFlop.Do(false, true, true);
            output.Should().BeTrue();
        }

        [Test]
        public void Test10()
        {
            var dataFlipFlop = new DataFlipFlop();

            dataFlipFlop.Do(true, false, false);
            dataFlipFlop.Do(true, true, false);
            dataFlipFlop.Do(false, true, false);
            dataFlipFlop.Do(false, false, false);
            var output = dataFlipFlop.Do(false, false, true);
            output.Should().BeTrue();
        }
    }
}