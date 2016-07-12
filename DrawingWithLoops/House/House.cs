using System;

namespace House
{
    class House
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int stars = 0;

            if (number % 2 == 0)
            {
                stars = 2;
            }
            else
            {
                stars = 1;
            }

            if (number % 2 ==0)
            {
                for (int i = 0; i < number / 2; i++)
                {
                    Console.Write(new string('-', (number - stars) / 2));
                    Console.Write(new string('*', stars));
                    Console.WriteLine(new string('-', (number - stars) / 2));
                    stars = stars + 2;
                }
            }
            else
            {
                for (int i = 0; i < number / 2 +1; i++)
                {
                    Console.Write(new string('-', (number - stars) / 2));
                    Console.Write(new string('*', stars));
                    Console.WriteLine(new string('-', (number - stars) / 2));
                    stars = stars + 2;
                }
            }
           
            if (number % 2==0)
            {
                for (int i = 0; i < (number / 2); i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', number - 2));
                    Console.WriteLine("|");
                }
            }
            else
            {
                for (int i = 0; i < (number / 2); i++)
                {
                    Console.Write("|");
                    Console.Write(new string('*', number - 2));
                    Console.WriteLine("|");

                }
            }
            
        }
    }
}
