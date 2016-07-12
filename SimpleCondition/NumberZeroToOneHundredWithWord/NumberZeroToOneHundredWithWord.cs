using System;

namespace NumberZeroToOneHundredWithWord
{
    class NumberZeroToOneHundredWithWord
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 0 && number <= 19)
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("Zero");
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    case 10:
                        Console.WriteLine("ten");
                        break;
                    case 11:
                        Console.WriteLine("eleven");
                        break;
                    case 12:
                        Console.WriteLine("twelve");
                        break;
                    case 13:
                        Console.WriteLine("thirteen");
                        break;
                    case 14:
                        Console.WriteLine("fourteen");
                        break;
                    case 15:
                        Console.WriteLine("fifteen");
                        break;
                    case 16:
                        Console.WriteLine("sixteen");
                        break;
                    case 17:
                        Console.WriteLine("seventeen");
                        break;
                    case 18:
                        Console.WriteLine("eighteen");
                        break;
                    case 19:
                        Console.WriteLine("nineteen");
                        break;
                    default:
                        break;
                }
            }
            else if (number >= 20 && number <= 99)
            {
                int takeFirstDigit = number / 10;
                int takeSecondDigit = number % 10;
                string finalResult = string.Empty;
                switch (takeFirstDigit)
                {
                    case 2:
                        finalResult += "twenty";
                        break;
                    case 3:
                        finalResult += "thirty";
                        break;
                    case 4:
                        finalResult += "fourty";
                        break;
                    case 5:
                        finalResult += "fifty";
                        break;
                    case 6:
                        finalResult += "sixty";
                        break;
                    case 7:
                        finalResult += "seventy";
                        break;
                    case 8:
                        finalResult += "eighty";
                        break;
                    case 9:
                        finalResult += "ninety";
                        break;
                    default:
                        break;
                }


                switch (takeSecondDigit)
                {
                    case 1:
                        finalResult += " one";
                        break;
                    case 2:
                        finalResult += " two";
                        break;
                    case 3:
                        finalResult += " three";
                        break;
                    case 4:
                        finalResult += " four";
                        break;
                    case 5:
                        finalResult += " five";
                        break;
                    case 6:
                        finalResult += " six";
                        break;
                    case 7:
                        finalResult += " seven";
                        break;
                    case 8:
                        finalResult += " eight";
                        break;
                    case 9:
                        finalResult += " nine";
                        break;

                    default:
                        break;
                }
                Console.WriteLine(finalResult);
            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
