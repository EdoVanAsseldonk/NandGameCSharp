using FluentAssertions;
using NandGame.Core;
using NUnit.Framework;

namespace NandGame.UnitTests.PlumbingTests
{
    public class ArithmeticLogicUnitEvaluateTests
    {
        //      Input               Output
        //      lt eq  gt   X
        //1      0	0	0	0	    0	✔
        //2      0	0	0	1	    0	✔
        //3      0	0	0	-1	    0	✔
        //4      0	0	0	65535	0	✔
        //5      1	1	1	0	    1	✔
        //6      1	1	1	1	    1	✔
        //7      1	1	1	2	    1	✔
        //8      1	1	1	65535	1	✔
        //9      0	0	1	0	    0	✔
        //10     0	0	1	1	    1	✔
        [Test]
        public void Test1()
        {
            // Arrange
            var byte2X = new Byte2(0);
            var condition = new Condition(false, false, false);

            // Act
            var output = ArithmeticLogicUnit.Evaluate(condition, byte2X);

            // Assert
            output.Should().BeFalse();
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var byte2X = new Byte2(1);
            var condition = new Condition(false, false, false);

            // Act
            var output = ArithmeticLogicUnit.Evaluate(condition, byte2X);

            // Assert
            output.Should().BeFalse();
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var byte2X = new Byte2(-1);
            var condition = new Condition(false, false, false);

            // Act
            var output = ArithmeticLogicUnit.Evaluate(condition, byte2X);

            // Assert
            output.Should().BeFalse();
        }

        [Test]
        public void Test4()
        {
            // Arrange
            var byte2X = new Byte2(-1);
            var condition = new Condition(true, false, false);

            // Act
            var output = ArithmeticLogicUnit.Evaluate(condition, byte2X);

            // Assert
            output.Should().BeTrue();
        }

        [Test]
        public void Test5()
        {
            // Arrange
            var byte2X = new Byte2(0);
            var condition = new Condition(true, false, false);

            // Act
            var output = ArithmeticLogicUnit.Evaluate(condition, byte2X);

            // Assert
            output.Should().BeFalse();
        }

        [Test]
        public void Test6()
        {
            // Arrange
            var byte2X = new Byte2(1);
            var condition = new Condition(true, false, false);

            // Act
            var output = ArithmeticLogicUnit.Evaluate(condition, byte2X);

            // Assert
            output.Should().BeFalse();
        }

        [Test]
        public void Test7()
        {
            // Arrange
            var byte2X = new Byte2(-1);
            var condition = new Condition(false, true, false);

            // Act
            var output = ArithmeticLogicUnit.Evaluate(condition, byte2X);

            // Assert
            output.Should().BeFalse();
        }

        [Test]
        public void Test8()
        {
            // Arrange
            var byte2X = new Byte2(0);
            var condition = new Condition(false, true, false);

            // Act
            var output = ArithmeticLogicUnit.Evaluate(condition, byte2X);

            // Assert
            output.Should().BeTrue();
        }

        [Test]
        public void Test9()
        {
            // Arrange
            var byte2X = new Byte2(1);
            var condition = new Condition(false, true, false);

            // Act
            var output = ArithmeticLogicUnit.Evaluate(condition, byte2X);

            // Assert
            output.Should().BeFalse();
        }





        [Test]
        public void Test10()
        {
            // Arrange
            var byte2X = new Byte2(-1);
            var condition = new Condition(false, false, true);

            // Act
            var output = ArithmeticLogicUnit.Evaluate(condition, byte2X);

            // Assert
            output.Should().BeFalse();
        }

        [Test]
        public void Test11()
        {
            // Arrange
            var byte2X = new Byte2(0);
            var condition = new Condition(false, false, true);

            // Act
            var output = ArithmeticLogicUnit.Evaluate(condition, byte2X);

            // Assert
            output.Should().BeFalse();
        }

        [Test]
        public void Test12()
        {
            // Arrange
            var byte2X = new Byte2(1);
            var condition = new Condition(false, false, true);

            // Act
            var output = ArithmeticLogicUnit.Evaluate(condition, byte2X);

            // Assert
            output.Should().BeTrue();
        }
    }
}