using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
        PrintUniquePermutationsAndSum(myArray);
    }

    static void PrintUniquePermutationsAndSum(int[] arr)
    {
        var permSet = GetUniquePermutations(arr);
        int count = 0;

        foreach (var perm in permSet)
        {
            count++;
            Console.WriteLine($"Permutation {count}: [{string.Join(", ", perm)}] - Sum: {perm.Sum()}");
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void GeneratePermutations(int[] arr, int startIndex, int endIndex, HashSet<int[]> permSet)
    {
        if (startIndex == endIndex)
        {
            permSet.Add(arr.Take(4).ToArray());
        }
        else
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                Swap(ref arr[startIndex], ref arr[i]);
                GeneratePermutations(arr, startIndex + 1, endIndex, permSet);
                Swap(ref arr[startIndex], ref arr[i]);
            }
        }
    }

    static HashSet<int[]> GetUniquePermutations(int[] arr)
    {
        var permSet = new HashSet<int[]>(new ArrayComparer());
        GeneratePermutations(arr, 0, arr.Length - 1, permSet);

        return permSet;
    }

    // Custom comparer for arrays to use in HashSet
    public class ArrayComparer : IEqualityComparer<int[]>
    {
        public bool Equals(int[] x, int[] y)
        {
            return x.SequenceEqual(y);
        }

        public int GetHashCode(int[] obj)
        {
            return obj.Aggregate(17, (hash, val) => hash * 23 + val.GetHashCode());
        }
    }
}