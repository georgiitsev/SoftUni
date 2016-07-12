using System;

namespace DigitBy100to200
{
    class DigitBy100to200
    {
        static void Main()
        {
            int digit = int.Parse(Console.ReadLine());

            if (digit<100)
            {
                Console.WriteLine("Less than 100");
            }
            if (digit >= 100 && digit <= 200 )
            {
                Console.WriteLine("Between 100 and 200");
            }
            if(digit > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
