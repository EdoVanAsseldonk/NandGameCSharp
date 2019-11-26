using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.PlumbingTests
{
    public class Register2BitTests
    {
        [Test]
        public void When_store_is_false_the_register_should_not_be_set()
        {
            // Arrange
            var register2Bit = new Register2Bit();

            // Act
            var output = register2Bit.Do(false, new Bit2(true, true), false);

            // Assert
            output.High.Should().BeFalse();
            output.Low.Should().BeFalse();
        }

        [Test]
        public void When_store_is_true_and_clock_is_false_the_previous_value_should_be_returned()
        {
            // Arrange
            var register2Bit = new Register2Bit();

            // Act
            var data = new Bit2(true, true);
            var output = register2Bit.Do(true, data, false);

            // Assert
            output.High.Should().BeFalse();
            output.Low.Should().BeFalse();
        }

        [Test]
        public void After_storing_data_a_clocktick_returns_the_new_data()
        {
            // Arrange
            var register2Bit = new Register2Bit();

            // Act
            var data = new Bit2(true, true);
            register2Bit.Do(true, data, false); // store data
            var output = register2Bit.Do(false, new Bit2(false, false), true); // return data because clock==true

            // Assert
            output.High.Should().BeTrue();
            output.Low.Should().BeTrue();
        }

        [Test]
        public void It_is_impossible_to_store_data_at_a_clocktick()
        {
            // Arrange
            var register2Bit = new Register2Bit();

            // Act
            var data = new Bit2(true, true);
            var output = register2Bit.Do(true, data, true);

            // Assert
            output.High.Should().BeFalse();
            output.Low.Should().BeFalse();
        }
    }
}