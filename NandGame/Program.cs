using System;
using NandGame.Core;

namespace NandGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var controlUnit = new ControlUnit();

            while (true)
            {
                Console.Write("Please enter a number between 0 and 100: ");
                var inputA = Console.ReadLine();
                var a = short.Parse(inputA);
                var byteA = new Byte2(a);

                Console.Write("Please enter another number between 0 and 100: ");
                var inputB = Console.ReadLine();
                var b = short.Parse(inputB);
                var byteB = new Byte2(b);

                // Set A-register
                controlUnit.Do(byteA, false);
                controlUnit.Do(byteA, true);

                // Copy A-register to D-register
                var byte2 = new Byte2("1000100010010000");
                controlUnit.Do(byte2, false);
                controlUnit.Do(byte2, true);

                // Set A-register
                controlUnit.Do(byteB, false);
                controlUnit.Do(byteB, true);

                // Add A and D and store result in A-register
                controlUnit.Do(new Byte2("1000000010100000"), false);
                var controlUnitOutput = controlUnit.Do(new Byte2("1000000010100000"), true);

                // Assert
                Console.WriteLine($"The result is: {controlUnitOutput.A.ToInt16()}");
                Console.WriteLine($"Press Q to quit. Any other key to try again");

                var read = Console.Read();
                if (read == 113)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
