﻿using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.GatesTests
{
    public class NandTests
    {
        [Test]
        public void False_false_should_return_true()
        {
            var res = Gates.Nand(false, false);

            res.Should().BeTrue();
        }

        [Test]
        public void False_true_should_return_true()
        {
            var res = Gates.Nand(false, true);

            res.Should().BeTrue();
        }

        [Test]
        public void True_false_should_return_true()
        {
            var res = Gates.Nand(true, false);

            res.Should().BeTrue();
        }

        [Test]
        public void True_true_should_return_false()
        {
            var res = Gates.Nand(true, true);

            res.Should().BeFalse();
        }
    }
}
