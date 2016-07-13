using System;

namespace CheckPrimeNumber
{
    class CheckPrimeNumber
    {
        static void Main()
        {

            int number = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(number);
            bool prime = true;
            if (number < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                while (prime && (divider <= maxDivider))
                {
                    if (number % divider == 0)
                    {
                        prime = false;
                    }
                    divider++;
                }
                if (prime == false)
                {
                    Console.WriteLine("Not Prime");
                }
                else
                {
                    Console.WriteLine("Prime");
                }
            }



        }
    }
}
