using System;

namespace SimpleCalcolation
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int sideA = int.Parse(Console.ReadLine());
            Console.Write("Square = ");
            Console.WriteLine(sideA * sideA);
        }
    }
}
