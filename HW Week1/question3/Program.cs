using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(ss => int.Parse(ss)).ToArray();
            int m = inputs[0];
            int s = inputs[1];
            
            if ( (m * 9 < s) || (s==0) )
            {
                Console.WriteLine("-1 -1");
                return;
            }

            // vars
            int  lenw1, lenw2, lenw3, lenw4, w2;

            // smallestSum (w4, w3, w2, w1)
            lenw1 = (int)s / 9;
            lenw2 = 1;
            lenw4 = 0;
            w2 = (int)s % 9;
            bool w2Is8 = false;

            if (lenw1 + lenw2 < m)
            {
                lenw4 = 1;
                if (w2 == 0)
                {
                    w2Is8 = true;
                    lenw1 --;
                }
                else
                {
                    w2--;
                }

            }
            lenw3 = m - lenw1 - lenw2 - lenw4;

            for (int i = 0; i < m; i++)
            {
                if (lenw4 > 0)
                {
                    Console.Write(1);
                    lenw4--;
                }
                else if (lenw3 > 0)
                {
                    Console.Write(0);
                    lenw3--;
                }
                else if(lenw2 > 0)
                {
                    if (w2Is8)
                    {
                        Console.Write(8);
                    }
                    else
                    {
                        Console.Write(w2);
                    }
                    lenw2--;
                }
                else
                {
                    Console.Write(9);
                }
            }
            Console.Write(" ");

            // largestSum ( w1, w2, w3)
            lenw1 = (int)s / 9;
            lenw2 = 1;
            lenw3 = m - lenw1 - lenw2;
            w2 = (int)s % 9;
            
            for (int i = 0; i < m; i++)
            {
                if ( lenw1 > 0 )
                {
                    Console.Write(9);
                    lenw1--;
                }
                else if ( lenw2 > 0)
                {
                    Console.Write(w2);
                    lenw2--;
                }
                else
                {
                    Console.Write(0);
                }
            }
            Console.Write("\n");
        }
    }
}
