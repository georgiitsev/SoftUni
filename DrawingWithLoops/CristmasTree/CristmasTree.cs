using System;

namespace CristmasTree
{
    class CristmasTree
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

         
            for (int cow = 0; cow <= number; cow++)
            {
                Console.Write(new string(' ', number - cow));
                Console.Write(new string('*', cow));
                Console.Write(" | ");
                Console.WriteLine(new string('*', cow));
            }
        }
    }
}
