using System;

class Program
{
    static void Main()
    {
        // Вход
        string[] inputSize = Console.ReadLine().Split();
        int rows = int.Parse(inputSize[0]);
        int cols = int.Parse(inputSize[1]);

        char[,] chessboard = new char[rows, cols];

        // Инициализация на шахматната дъска
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                chessboard[i, j] = ' ';
            }
        }

        // Задаване на позициите на фигурите
        string[] inputFigures = Console.ReadLine().Split();
        foreach (var figure in inputFigures)
        {
            int col = figure[0] - 'A';
            int row = figure[1] - '1';
            chessboard[row, col] = 'X';
        }

        // Изчисляване на броя на начините
        int ways = CountWays(chessboard, rows, cols);

        // Изход
        Console.WriteLine(ways);
    }

    static int CountWays(char[,] chessboard, int rows, int cols)
    {
        int[,] dp = new int[rows, cols];
        dp[0, 0] = 1;

        // Инициализация на първия ред
        for (int j = 1; j < cols; j++)
        {
            if (chessboard[0, j] == 'X')
                break;
            dp[0, j] = 1;
        }

        // Инициализация на първата колона
        for (int i = 1; i < rows; i++)
        {
            if (chessboard[i, 0] == 'X')
                break;
            dp[i, 0] = 1;
        }

        // Изчисляване на броя на начините за всяка клетка
        for (int i = 1; i < rows; i++)
        {
            for (int j = 1; j < cols; j++)
            {
                if (chessboard[i, j] != 'X')
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }
        }

        return dp[rows - 1, cols - 1];
    }
}
