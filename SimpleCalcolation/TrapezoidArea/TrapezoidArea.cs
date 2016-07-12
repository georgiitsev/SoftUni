using System;

namespace TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            double sideB = double.Parse(Console.ReadLine());
            double sideB1 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = (sideB + sideB1) * h / 2;
            Console.WriteLine("Trapezoid area = " + area);
        }
    }
}
