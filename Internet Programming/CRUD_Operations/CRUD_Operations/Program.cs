using System;
using System.Collections.Generic;

namespace CRUD_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            View();

            int input = int.Parse(Console.ReadLine());
            while (input != 6)
            {
                switch (input)
                {
                    case 1:
                        Read(myDictionary);
                        View();
                        break;
                    case 2:
                        GetItemById(myDictionary);
                        View();
                        break;
                    case 3:
                        Create(myDictionary);
                        View();
                        break;
                    case 4:
                        UpdateItemById(myDictionary);
                        View();
                        break;
                    case 5:
                        DeleteItemById(myDictionary);
                        View();
                        break;
                }
                input = int.Parse(Console.ReadLine());
            }

        }
        public static void Create(Dictionary<int, string> dictionary)
        {
            int id = dictionary.Count + 1;
            Console.WriteLine("Enter item name: ");

            string value = Console.ReadLine();
            Console.WriteLine($"{value} added with id = {id}");

            dictionary.Add(id, value);
        }
        public static void Read(Dictionary<int, string> dictionary)
        {
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"ID: {kvp.Key}, Value: {kvp.Value}");
            }
        }
        public static void GetItemById(Dictionary<int, string> dictionary)
        {
            Console.WriteLine("Enter item  ID: ");
            int id = int.Parse(Console.ReadLine());

            if (dictionary.ContainsKey(id))
            {
                Console.WriteLine($"{dictionary[id]}");
            }
            else
            {
                Console.WriteLine($"Item with ID {id} doesn't exist!");
            }
        }
        public static void UpdateItemById(Dictionary<int, string> dictionary)
        {
            Console.WriteLine("Enter item  ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter item new value: ");
            string newItemValue = Console.ReadLine();

            if (dictionary.ContainsKey(id))
            {
                dictionary[id] = newItemValue;
                Console.WriteLine($"Item with ID {id} has been updated.");
            }
            else
            {
                Console.WriteLine($"Item with ID {id} doesn't exist!");
            }
        }
        public static void DeleteItemById(Dictionary<int, string> dictionary)
        {
            Console.WriteLine("Enter item  ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            if (dictionary.ContainsKey(id))
            {
                dictionary.Remove(id);
                Console.WriteLine($"Item with ID {id} has been deleted.");
            }
            else
            {
                Console.WriteLine($"Item with ID {id} doesn't exist!");
            }
        }
        public static void View()
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. GET all items");
            Console.WriteLine("2. GET item by ID");
            Console.WriteLine("3. POST a new item");
            Console.WriteLine("4. PUT update item by ID");
            Console.WriteLine("5. DELETE item by ID");
            Console.WriteLine("6. Exit");
        }
    }
}

