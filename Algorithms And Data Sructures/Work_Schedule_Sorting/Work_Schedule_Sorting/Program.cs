using System;
using System.Collections.Generic;
using System.Linq;

namespace Work_Schedule_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<object>> workplaceDictionary = new Dictionary<int, List<object>>();

            Console.Write("Enter the maximum ID count: ");
            int maxId;
            if (!int.TryParse(Console.ReadLine(), out maxId) || maxId <= 0)
            {
                Console.WriteLine("Invalid maximum ID count. Please enter a positive integer.");
                return;
            }

            for (int id = 1; id <= maxId; id++)
            {
                Console.WriteLine($"\nEntering information for ID {id}:");

                Console.Write("Enter workplace name: ");
                string workplace = Console.ReadLine();

                Console.Write("Enter deadline: ");
                string deadline = Console.ReadLine();

                Console.Write("Enter money: ");
                int money;
                if (!int.TryParse(Console.ReadLine(), out money))
                {
                    Console.WriteLine("Invalid input. Money should be an integer.");
                    id--;
                    continue;
                }

                List<object> workplaceInfo = new List<object> { workplace, deadline, money };
                workplaceDictionary[id] = workplaceInfo;
            }

            var sortedDictionary = workplaceDictionary.OrderByDescending(kvp => kvp.Value[2])
                                                  .ThenBy(kvp => kvp.Value[0])
                                                  .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            // Calculate the sum of money for each workplace with a higher deadline value than the previous one
            Dictionary<string, int> workplaceSums = new Dictionary<string, int>();
            int totalMoney = 0;
            string previousDeadline = string.Empty;

            foreach (var kvp in sortedDictionary)
            {
                int money = (int)kvp.Value[2];
                string workplace = (string)kvp.Value[0];
                string deadline = (string)kvp.Value[1];

                if (string.Compare(deadline, previousDeadline) > 0)
                {
                    totalMoney += money;

                    if (!workplaceSums.ContainsKey(workplace))
                    {
                        workplaceSums[workplace] = money;
                    }
                    else
                    {
                        workplaceSums[workplace] += money;
                    }

                    previousDeadline = deadline;
                }
            }
            Console.WriteLine($"Maximum win: {totalMoney}");

            // Print the resulting dictionary
            Console.WriteLine("\nWorkplace Dictionary:");
            foreach (var kvp in sortedDictionary)
            {
                int id = kvp.Key;
                List<object> info = kvp.Value;
                Console.WriteLine($"Workplace: {info[0]}, Deadline: {info[1]}, Money: {info[2]}");
            }
        }
    }
}
