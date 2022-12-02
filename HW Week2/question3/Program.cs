using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('*').ToArray();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            Board board = new Board(n, m);
            //board.PrintBoard();

            Frog frog = new Frog(board);
            while (frog.IsAlive)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "Down":
                        frog.Action("Down");
                        break;
                    case "Up":
                        frog.Action("Up");
                        break;
                    case "Left":
                        frog.Action("Left");
                        break;
                    case "Right":
                        frog.Action("Right");
                        break;
                    case "Finish":
                        Console.WriteLine($"Energy {frog.Energy}!");
                        frog.IsAlive = false;
                        break;
                    case "Location":
                        Console.WriteLine($"Location ({frog.X},{frog.Y})");
                        break;
                }
            } 
        }      
    }

    public class Frog
    {
        public bool IsAlive{ get; set; }
        public int Energy { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Board Board { get; set; }

        public Frog(Board board)
        {
            Board = board;
            IsAlive = true;
            Energy = 0;
            X = 0;
            Y = 0;
            //ProcessThisGrid(X, Y);
        }

        public void Action(string action)
        {
            switch (action)
            {
                case "Down":
                    MoveDown();
                    break;
                case "Up":
                    MoveUp();
                    break;
                case "Left":
                    MoveLeft();
                    break;
                case "Right":
                    MoveRight();
                    break;
            }
        }

        private void MoveUp()
        {
            if (IsMoveValid(X - 1, Y))
            {
                ProcessThisGrid(X - 1, Y);
            }
            else
            {
                Console.WriteLine("Impossible place!");
            }
        }

        private void MoveDown()
        {
            if (IsMoveValid(X + 1, Y))
            {
                ProcessThisGrid(X + 1, Y);
            }
            else
            {
                Console.WriteLine("Impossible place!");
            }
        }

        private void MoveLeft()
        {
            if (IsMoveValid(X, Y - 1))
            {
                ProcessThisGrid(X, Y - 1);
            }
            else
            {
                Console.WriteLine("Impossible place!");
            }
        }

        private void MoveRight()
        {
            if (IsMoveValid(X, Y + 1))
            {
                ProcessThisGrid(X, Y + 1);
            }
            else
            {
                Console.WriteLine("Impossible place!");
            }
        }

        private void ProcessThisGrid(int x, int y)
        {
            if (Board.Grid[x, y] == "0")
            {
                X = x;
                Y = y;
            }
            else if (Board.Grid[x, y] == "-1")
            {
                Console.WriteLine($"Frog hunted by crocodile :-/! Energy {Energy}!");
                IsAlive = false;
            }
            else if (ActionIsJump(Board.Grid[x, y]))
            {
                string[] xy = Board.Grid[x, y].Split(',').ToArray();
                int newX = int.Parse(xy[0]);
                int newY = int.Parse(xy[1]);

                if (IsMoveValid(newX, newY))
                {
                    Console.WriteLine($"Jump to ({newX},{newY})");
                    ProcessThisGrid(newX, newY);
                }
                else
                {
                    X = x;
                    Y = y;
                    Console.WriteLine("Impossible place!");
                }
            }
            else
            {
                Energy += int.Parse(Board.Grid[x, y]);
                if (Energy <= 0)
                {
                    Console.WriteLine($"Frog died! Energy {Energy}!");
                    IsAlive = false;
                }
                else
                {
                    Console.WriteLine($"Energy {Energy}!");
                    X = x;
                    Y = y;
                }
            }
            
        }

        private bool ActionIsJump(string action)
        {
            return action.Contains(',');
        }

        private bool IsMoveValid(int x, int y)
        {
            if (x < 0 || x >= Board.N || y < 0 || y >= Board.M)
            {
                return false;
            }
            return true;
        }
    }

    public class Board
    {
        public string[,] Grid { get; set; }
        public int M { get; }
        public int N { get; }

        public Board(int n, int m)
        {
            N = n;
            M = m;
            Grid = new string[n, m];
            MakeWorld();
        }
        public void PrintBoard()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(Grid[i, j]);
                    if (j != M - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        private void MakeWorld()
        {
            for (int row = 0; row < N; row++)
            {
                string[] instructions = Console.ReadLine().Split(' ').ToArray();
                ProcessRowInput(instructions, row);
            }
        }
        private void ProcessRowInput(string[] instructions, int row)
        {
            int col = 0;
            foreach (var instruction in instructions)
            {
                UpdateOneGrid(instruction, col, row);
                col++;
            }
        }
        private void UpdateOneGrid(string instruction, int col, int row)
        {
            if (instruction == "N")
            {
                Grid[row, col] = "0";
            }
            else if (instruction == "C")
            {
                Grid[row, col] = "-1";
            }
            else if (instruction[0] == 'E')
            {
                string energy = instruction.Split('(')[1].Split(')')[0];
                Grid[row, col] = energy;

            }
            else if (instruction[0] == 'J')
            {
                string x = instruction.Split('(')[1].Split(',')[0];
                string y = instruction.Split(',')[1].Split(')')[0];
                Grid[row, col] = x + "," + y;
            }
        }
        
    }
    
}

