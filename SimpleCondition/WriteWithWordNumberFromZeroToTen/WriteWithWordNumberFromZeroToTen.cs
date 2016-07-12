using System;

namespace WriteWithWordNumberFromZeroToTen
{
    class WriteWithWordNumberFromZeroToTen
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number >= 0 && number < 10)
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("Zero");
                        break;
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("number too big");
            }
           
        }
    }
}
