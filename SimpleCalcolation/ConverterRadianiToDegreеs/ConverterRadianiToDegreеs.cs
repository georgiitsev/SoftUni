using System;

namespace ConverterRadianiToDegreеs
{
    class ConverterRadianiToDegreеs
    {
        static void Main()
        {
            double rad = double.Parse(Console.ReadLine());
            double cel = rad * (180.0 / Math.PI);
         double result = Math.Round(cel,0);
            Console.WriteLine(result);
        }
    }
}
