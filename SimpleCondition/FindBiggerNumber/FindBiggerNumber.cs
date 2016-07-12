using System;

namespace FindBiggerNumber
{
    class FindBiggerNumber
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            
            if (firstNumber>secondNumber)
            {
                Console.WriteLine("Greater number : {0}",firstNumber);  
            }
            else
            {
                Console.WriteLine("Greater number : {0}",secondNumber);
            }
        }
    }
}
