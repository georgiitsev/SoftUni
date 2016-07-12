using System;

namespace ButterFly
{
    class ButterFly
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int line = number - 2;
            int emptySpaces = number - 1;

            for (int i = 2; i < number ; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', line));
                }
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', line));
                }

            }

            Console.WriteLine("{0}{1}{0}", new string(' ', emptySpaces), "@");

            for (int i = 2; i < number ; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', line));
                }
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', line));
                }
            }
        }
    }
}
