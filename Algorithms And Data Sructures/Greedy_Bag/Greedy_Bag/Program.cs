using System;
using System.Linq;

namespace Greedy_Bag
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] weights = { 2, 3, 4, 5 };
            int[] values = { 3, 4, 5, 6 };
            int capacity = 15;

            // Solve the knapsack problem using the greedy algorithm
            int[] selectedItems = GreedyKnapsack(weights, values, capacity);

            // Print the selected items
            Console.WriteLine("Selected items:");
            for (int i = 0; i < selectedItems.Length; i++)
            {
                Console.WriteLine($"Item {i + 1}: {(selectedItems[i] == 1 ? "Selected" : "Not selected")}");
            }
        }

        // Greedy algorithm to solve the 0/1 Knapsack problem
        static int[] GreedyKnapsack(int[] weights, int[] values, int capacity)
        {
            int n = weights.Length;
            int[] selectedItems = new int[n];
            double[] valuePerWeight = new double[n];

            // Calculate the value-to-weight ratio for each item
            for (int i = 0; i < n; i++)
            {
                valuePerWeight[i] = (double)values[i] / weights[i];
            }

            // Sort items based on the value-to-weight ratio in decreasing order
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (valuePerWeight[i] < valuePerWeight[j])
                    {
                        // Swap items to maintain descending order
                        swap(ref valuePerWeight[i], ref valuePerWeight[j]);
                        swap(ref weights[i], ref weights[j]);
                        swap(ref values[i], ref values[j]);
                    }
                }
            }

            int currentWeight = 0;

            // Fill the knapsack with selected items
            for (int i = 0; i < n; i++)
            {
                if (currentWeight + weights[i] <= capacity)
                {
                    selectedItems[i] = 1;
                    currentWeight += weights[i];
                }
                else
                {
                    selectedItems[i] = 0;
                }
            }

            return selectedItems;
        }

        // Helper method to swap two values of any type
        static void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
