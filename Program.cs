using System;
using Mission4_Team314;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");
        char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char currentPlayer = 'X';
        Supporting game = new Supporting();

        while (true)
        {
            Console.Clear();
            game.PrintBoard(board);
            Console.Write($"Player {currentPlayer}, enter your move (1-9): ");
            int move = int.Parse(Console.ReadLine());

            if (move < 1 || move > 9 || board[move - 1] == 'X' || board[move - 1] == 'O')
            {
                Console.WriteLine("Invalid move. Try again.");
                continue;
            }

            board[move - 1] = currentPlayer;

            if (game.CheckForWin(board, currentPlayer))
            {
                Console.Clear();
                game.PrintBoard(board);
                Console.WriteLine($"Player {currentPlayer} wins!");
                break;
            }

            if (Array.IndexOf(board, ' ') == -1)
            {
                Console.Clear();
                game.PrintBoard(board);
                Console.WriteLine("It's a draw!");
                break;
            }

            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }
    }
}
