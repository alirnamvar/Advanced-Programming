using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new TicTacToe();
            game.Play();
        }   
    }

    class TicTacToe
    {
        private readonly char[,] board = new char[3, 3];
        private char player = 'X';

        public TicTacToe()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }

        public void DrawBoard()
        {
            Console.WriteLine(" {0} | {1} | {2} ", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", board[2, 0], board[2, 1], board[2, 2]);
        }

        public void Play()
        {
            while (true)
            {
                DrawBoard();
                GetPlayerInput();
                if (CheckForWin())
                {
                    DrawBoard();
                    Console.WriteLine("Player {0} wins!", player);
                    break;
                }
                else if (CheckForTie())
                {
                    DrawBoard();
                    Console.WriteLine("Tie!");
                    break;
                }
                else
                {
                    ChangePlayer();
                }
            }
        }

        public void GetPlayerInput()
        {
            Console.WriteLine("Player {0}'s turn", player);
            Console.Write("Enter row: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter column: ");
            int column = int.Parse(Console.ReadLine());
            board[row - 1, column - 1] = player;
        }

        public void ChangePlayer()
        {
            if (player == 'X')
            {
                player = 'O';
            }
            else
            {
                player = 'X';
            }
        }

        public bool CheckForWin()
        {
            // Check for horizontal win
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                {
                    return true;
                }
            }

            // Check for vertical win
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
                {
                    return true;
                }
            }

            // Check for diagonal win
            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            {
                return true;
            }
            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
            {
                return true;
            }

            return false;
        }

        bool CheckForTie()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
