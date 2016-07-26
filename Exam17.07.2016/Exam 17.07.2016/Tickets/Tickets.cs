using System;

namespace Tickets
{
    class Tickets
    {
        static void Main()
        {
            const double vip = 499.99;
            const double normal = 249.99;

            double buget = double.Parse(Console.ReadLine());
            string vipOrNormal = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());
            double prizeForTransport = 0.00;
            double total = 0.00;
            double finalResult = 0.00;

            switch (vipOrNormal)
            {
                case "vip":
                    if (numberOfPeople >= 1 && numberOfPeople <= 4)
                    {
                        prizeForTransport = buget * 0.75;
                        total = (numberOfPeople * vip) + prizeForTransport;
                    }
                    else if (numberOfPeople >= 5 && numberOfPeople <= 9)
                    {
                        prizeForTransport = buget * 0.6;
                        total = (numberOfPeople * vip) + prizeForTransport;
                        Console.WriteLine(total);


                    }
                    else if (numberOfPeople >= 10 && numberOfPeople <= 24)
                    {
                        prizeForTransport = buget * 0.5;
                        total = (numberOfPeople * vip) + prizeForTransport;


                    }
                    else if (numberOfPeople >= 25 && numberOfPeople <= 49)
                    {
                        prizeForTransport = buget * 0.4;
                        total = (numberOfPeople * vip) + prizeForTransport;

                    }
                    else if (numberOfPeople > 50)
                    {
                        prizeForTransport = buget * 0.25;
                        total = (numberOfPeople * vip) + prizeForTransport;


                    }
                    if (buget >= total)
                    {
                        finalResult = buget - total;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", finalResult);
                    }
                    else if (buget < total)
                    {
                        finalResult = Math.Abs(buget - total);
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", finalResult);
                    }
                    break;
                case "normal":
                    if (numberOfPeople >= 1 && numberOfPeople <= 4)
                    {
                        prizeForTransport = buget * 0.75;
                        total = (numberOfPeople * normal) + prizeForTransport;
                    }
                    else if (numberOfPeople >= 5 && numberOfPeople <= 9)
                    {
                        prizeForTransport = buget * 0.6;
                        total = (numberOfPeople * normal) + prizeForTransport;
                        Console.WriteLine(total);


                    }
                    else if (numberOfPeople >= 10 && numberOfPeople <= 24)
                    {
                        prizeForTransport = buget * 0.5;
                        total = (numberOfPeople * normal) + prizeForTransport;


                    }
                    else if (numberOfPeople >= 25 && numberOfPeople <= 49)
                    {
                        prizeForTransport = buget * 0.4;
                        total = (numberOfPeople * vip) + prizeForTransport;

                    }
                    else if (numberOfPeople > 50)
                    {
                        prizeForTransport = buget * 0.25;
                        total = (numberOfPeople * normal) + prizeForTransport;


                    }
                    if (buget >= total)
                    {
                        finalResult = buget - total;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", finalResult);
                    }
                    else if (buget < total)
                    {
                        finalResult = Math.Abs(buget - total);
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", finalResult);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
