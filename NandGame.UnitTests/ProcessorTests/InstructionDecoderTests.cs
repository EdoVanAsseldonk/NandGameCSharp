using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.ProcessorTests
{
    //Input     Output
    //          ci  sm  zx  nx  zy  ny  f   no  a   d   ram gt  eq  lt  W
    //61408	    1	0	1	1	1	1	1	1	1	0	0	0	0	0	0
    //57368	    1	0	0	0	0	0	0	0	0	1	1	0	0	0	0
    //64551	    1	1	1	1	0	0	0	0	1	0	0	1	1	1	0
    //1234	    0	0	0	0	0	0	0	0	1	0	0	0	0	0	1234

    public class InstructionDecoderTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var instruction = new Byte2(-4128);

            // Act

            var decodedInstruction = InstructionDecoder.Decode(instruction);

            // Assert
            decodedInstruction.ComputationInstruction.Should().BeTrue();
            decodedInstruction.SourceMemory.Should().BeFalse();
            decodedInstruction.Operation.zx.Should().BeTrue();
            decodedInstruction.Operation.nx.Should().BeTrue();
            decodedInstruction.Operation.zy.Should().BeTrue();
            decodedInstruction.Operation.ny.Should().BeTrue();
            decodedInstruction.Operation.Function.Should().BeTrue();
            decodedInstruction.Operation.NegateOutput.Should().BeTrue();
            decodedInstruction.Destination.A.Should().BeTrue();
            decodedInstruction.Destination.D.Should().BeFalse();
            decodedInstruction.Destination.Ram.Should().BeFalse();
            decodedInstruction.Condition.GreaterThanZero.Should().BeFalse();
            decodedInstruction.Condition.EqualToZero.Should().BeFalse();
            decodedInstruction.Condition.LessThanZero.Should().BeFalse();
            decodedInstruction.w.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var instruction = new Byte2(-8168);

            // Act

            var decodedInstruction = InstructionDecoder.Decode(instruction);

            // Assert
            decodedInstruction.ComputationInstruction.Should().BeTrue();
            decodedInstruction.SourceMemory.Should().BeFalse();
            decodedInstruction.Operation.zx.Should().BeFalse();
            decodedInstruction.Operation.nx.Should().BeFalse();
            decodedInstruction.Operation.zy.Should().BeFalse();
            decodedInstruction.Operation.ny.Should().BeFalse();
            decodedInstruction.Operation.Function.Should().BeFalse();
            decodedInstruction.Operation.NegateOutput.Should().BeFalse();
            decodedInstruction.Destination.A.Should().BeFalse();
            decodedInstruction.Destination.D.Should().BeTrue();
            decodedInstruction.Destination.Ram.Should().BeTrue();
            decodedInstruction.Condition.GreaterThanZero.Should().BeFalse();
            decodedInstruction.Condition.EqualToZero.Should().BeFalse();
            decodedInstruction.Condition.LessThanZero.Should().BeFalse();
            decodedInstruction.w.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var instruction = new Byte2(-985);

            // Act

            var decodedInstruction = InstructionDecoder.Decode(instruction);

            // Assert
            decodedInstruction.ComputationInstruction.Should().BeTrue();
            decodedInstruction.SourceMemory.Should().BeTrue();
            decodedInstruction.Operation.zx.Should().BeTrue();
            decodedInstruction.Operation.nx.Should().BeTrue();
            decodedInstruction.Operation.zy.Should().BeFalse();
            decodedInstruction.Operation.ny.Should().BeFalse();
            decodedInstruction.Operation.Function.Should().BeFalse();
            decodedInstruction.Operation.NegateOutput.Should().BeFalse();
            decodedInstruction.Destination.A.Should().BeTrue();
            decodedInstruction.Destination.D.Should().BeFalse();
            decodedInstruction.Destination.Ram.Should().BeFalse();
            decodedInstruction.Condition.GreaterThanZero.Should().BeTrue();
            decodedInstruction.Condition.EqualToZero.Should().BeTrue();
            decodedInstruction.Condition.LessThanZero.Should().BeTrue();
            decodedInstruction.w.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test4()
        {
            // Arrange
            var instruction = new Byte2(1234);

            // Act

            var decodedInstruction = InstructionDecoder.Decode(instruction);

            // Assert
            decodedInstruction.ComputationInstruction.Should().BeFalse();
            decodedInstruction.SourceMemory.Should().BeFalse();
            decodedInstruction.Operation.zx.Should().BeFalse();
            decodedInstruction.Operation.nx.Should().BeFalse();
            decodedInstruction.Operation.zy.Should().BeFalse();
            decodedInstruction.Operation.ny.Should().BeFalse();
            decodedInstruction.Operation.Function.Should().BeFalse();
            decodedInstruction.Operation.NegateOutput.Should().BeFalse();
            decodedInstruction.Destination.A.Should().BeTrue();
            decodedInstruction.Destination.D.Should().BeFalse();
            decodedInstruction.Destination.Ram.Should().BeFalse();
            decodedInstruction.Condition.GreaterThanZero.Should().BeFalse();
            decodedInstruction.Condition.EqualToZero.Should().BeFalse();
            decodedInstruction.Condition.LessThanZero.Should().BeFalse();
            decodedInstruction.w.ToInt16().Should().Be(1234);
        }

        [Test]
        public void For_data_instruction_W_returns_input()
        {
            // Arrange
            var instruction = new Byte2(17);

            // Act

            var decodedInstruction = InstructionDecoder.Decode(instruction);

            // Assert
            decodedInstruction.w.ToInt16().Should().Be(17);
        }
    }
}