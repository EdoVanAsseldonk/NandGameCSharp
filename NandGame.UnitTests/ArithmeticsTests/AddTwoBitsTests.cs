using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.ArithmeticsTests
{
    public class AddTwoBitsTests
    {
        [Test]
        public void Test_0_plus_0_plus_0()
        {
            var nibble = Arithmetics.AddTwoBits(new Bit2(false, false), new Bit2(false, false), false);

            nibble.High.Low.Should().BeFalse();
            nibble.Low.High.Should().BeFalse();
            nibble.Low.Low.Should().BeFalse();
        }

        [Test]
        public void Test_0_plus_0_plus_1()
        {
            var res = Arithmetics.AddTwoBits(new Bit2(false, false), new Bit2(false, false), true);

            res.High.Low.Should().BeFalse();
            res.Low.High.Should().BeFalse();
            res.Low.Low.Should().BeTrue();
        }

        [Test]
        public void Test_0_plus_1_plus_0()
        {
            var res = Arithmetics.AddTwoBits(new Bit2(false, false), new Bit2(false, true), false);

            res.High.Low.Should().BeFalse();
            res.Low.High.Should().BeFalse();
            res.Low.Low.Should().BeTrue();
        }

        [Test]
        public void Test_0_plus_1_plus_1()
        {
            var res = Arithmetics.AddTwoBits(new Bit2(false, false), new Bit2(false, true), true);

            res.High.Low.Should().BeFalse();
            res.Low.High.Should().BeTrue();
            res.Low.Low.Should().BeFalse();
        }

        [Test]
        public void Test_0_plus_2_plus_0()
        {
            var res = Arithmetics.AddTwoBits(new Bit2(false, false), new Bit2(true, false), false);

            res.High.Low.Should().BeFalse();
            res.Low.High.Should().BeTrue();
            res.Low.Low.Should().BeFalse();
        }

        [Test]
        public void Test_0_plus_2_plus_1()
        {
            var res = Arithmetics.AddTwoBits(new Bit2(false, false), new Bit2(true, false), true);

            res.High.Low.Should().BeFalse();
            res.Low.High.Should().BeTrue();
            res.Low.Low.Should().BeTrue();
        }

        [Test]
        public void Test_0_plus_3_plus_0()
        {
            var res = Arithmetics.AddTwoBits(new Bit2(false, false), new Bit2(true, true), false);

            res.High.Low.Should().BeFalse();
            res.Low.High.Should().BeTrue();
            res.Low.Low.Should().BeTrue();
        }

        [Test]
        public void Test_0_plus_3_plus_1()
        {
            var res = Arithmetics.AddTwoBits(new Bit2(false, false), new Bit2(true, true), true);

            res.High.Low.Should().BeTrue();
            res.Low.High.Should().BeFalse();
            res.Low.Low.Should().BeFalse();
        }

        [Test]
        public void Test_1_plus_0_plus_0()
        {
            var res = Arithmetics.AddTwoBits(new Bit2(false, true), new Bit2(false, false), false);

            res.High.Low.Should().BeFalse();
            res.Low.High.Should().BeFalse();
            res.Low.Low.Should().BeTrue();
        }

        [Test]
        public void Test_1_plus_0_plus_1()
        {
            var res = Arithmetics.AddTwoBits(new Bit2(false, true), new Bit2(false, false), true);

            res.High.Low.Should().BeFalse();
            res.Low.High.Should().BeTrue();
            res.Low.Low.Should().BeFalse();
        }
    }
}