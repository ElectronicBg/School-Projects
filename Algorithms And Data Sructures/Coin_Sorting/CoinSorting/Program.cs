using System;
using System.Collections.Generic;

namespace Coin_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the available coin denominations.
            double[] coins = { 1, 2, 5, 10, 20, 50 };

            // Get the desired value from the user.
            Console.Write("Enter the desired value: ");
            double wantedValue = double.Parse(Console.ReadLine());

            // Initialize variables.
            int coinsLength = coins.Length - 1;
            List<int> wantedCoins = new List<int>();

            // Iterate through the coin denominations.
            while (coinsLength >= 0)
            {
                if (wantedValue / coins[coinsLength] < 1)
                {
                    // If the current coin is too large, move to the next smaller coin.
                    coinsLength -= 1;
                }
                else
                {
                    // Subtract the coin value from the desired value.
                    wantedValue -= coins[coinsLength];

                    // Add the coin to the list of wanted coins.
                    wantedCoins.Add((int)coins[coinsLength]);
                }
            }

            // Print the list of wanted coins.
            Console.WriteLine("Selected coins:");
            Console.WriteLine(string.Join(" ", wantedCoins));
        }
    }
}
