using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.GatesTests
{
    public class InvertTests
    {
        [Test]
        public void False_should_return_true()
        {
            var res = Gates.Invert(false);

            res.Should().BeTrue();
        }

        [Test]
        public void True_should_return_false()
        {
            var res = Gates.Invert(true);

            res.Should().BeFalse();
        }
    }
}