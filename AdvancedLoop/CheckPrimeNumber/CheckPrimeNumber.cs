using System;

namespace CheckPrimeNumber
{
    class CheckPrimeNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 2)
            {
                Console.WriteLine(" Not Prime");
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {

                    if (number % i == 0)
                    {

                        Console.WriteLine("Prime");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not Prime");
                        break;
                    }
                }
            }
        }
    }
}
