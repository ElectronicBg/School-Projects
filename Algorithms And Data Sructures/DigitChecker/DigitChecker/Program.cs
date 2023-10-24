using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a natural number in the range [10 - 30000]: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 10 || number > 30000)
        {
            Console.WriteLine("The number is not in the range [10 - 30000].");
            return;
        }

        Console.Write("Enter the digit to check: ");
        int digitToCheck = int.Parse(Console.ReadLine());

        if (digitToCheck >= 0 && digitToCheck <= 9)
        {
            bool containsDigit = CheckForDigit(number, digitToCheck);
            if (containsDigit)
            {
                Console.WriteLine($"The digit {digitToCheck} is present in the number {number}.");
            }
            else
            {
                Console.WriteLine($"The digit {digitToCheck} is not present in the number {number}.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid digit (0-9).");
        }
    }

    static bool CheckForDigit(int number, int digitToCheck)
    {
        while (number > 0)
        {
            int lastDigit = number % 10;
            if (lastDigit == digitToCheck)
            {
                return true;
            }
            number /= 10;
        }
        return false;
    }
}
