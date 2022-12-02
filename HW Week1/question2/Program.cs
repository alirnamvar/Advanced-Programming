using System;

namespace question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int inc = 1;
            int goodNumber = 1;
            while (true)
            {
                if (NumberOfDivisors(goodNumber) >= k)
                {
                    Console.WriteLine(goodNumber);
                    break;
                }
                inc++;
                goodNumber += inc;
            }
        }

        public static int NumberOfDivisors(int a)
        {
            int numberOfDivisors = 0;
            for (int i = 1; i < Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    numberOfDivisors++;
                }
            }
            numberOfDivisors *= 2;
            if (Math.Sqrt(a) % 1 == 0)
            {
                numberOfDivisors++;
            }
            return numberOfDivisors;
        }
    }
    
}
