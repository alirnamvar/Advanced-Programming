using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(ss => int.Parse(ss)).ToArray();
            int n = inputs[0];
            int m = inputs[1];

            Month[] s = new Month[m];

            for (int i = 0; i < m; i++)
            {
                string input = Console.ReadLine();
                s[i] = new Month(input);
            }
            Month.CheckMonths(s, n);
        }
        public static bool IsOdd(int n)
        {
            return n % 2 != 0;
        }

        public class Month
        {
            private string input = "";
            public Month(string input)
            {
                this.input = input;
            }

            public string GetInput()
            {
                return input;
            }

            public static void CheckMonths(Month[] s, int n)
            {
                int[] whiteOrBlack = new int[n];
                string output = "";
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (s[i].GetInput()[j] == 'W')
                        {
                            whiteOrBlack[j] += 1;
                        }
                    }
                }
                for (int i = 0; i < whiteOrBlack.Length; i++)
                {
                    if (IsOdd(whiteOrBlack[i]))
                    {
                        output += "F";
                    }
                    else
                    {
                        output += "B";
                    }
                }
                Console.WriteLine(output);
            }
        }     
    }
}
