using System;

class Program
{
    static void Main()
    {
        int targetNumber = int.Parse(Console.ReadLine()); 
        int index = FindFibonacciIndex(targetNumber, 0);

        if (index != -1)
        {
            Console.WriteLine($"The index of {targetNumber} in the Fibonacci sequence is: {index}");
        }
        else
        {
            Console.WriteLine($"{targetNumber} is not found in the Fibonacci sequence.");
        }
    }

    static int FindFibonacciIndex(int target, int currentIndex, int a = 0, int b = 1)
    {
        if (a == target)
        {
            return currentIndex;
        }
        else if (a > target)
        {
            return -1;
        }
        else
        {
            return FindFibonacciIndex(target, currentIndex + 1, b, a + b);
        }
    }
}
