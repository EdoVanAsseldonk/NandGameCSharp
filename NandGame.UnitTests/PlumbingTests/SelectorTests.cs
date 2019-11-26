using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.PlumbingTests
{
    public class SelectorTests
    {
        [Test]
        public void When_selected_input_is_false_expect_value_of_input0_which_is_false()
        {
            var selected = Select.Do(false, false, false);
            selected.Should().BeFalse();
        }

        [Test]
        public void When_selected_input_is_false_expect_value_of_input0_which_is_true()
        {
            var selected = Select.Do(false, false, true);
            selected.Should().BeTrue();
        }

        [Test]
        public void When_selected_input_is_true_expect_value_of_input1_which_is_false()
        {
            var selected = Select.Do(true, false, false);
            selected.Should().BeFalse();
        }

        [Test]
        public void When_selected_input_is_true_expect_value_of_input1_which_is_true()
        {
            var selected = Select.Do(true, false, true);
            selected.Should().BeFalse();
        }
    }
}