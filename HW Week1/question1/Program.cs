using System;

namespace question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Unnecessary input :)
            int k = int.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();
            string output = inputString;

            for (int i = 0; i < k; i++)
            {
                output = ShiftOneChar(ChangePosition(output));
            }
            Console.WriteLine(output);
        }

        public static string ShiftOneChar(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
               if (input[i] == 'z')
               {
                    output += 'a';
                }
                else
                {
                    output += (char)(input[i] + 1);
                }
            }
            return output;
        }


        public static string ChangePosition(string input)
        {
            string output = "";
            output += input[input.Length - 1];

            for (int i = 0; i < input.Length - 1; i++)
            {
                output += input[i];
            }
            return output;
        }
    }
}
