using System;

namespace SunGlasses
{
    class SunGlasses
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.Write(new string ('*',number*2));
            Console.Write(new string (' ',number));
            Console.WriteLine(new string('*', number * 2));

            for (int i = 0; i < number-2; i++)
            {
                Console.Write("*");
                Console.Write(new string ('/',(number*2)-2));
                Console.Write("*");
                if (i ==(number -1)/2-1)
                {
                    Console.Write(new string ('|',number));
                }
                else
                {
                    Console.Write(new string(' ', number));
                }
                Console.Write("*");
                Console.Write(new string('/', (number * 2) - 2));
                Console.Write("*");
                Console.WriteLine();
            }
            Console.Write(new string('*', number * 2));
            Console.Write(new string(' ', number));
            Console.WriteLine(new string('*', number * 2));
        }
    }
}
