using System;

namespace VegetableMarket
{
    class VegetableMarket
    {
        static void Main()
        {
            const decimal value = 1.94m;

            decimal priceVeg = decimal.Parse(Console.ReadLine());
            decimal priceFruit = decimal.Parse(Console.ReadLine());
            int allWeightVeg =int.Parse(Console.ReadLine());
            int allWeightFruit =int.Parse(Console.ReadLine());
           
            if (priceVeg >= 0.00m || priceVeg <=1000.00m || priceFruit >= 0.00m || priceFruit <= 1000.00m || allWeightVeg >= 0.00m || allWeightVeg <=1000.00m || allWeightFruit >= 0.00m || allWeightFruit <= 1000.00m)
            {
                decimal resultVeg = allWeightVeg * priceVeg;
                decimal resultFruit = allWeightFruit * priceFruit;
                decimal temp = (resultVeg + resultFruit);
                decimal finalResult = temp / value;
                Console.WriteLine(finalResult);
            }
            else
            {
                return;
            }
        }
    }
}
