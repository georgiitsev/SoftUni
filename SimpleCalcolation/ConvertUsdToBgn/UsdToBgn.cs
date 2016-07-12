using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertUsdToBgn
{
    class UsdToBgn
    {
        static void Main(string[] args)
        {
            decimal bgn = 1.79549m;
            decimal usd =decimal.Parse(Console.ReadLine());
            decimal convert = usd * bgn;
            Console.WriteLine(Math.Round(convert,2));
        }
    }
}
