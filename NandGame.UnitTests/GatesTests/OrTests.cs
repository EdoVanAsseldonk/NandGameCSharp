using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.GatesTests
{
    public class OrTests
    {
        [Test]
        public void False_false_should_return_false()
        {
            var res = Gates.Or(false, false);

            res.Should().BeFalse();
        }

        [Test]
        public void False_true_should_return_true()
        {
            var res = Gates.Or(false, true);

            res.Should().BeTrue();
        }

        [Test]
        public void True_false_should_return_true()
        {
            var res = Gates.Or(true, false);

            res.Should().BeTrue();
        }

        [Test]
        public void True_true_should_return_true()
        {
            var res = Gates.Or(true, true);

            res.Should().BeTrue();
        }
    }
}