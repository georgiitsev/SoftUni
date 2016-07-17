using System;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            if (number % i == 0 && number % j ==0 && number % l ==0 && number % m ==0)
                            {
                                Console.Write("{0}{1}{2}{3} ",i,j,l,m);
                            }
                        }
                    }
                }
            }
        }
    }
}
