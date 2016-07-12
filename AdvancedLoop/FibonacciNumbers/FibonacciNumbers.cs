using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int numberOfFibonacci = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 1;
            int thirdNumber = 0;
            if (numberOfFibonacci == 0 || numberOfFibonacci == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 0; i < numberOfFibonacci; i++)
                {
                    thirdNumber = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                }
                Console.WriteLine(thirdNumber);
            }
        }
    }
}
