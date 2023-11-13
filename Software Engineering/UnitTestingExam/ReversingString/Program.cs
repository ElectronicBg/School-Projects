using System;

namespace ReversingString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array length: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the values:");

            string[] inputs = new string[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                inputs[i] = input;
            }

            string[] reversedArray = ReverseStringArray(inputs);

            Console.WriteLine();
            Console.WriteLine("The result is");

            foreach (string value in reversedArray)
            {
                Console.WriteLine(value + " ");
            }
        }

        public static string[] ReverseStringArray(string[] inputArray)
        {
            int length = inputArray.Length;
            string[] reversedArray = new string[length];

            for (int i = length - 1, j = 0; i >= 0; i--, j++)
            {
                reversedArray[j] = inputArray[i];
            }

            return reversedArray;
        }
    }
}

