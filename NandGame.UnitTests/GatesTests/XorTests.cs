using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.GatesTests
{
    public class XorTests
    {
        [Test]
        public void False_false_should_return_false()
        {
            var res = Gates.Xor(false, false);

            res.Should().BeFalse();
        }

        [Test]
        public void False_true_should_return_true()
        {
            var res = Gates.Xor(false, true);

            res.Should().BeTrue();
        }

        [Test]
        public void True_false_should_return_true()
        {
            var res = Gates.Xor(true, false);

            res.Should().BeTrue();
        }

        [Test]
        public void True_true_should_return_false()
        {
            var res = Gates.Xor(true, true);

            res.Should().BeFalse();
        }
    }
}
