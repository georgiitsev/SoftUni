using System;

namespace EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main()
        {
            for (int i = 0;;)
            {
                Console.Write("Enter even number: ");
                int number = int.Parse(Console.ReadLine());
                try
                {
                    int temp = (int)number;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid ");
                    throw;
                }
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even number entered: {0}",number);
                }
                else
                {
                    Console.WriteLine("The number is not even.");
                }
            }
        }
    }
}
