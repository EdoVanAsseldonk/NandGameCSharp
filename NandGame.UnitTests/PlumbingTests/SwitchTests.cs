using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.PlumbingTests
{
    public class SwitchTests
    {
        [Test]
        public void When_selected_channel_is_false_expect_data_to_be_sent_to_channel0()
        {
            var output = Switch.Do(false, true);

            output.Channel0.Should().BeTrue();
            output.Channel1.Should().BeFalse();
        }

        [Test]
        public void When_selected_channel_is_true_expect_data_to_be_sent_to_channel1()
        {
            var output = Switch.Do(true, true);

            output.Channel0.Should().BeFalse();
            output.Channel1.Should().BeTrue();
        }
    }
}