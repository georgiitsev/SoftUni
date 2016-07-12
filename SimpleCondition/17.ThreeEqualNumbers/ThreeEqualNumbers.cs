using System;

namespace _17.ThreeEqualNumbers
{
    class ThreeEqualNumbers
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber && firstNumber == thirdNumber && secondNumber == firstNumber && secondNumber == thirdNumber && thirdNumber == firstNumber && thirdNumber == secondNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
