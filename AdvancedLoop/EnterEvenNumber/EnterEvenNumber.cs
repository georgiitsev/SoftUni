using System;

namespace EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main()
        {
            bool continueLoop = true;

            do
            {
                try
                {
                    Console.Write("Enter even number: ");
                    int evenNumber = int.Parse(Console.ReadLine());
                    if (evenNumber % 2 ==0)
                    {
                        Console.WriteLine("Even number entered: {0}",evenNumber);
                        continueLoop = false;
                    }
                    else if (evenNumber % 2 !=0)
                    {
                        Console.WriteLine("The number is not even.");
                    }
                    
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("Invalid number!");
                }
                catch (OverflowException bigger)
                {
                    Console.WriteLine("Invalid number!");
                }
                
            } while (continueLoop);
        }
    }
}
