using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.ArithmeticsTests
{
    public class AddTests
    {
        [Test]
        public void Test_0_plus_0_plus_0()
        {
            var res = Arithmetics.Add(false, false, false);

            res.High.Should().BeFalse();
            res.Low.Should().BeFalse();
        }

        [Test]
        public void Test_0_plus_0_plus_1()
        {
            var res = Arithmetics.Add(false, false, true);

            res.High.Should().BeFalse();
            res.Low.Should().BeTrue();
        }

        [Test]
        public void Test_0_plus_1_plus_0()
        {
            var res = Arithmetics.Add(false, true, false);

            res.High.Should().BeFalse();
            res.Low.Should().BeTrue();
        }

        [Test]
        public void Test_0_plus_1_plus_1()
        {
            var res = Arithmetics.Add(false, true, true);

            res.High.Should().BeTrue();
            res.Low.Should().BeFalse();
        }

        [Test]
        public void Test_1_plus_0_plus_0()
        {
            var res = Arithmetics.Add(true, false, false);

            res.High.Should().BeFalse();
            res.Low.Should().BeTrue();
        }

        [Test]
        public void Test_1_plus_0_plus_1()
        {
            var res = Arithmetics.Add(true, false, true);

            res.High.Should().BeTrue();
            res.Low.Should().BeFalse();
        }

        [Test]
        public void Test_1_plus_1_plus_0()
        {
            var res = Arithmetics.Add(true, true, false);

            res.High.Should().BeTrue();
            res.Low.Should().BeFalse();
        }

        [Test]
        public void Test_1_plus_1_plus_1()
        {
            var res = Arithmetics.Add(true, true, true);

            res.High.Should().BeTrue();
            res.Low.Should().BeTrue();
        }
    }
}
