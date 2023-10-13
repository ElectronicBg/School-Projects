using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a list of numbers separated by spaces:");
        string input = Console.ReadLine();

        List<int> myList = ParseInput(input);

        if (myList.Count > 0)
        {
            int maxElement = FindMaxRecursive(myList);
            Console.WriteLine("The largest element in the list is: " + maxElement);
        }
        else
        {
            Console.WriteLine("The list is empty.");
        }
    }

    static List<int> ParseInput(string input)
    {
        List<int> list = new List<int>();
        string[] tokens = input.Split(' ');

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int number))
            {
                list.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input: " + token + " is not a valid number and will be ignored.");
            }
        }

        return list;
    }

    static int FindMaxRecursive(List<int> list)
    {
        if (list.Count == 0)
            return int.MinValue;

        if (list.Count == 1)
            return list[0];

        int mid = list.Count / 2;
        List<int> leftHalf = list.GetRange(0, mid);
        List<int> rightHalf = list.GetRange(mid, list.Count - mid);

        int maxLeft = FindMaxRecursive(leftHalf);
        int maxRight = FindMaxRecursive(rightHalf);

        return Math.Max(maxLeft, maxRight);
    }
}
