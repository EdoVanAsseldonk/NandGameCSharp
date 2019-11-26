using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.ProcessorTests
{
    //Input             Output
    //------------      ------
    //I         cl      j   A
    //61415	    0	    1	0
    //60066	    0	    1	0
    //61410	    0	    0	0

    public class ControlUnitTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var instruction = new Byte2(-4121);

            // Act
            var controlUnitOutput = new ControlUnit().Do(instruction, false);

            // Assert
            controlUnitOutput.J.Should().BeTrue();
            controlUnitOutput.A.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var instruction = new Byte2(-5470);

            // Act
            var controlUnitOutput = new ControlUnit().Do(instruction, false);

            // Assert
            controlUnitOutput.J.Should().BeTrue();
            controlUnitOutput.A.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var instruction = new Byte2(-4126);

            // Act
            var controlUnitOutput = new ControlUnit().Do(instruction, false);

            // Assert
            controlUnitOutput.J.Should().BeFalse();
            controlUnitOutput.A.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test4()
        {
            // Arrange
            var instruction = new Byte2(17);
            //e0a0

            var controlUnit = new ControlUnit();

            // Act
            controlUnit.Do(instruction, false);
            var controlUnitOutput = controlUnit.Do(instruction, true);

            // Assert
            controlUnitOutput.J.Should().BeFalse();
            controlUnitOutput.A.ToInt16().Should().Be(17);
        }

        [Test]
        public void Controlunit_can_move_data_from_register_to_ram()
        {
            // Arrange
            var controlUnit = new ControlUnit();

            // Act
            // Set A to 17
            controlUnit.Do(new Byte2(17), false);
            controlUnit.Do(new Byte2(17), true);

            // Copy A to D
            var byte2 = new Byte2("1000100010010000");
            controlUnit.Do(byte2, false);
            controlUnit.Do(byte2, true);

            // Set A to 0
            controlUnit.Do(new Byte2(0), false);
            controlUnit.Do(new Byte2(0), true);

            // Copy D to Ram
            controlUnit.Do(new Byte2("1000000010001000"), false);
            controlUnit.Do(new Byte2("1000000010001000"), true);

            // Copy D to A
            controlUnit.Do(new Byte2("1000000010100000"), false);
            var controlUnitOutput = controlUnit.Do(new Byte2("1000000010100000"), true);

            // Assert
            controlUnitOutput.J.Should().BeFalse();
            controlUnitOutput.A.ToInt16().Should().Be(17);
        }

        [Test]
        public void Controlunit_can_add_two_numbers()
        {
            // Arrange
            var controlUnit = new ControlUnit();

            // Act
            // Set A to 17
            controlUnit.Do(new Byte2(17), false);
            controlUnit.Do(new Byte2(17), true);

            // Copy A to D
            var byte2 = new Byte2("1000100010010000");
            controlUnit.Do(byte2, false);
            controlUnit.Do(byte2, true);

            // Set A to 29
            controlUnit.Do(new Byte2(29), false);
            controlUnit.Do(new Byte2(29), true);

            // Add A and D and store result in A
            controlUnit.Do(new Byte2("1000000010100000"), false);
            var controlUnitOutput = controlUnit.Do(new Byte2("1000000010100000"), true);

            // Assert
            controlUnitOutput.J.Should().BeFalse();
            controlUnitOutput.A.ToInt16().Should().Be(46);
        }
    }
}
