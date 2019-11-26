using System.Collections.Generic;
using FluentAssertions;
using NandGame.Core;
using NandGame.UnitTests.Factories;
using NUnit.Framework;

namespace NandGame.UnitTests.ProcessorTests
{
    //Input     Output
    //          ci  sm  zx  nx  zy  ny  f   no  a   d   ram gt  eq  lt  W
    //61408	    1	0	1	1	1	1	1	1	1	0	0	0	0	0	0
    //57368	    1	0	0	0	0	0	0	0	0	1	1	0	0	0	0
    //64551	    1	1	1	1	0	0	0	0	1	0	0	1	1	1	0
    //1234	    0	0	0	0	0	0	0	0	1	0	0	0	0	0	1234

    public class ProgramEngineTests
    {
        //[Test]
        public void Test1()
        {
            // Arrange
            //1000101010100000
            var instruction = DecodedInstructionFactory.CreateDataInstruction(new Byte2(42));
            var romContent = new Dictionary<int, Byte2>
                             {
                                 { 0, DecodedInstructionFactory.CreateComputationInstruction(new Byte2("1000101010100000")) },
                                 { 1, DecodedInstructionFactory.CreateDataInstruction(new Byte2(999)) },
                                 { 2, DecodedInstructionFactory.CreateDataInstruction(new Byte2(101)) },
                             };

            var computer = new Computer(new ReadOnlyMemory(romContent));

            // Act
            computer.Run();
           
            // Assert
           
        }
    }
}