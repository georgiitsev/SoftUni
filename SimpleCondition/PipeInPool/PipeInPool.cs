using System;

namespace PipeInPool
{
    class PipeInPool
    {
        static void Main()
        {
            int vPool = int.Parse(Console.ReadLine());
            int firstPipe = int.Parse(Console.ReadLine());
            int secondPipe = int.Parse(Console.ReadLine());
            double hourLeave = double.Parse(Console.ReadLine());

            var firstPipeWork = firstPipe * hourLeave;
            var secondPipeWork = secondPipe * hourLeave;
            var PoolFull = firstPipeWork + secondPipeWork;
            var finalPoolresult =Math.Truncate( PoolFull * 100 / vPool);
            var percentFirstPipe = Math.Truncate(firstPipeWork * 100 / PoolFull);
            var percentSecondPipe = Math.Truncate(secondPipeWork * 100 / PoolFull);
            var poolOverFlow = PoolFull - vPool;
            if (PoolFull <= vPool)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", finalPoolresult, percentFirstPipe,percentSecondPipe);
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hourLeave, poolOverFlow);
            }

        }
    }
}
