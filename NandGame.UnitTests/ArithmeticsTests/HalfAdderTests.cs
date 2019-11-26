using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.ArithmeticsTests
{
    public class HalfAdderTests
    {
        [Test]
        public void Test_0_plus_0()
        {
            var res = Arithmetics.HalfAdder(false, false);

            res.High.Should().BeFalse();
            res.Low.Should().BeFalse();
        }

        [Test]
        public void Test_0_plus_1()
        {
            var res = Arithmetics.HalfAdder(false, true);

            res.High.Should().BeFalse();
            res.Low.Should().BeTrue();
        }

        [Test]
        public void Test_1_plus_0()
        {
            var res = Arithmetics.HalfAdder(true, false);

            res.High.Should().BeFalse();
            res.Low.Should().BeTrue();
        }

        [Test]
        public void Test_1_plus_1()
        {
            var res = Arithmetics.HalfAdder(true, true);

            res.High.Should().BeTrue();
            res.Low.Should().BeFalse();
        }
    }
}