using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> inputList = new List<int> { 1, 3, 4, 2, 2, 5, 7, 6 };
        List<int> result = FindLargestNonDecreasingSubsequence(inputList);

        Console.WriteLine("Input List: [" + string.Join(", ", inputList) + "]");
        Console.WriteLine("Largest Non-Decreasing Subsequence: [" + string.Join(", ", result) + "]");
    }
    static List<int> FindLargestNonDecreasingSubsequence(List<int> inputList)
    {
        if (inputList == null || inputList.Count == 0)
        {
            return new List<int>();
        }

        List<int> largestSubsequence = new List<int>();
        List<int> currentSubsequence = new List<int>();

        for (int i = 0; i < inputList.Count; i++)
        {
            if (currentSubsequence.Count == 0 || inputList[i] >= currentSubsequence.Last())
            {
                currentSubsequence.Add(inputList[i]);
            }
            else
            {
                if (currentSubsequence.Count > largestSubsequence.Count)
                {
                    largestSubsequence = currentSubsequence.ToList();
                }
                currentSubsequence.Clear();
                currentSubsequence.Add(inputList[i]);
            }
        }

        // Check the last subsequence
        if (currentSubsequence.Count > largestSubsequence.Count)
        {
            largestSubsequence = currentSubsequence;
        }

        return largestSubsequence;
    }
}
