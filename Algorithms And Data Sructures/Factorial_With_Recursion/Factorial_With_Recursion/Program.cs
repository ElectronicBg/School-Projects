using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to calculate its factorial: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                long factorial = CalculateFactorial(number);
                Console.WriteLine($"The factorial of {number} is {factorial}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * CalculateFactorial(n - 1);
    }
}
