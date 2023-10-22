using System;
using System.Threading.Tasks;

class NQueens
{
    private static int boardSize;
    private static int solutionsCount = 0;

    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the chessboard: ");
        if (int.TryParse(Console.ReadLine(), out boardSize) && boardSize > 0)
        {
            Parallel.For(0, boardSize, row =>
            {
                int[] queens = new int[boardSize];
                queens[0] = row;
                SolveNQueens(1, queens);
            });

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
            if (IsDistinctSolution(queens))
            {
                PrintSolution(queens);
                solutionsCount++;
            }
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

    private static bool IsDistinctSolution(int[] queens)
    {
        for (int i = 0; i < boardSize - 1; i++)
        {
            for (int j = i + 1; j < boardSize; j++)
            {
                if (queens[i] == queens[j] || Math.Abs(queens[i] - queens[j]) == Math.Abs(i - j))
                {
                    return false;
                }
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
                Console.Write(queens[row] == col ? "Q " : "█ ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
