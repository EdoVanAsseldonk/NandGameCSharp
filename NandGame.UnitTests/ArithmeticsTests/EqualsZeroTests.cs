using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.ArithmeticsTests
{
    public class EqualsZeroTests
    {
        [Test]
        public void Zero_equals_zero()
        {
            // Act
            var equalsZero = Arithmetics.EqualsZero(new Nibble(0));

            // Assert
            equalsZero.Should().BeTrue();
        }

        [Test]
        public void One_does_not_equal_zero()
        {
            // Act
            var equalsZero = Arithmetics.EqualsZero(new Nibble(1));

            // Assert
            equalsZero.Should().BeFalse();
        }

        [Test]
        public void Fifteen_does_not_equal_zero()
        {
            // Act
            var equalsZero = Arithmetics.EqualsZero(new Nibble(15));

            // Assert
            equalsZero.Should().BeFalse();
        }
    }
}