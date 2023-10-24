using System;

class NQueens
{
    private static int boardSize;
    private static int solutionsCount = 0;

    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the chessboard: ");
        if (int.TryParse(Console.ReadLine(), out boardSize) && boardSize > 0)
        {
            int[] queens = new int[boardSize];
            SolveNQueens(0, queens);
            Console.WriteLine($"Found {solutionsCount} distinct solutions.");
        }
        else
        {
            Console.WriteLine("Please enter a positive integer for the board size.");
        }
    }

    private static void SolveNQueens(int row, int[] queens)
    {
        if (row == boardSize)
        {
            solutionsCount++;
            PrintSolution(queens);
            return;
        }

        for (int col = 0; col < boardSize; col++)
        {
            if (IsSafe(row, col, queens))
            {
                queens[row] = col;
                SolveNQueens(row + 1, queens);
            }
        }
    }

    private static bool IsSafe(int row, int col, int[] queens)
    {
        for (int i = 0; i < row; i++)
        {
            if (queens[i] == col || Math.Abs(queens[i] - col) == Math.Abs(i - row))
            {
                return false;
            }
        }
        return true;
    }

    private static void PrintSolution(int[] queens)
    {
        Console.WriteLine($"Solution {solutionsCount}:\n");
        for (int row = 0; row < boardSize; row++)
        {
            for (int col = 0; col < boardSize; col++)
            {
                if (queens[row] == col)
                {
                    Console.Write("Q ");
                }
                else
                {
                    Console.Write(". ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
