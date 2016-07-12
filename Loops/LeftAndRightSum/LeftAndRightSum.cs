using System;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main()
        {
            int sizeOfLoop = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int rotation = 2 * sizeOfLoop;

            for (int i = 0; i < rotation; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i < sizeOfLoop)
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }
            }
            int diff =Math.Abs(leftSum - rightSum);
            if (diff == 0)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", diff);
            }
        }
    }
}
