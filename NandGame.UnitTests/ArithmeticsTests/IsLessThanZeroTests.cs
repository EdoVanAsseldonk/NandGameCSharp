using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.ArithmeticsTests
{
    public class IsLessThanZeroTests
    {
        [Test]
        public void Zero_is_not_less_than_zero()
        {
            // Act
            var equalsZero = Arithmetics.IsLessThanZero(new Byte2(0));

            // Assert
            equalsZero.Should().BeFalse();
        }

        [Test]
        public void One_is_not_less_than_zero()
        {
            // Act
            var equalsZero = Arithmetics.IsLessThanZero(new Byte2(1));

            // Assert
            equalsZero.Should().BeFalse();
        }

        [Test]
        public void Maxvalue_is_not_less_than_zero()
        {
            // Act
            var byte2 = new Byte2(short.MaxValue);
            var equalsZero = Arithmetics.IsLessThanZero(byte2);

            // Assert
            equalsZero.Should().BeFalse();
        }

        [Test]
        public void Minus_one_is_less_than_zero()
        {
            // Act
            var equalsZero = Arithmetics.IsLessThanZero(new Byte2(-1));

            // Assert
            equalsZero.Should().BeTrue();
        }

        [Test]
        public void Minvalue_is_less_than_zero()
        {
            // Act
            var equalsZero = Arithmetics.IsLessThanZero(new Byte2(short.MinValue));

            // Assert
            equalsZero.Should().BeTrue();
        }
    }
}