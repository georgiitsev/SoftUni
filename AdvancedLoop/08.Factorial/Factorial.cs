using System;

namespace _08.Factorial
{
    class Factorial
    {
        static void Main()
        {
            int numN = int.Parse(Console.ReadLine());
            long factorialN = 1;

            for (int i = 1; i <= numN; i++)
            {
                factorialN *= i;
            }
            Console.WriteLine(factorialN);

           
        }
    }
}
