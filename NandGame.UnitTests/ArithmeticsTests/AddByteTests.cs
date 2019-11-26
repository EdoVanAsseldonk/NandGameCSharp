using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.ArithmeticsTests
{
    public class AddByteTests
    {
        [Test]
        public void Test_0_plus_0()
        {
            var byteResult = Arithmetics.AddByte(new Byte(0), new Byte(0), false);
            byteResult.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test_0_plus_1()
        {
            var byteResult = Arithmetics.AddByte(new Byte(0), new Byte(1), false);
            byteResult.ToInt16().Should().Be(1);
        }

        [Test]
        public void Test_1_plus_1()
        {
            var byteResult = Arithmetics.AddByte(new Byte(1), new Byte(1), false);
            byteResult.ToInt16().Should().Be(2);
        }

        [Test]
        public void Test_255_plus_255()
        {
            var byteResult = Arithmetics.AddByte(new Byte(255), new Byte(255), false);
            byteResult.ToInt16().Should().Be(510);
        }
    }
}
