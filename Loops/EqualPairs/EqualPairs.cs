using System;

namespace EqualPairs
{
    class EqualPairs
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            double previousPairSum = 0;
            double currentPairSum = 0;
            double difference = double.MaxValue;
            double biggestdifference = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                double firstNumber = double.Parse(Console.ReadLine());
                double secondNumber = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    previousPairSum = firstNumber + secondNumber;
                }
                else
                {
                    currentPairSum = firstNumber + secondNumber;
                    difference = Math.Abs(currentPairSum - previousPairSum);
                    if (difference > biggestdifference)
                    {
                        biggestdifference = difference;
                    }
                    previousPairSum = currentPairSum;
                }
            }

            if (biggestdifference == 0)
            {
                Console.WriteLine("Yes, value ={0}", previousPairSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff ={0}", biggestdifference);
            }
        }

    }
}
