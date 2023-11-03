using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the elements of the array separated by spaces: ");
        int[] A = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        FindArrayLeaders(A, n);
    }

    public static void FindArrayLeaders(int[] A, int n)
    {
        List<int> leaders = new List<int>();
        int maxRight = A[n - 1];
        leaders.Add(maxRight);

        for (int i = n - 2; i >= 0; i--)
        {
            if (A[i] >= maxRight)
            {
                maxRight = A[i];
                leaders.Add(maxRight);
            }
        }

        leaders.Reverse();
        Console.WriteLine("The leaders in the array are: " + string.Join(" ", leaders));
    }
}
