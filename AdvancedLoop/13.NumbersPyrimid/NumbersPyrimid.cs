using System;

namespace _13.NumbersPyrimid
{
    class NumbersPyrimid
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            int numberForPrint = 1;
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (counter == number)
                    {
                        break;
                    }
                    counter++;
                    numberForPrint = counter;
                    Console.Write("{0} ",numberForPrint);
                   
                }
                Console.WriteLine();
            }
        }
    }
}
