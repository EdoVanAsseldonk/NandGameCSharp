using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.PlumbingTests
{
    public class Register16BitTests
    {
        [Test]
        public void Register_can_be_set_when_clock_is_false()
        {
            var register16Bit = new Register16Bit();
            register16Bit.Do(true, new Byte2(17), false);
            var output = register16Bit.Do(false, new Byte2(0), true);

            output.ToInt16().Should().Be(17);
        }

        [Test]
        public void Register_can_not_be_set_when_clock_is_true()
        {
            var register16Bit = new Register16Bit();
            register16Bit.Do(true, new Byte2(17), true);
            var output = register16Bit.Do(false, new Byte2(0), true);

            output.ToInt16().Should().Be(0);
        }
    }
}