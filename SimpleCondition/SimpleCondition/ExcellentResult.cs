using System;

namespace SimpleCondition
{
    class ExcellentResult
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >=5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
