using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.PlumbingTests
{
    ////Input Output
    ////z n   X		
    //1  //0	0	0	0	✔
    //2  //0	1	0	65535	✔
    //3  //1	0	0	0	✔
    //4  //1	1	0	65535	✔
    //5  //0	0	27	27	✔
    //6  //0	1	27	65508	✔
    //7  //1	0	27	0	✔
    //8  //1	1	27	65535	✔
    //9  //0	0	65535	65535	✔
    //10 //0	1	65535	0	✔

    public class UnaryArithmeticLogicUnitTests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            var byte2 = new Byte2(0);

            // Act
            var output = UnaryArithmeticLogicUnit.Do(false, false, byte2);

            // Assert
            output.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var byte2 = new Byte2(0);

            // Act
            var output = UnaryArithmeticLogicUnit.Do(false, true, byte2);

            // Assert
            output.ToUInt16().Should().Be(65535);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var byte2 = new Byte2(0);

            // Act
            var output = UnaryArithmeticLogicUnit.Do(true, false, byte2);

            // Assert
            output.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test4()
        {
            // Arrange
            var byte2 = new Byte2(0);

            // Act
            var output = UnaryArithmeticLogicUnit.Do(true, true, byte2);

            // Assert
            output.ToUInt16().Should().Be(65535);
        }

        [Test]
        public void Test5()
        {
            // Arrange
            var byte2 = new Byte2(27);

            // Act
            var output = UnaryArithmeticLogicUnit.Do(false, false, byte2);

            // Assert
            output.ToInt16().Should().Be(27);
        }

        [Test]
        public void Test6()
        {
            // Arrange
            var byte2 = new Byte2(27);

            // Act
            var output = UnaryArithmeticLogicUnit.Do(false, true, byte2);

            // Assert
            output.ToUInt16().Should().Be(65508);
        }

        [Test]
        public void Test7()
        {
            // Arrange
            var byte2 = new Byte2(27);

            // Act
            var output = UnaryArithmeticLogicUnit.Do(true, false, byte2);

            // Assert
            output.ToInt16().Should().Be(0);
        }

        [Test]
        public void Test8()
        {
            // Arrange
            var byte2 = new Byte2(27);

            // Act
            var output = UnaryArithmeticLogicUnit.Do(true, true, byte2);

            // Assert
            output.ToUInt16().Should().Be(65535);
        }

        [Test]
        public void Test9()
        {
            // Arrange
            var byte2 = new Byte2("1111111111111111");

            // Act
            var output = UnaryArithmeticLogicUnit.Do(false, false, byte2);

            // Assert
            output.ToString().Should().Be("1111111111111111");
        }

        [Test]
        public void Test10()
        {
            // Arrange
            var byte2 = new Byte2("1111111111111111");

            // Act
            var output = UnaryArithmeticLogicUnit.Do(false, true, byte2);

            // Assert
            output.ToInt16().Should().Be(0);
        }
    }
}