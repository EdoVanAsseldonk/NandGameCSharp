using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.GatesTests
{
    public class AndTests
    {
        [Test]
        public void False_false_should_return_false()
        {
            var res = Gates.And(false, false);

            res.Should().BeFalse();
        }

        [Test]
        public void False_true_should_return_false()
        {
            var res = Gates.And(false, true);

            res.Should().BeFalse();
        }

        [Test]
        public void True_false_should_return_false()
        {
            var res = Gates.And(true, false);

            res.Should().BeFalse();
        }

        [Test]
        public void True_true_should_return_true()
        {
            var res = Gates.And(true, true);

            res.Should().BeTrue();
        }
    }
}