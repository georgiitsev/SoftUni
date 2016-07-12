using System;

namespace SequenceTwoMultiplyTwoTimesKPlusOne
{
    class SequenceTwoMultiplyTwoTimesKPlusOne
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
           
            for (int sequence = 1; sequence <= number;)
            {
                if (number == 1)
                {
                    Console.WriteLine(1);
                    break;
                }
                Console.WriteLine(sequence);
                sequence = sequence * 2 + 1;
                
            }

        }
    }
}
