using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Game[] games = new Game[n];
            for (int i = 0; i < n; i++)
            {
                var goals = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                games[i] = new Game(goals[0], goals[1], goals[2], goals[3]);
            }
            foreach(var game in games)
            {
                game.ProcessGame();
            }
        }
    }

    public class Game
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public Game(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        
        public void ProcessGame()
        {
            if ((A + C) > (B + D))
            {
                Console.WriteLine("perspolis");
            }
            else if ((A + C) < (B + D))
            {
                Console.WriteLine("esteghlal");
            }
            else
            {
                if (C > B)
                {
                    Console.WriteLine("perspolis");
                }
                else if (C < B)
                {
                    Console.WriteLine("esteghlal");
                }
                else
                {
                    Console.WriteLine("penalty");
                }
            }
        }
    }
    
}
