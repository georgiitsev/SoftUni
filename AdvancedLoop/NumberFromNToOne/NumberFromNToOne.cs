using System;

namespace NumberFromNToOne
{
    class NumberFromNToOne
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = number; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
