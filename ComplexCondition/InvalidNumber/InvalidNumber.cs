using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main()
        {
            int someNumber = int.Parse(Console.ReadLine());

            if (someNumber >= 100 && someNumber <= 200 || someNumber == 0)
            {
                
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
