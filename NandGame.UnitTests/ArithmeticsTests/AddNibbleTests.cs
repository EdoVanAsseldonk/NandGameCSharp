using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.ArithmeticsTests
{
    public class AddNibbleTests
    {
        [Test]
        public void Test_1_plus_1_plus_0()
        {
            var byteResult = Arithmetics.AddNibble(new Nibble("0001"), new Nibble("0001"), false);
            byteResult.ToShort().Should().Be(2);
        }

        [Test]
        public void Test_0_plus_15_plus_0()
        {
            var byteResult = Arithmetics.AddNibble(new Nibble("0000"), new Nibble("1111"), false);
            byteResult.ToShort().Should().Be(15);
        }

        [Test]
        public void Test_15_plus_15_plus_0()
        {
            var byteResult = Arithmetics.AddNibble(new Nibble("1111"), new Nibble("1111"), false);
            byteResult.ToShort().Should().Be(30);
        }

        [Test]
        public void Test_15_plus_15_plus_1()
        {
            var byteResult = Arithmetics.AddNibble(new Nibble("1111"), new Nibble("1111"), true);
            byteResult.ToShort().Should().Be(31);
        }
    }
}
