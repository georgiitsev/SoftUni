using System;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            while (firstNumber != secondNumber)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber -= secondNumber;
                }
                else
                {
                    secondNumber -= firstNumber;
                }
            }
            Console.WriteLine(firstNumber);


        }
    }
}
