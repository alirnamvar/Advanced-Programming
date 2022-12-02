using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            bool[] ans = new bool[t];
            int[] inputs = new int[t];
            
            // get inputs
            for (int i = 0; i < t; i++)
            {
                inputs[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < inputs.Length; i++)
            {
                if (Solution.IsFatherFind(inputs[i]))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }

        static class Solution
        {
            public static bool IsFatherFind(int input)
            {
                for (int i = 4; i < input; i++)
                {
                    if (i + SumOfDigits(i) + SumOfPrimeFactors(i) == input)
                    {
                        return true;
                    }
                }
                return false;
            }
            
            private static int SumOfDigits(int input)
            {
                int sum = 0;
                while (input > 0)
                {
                    sum += input % 10;
                    input /= 10;
                }
                return sum;
            }

            private static int SumOfPrimeFactors(int input)
            {
                int sum = 0;
                if (input % 2 == 0)
                {
                    sum += 2;
                    while (input % 2 == 0)
                    {
                        input /= 2;
                    }
                }
                for (int i = 3; i <= Math.Sqrt(input); i += 2)
                {
                    if(input % i == 0)
                    {
                        sum += i;
                        while (input % i== 0)
                        {
                            input /= i;
                        }
                    }
                }
                if (input > 2)
                    sum += input;
                return sum;
            }
            
        }
}
