using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

[Serializable]
public class PlayerData
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Gold { get; set; }
    public List<string> Inventory { get; set; }
}

[Serializable]
public class Player
{
    public PlayerData playerData;

    public Player(string name)
    {
        playerData = new PlayerData
        {
            Name = name,
            Health = 100,  
            Gold = 0,      
            Inventory = new List<string>()
        };
    }

    public void Explore()
    {
        Random random = new Random();
        int eventNumber = random.Next(1, 4);

        switch (eventNumber)
        {
            case 1:
                int treasureAmount = random.Next(10, 101);
                Console.WriteLine($"You found a treasure chest with {treasureAmount} gold!");
                AddGold(treasureAmount);
                break;

            case 2:
                int damage = random.Next(10, 31);
                Console.WriteLine($"You were attacked by a monster and took {damage} damage!");
                TakeDamage(damage);
                break;

            case 3:
                string[] items = { "Potion", "Scroll", "Gem" };
                int itemIndex = random.Next(0, items.Length);
                string foundItem = items[itemIndex];
                Console.WriteLine($"You found a {foundItem} in the dark corners of the dungeon!");
                AddToInventory(foundItem);
                break;
        }
    }

    public void CheckInventory()
    {
        foreach (var item in playerData.Inventory)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Gold: {playerData.Gold}");
    }

    public bool IsAlive()
    {
        return playerData.Health > 0;
    }

    public void AddGold(int amount)
    {
        playerData.Gold += amount;
    }

    public void TakeDamage(int damage)
    {
        playerData.Health -= damage;
        if (playerData.Health < 0)
        {
            playerData.Health = 0;
        }
    }

    public void AddToInventory(string item)
    {
        playerData.Inventory.Add(item);
    }

    public void SavePlayerData()
    {
        string fileName = $"{playerData.Name}_player_data.txt"; 
        string json = JsonConvert.SerializeObject(playerData);
        File.WriteAllText(fileName, json);
        Console.WriteLine("Player data saved.");
    }

    public static Player LoadPlayerData(string playerName)
    {
        string fileName = $"{playerName}_player_data.txt"; 
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            PlayerData playerData = JsonConvert.DeserializeObject<PlayerData>(json);

            Player player = new Player(playerData.Name);
            player.playerData = playerData; 

            Console.WriteLine("Player data loaded.");
            return player;
        }
        else
        {
            return null;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Underground Adventures!");

        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();

        Player player;

      
        player = Player.LoadPlayerData(playerName);

        if (player == null)
        {
            player = new Player(playerName);
            Console.WriteLine("New game started.");
        }
        else
        {
            Console.WriteLine("Welcome back, " + player.playerData.Name + "!");
        }

        PlayGame(player);

        
        player.SavePlayerData();
    }

    static void PlayGame(Player player)
    {
        while (player.IsAlive())
        {
            Console.WriteLine("\nSelect an action:");
            Console.WriteLine("1. Explore the underground");
            Console.WriteLine("2. Check Inventory");
            Console.WriteLine("3. Exit the game");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    player.Explore();
                    break;

                case "2":
                    player.CheckInventory();
                    break;

                case "3":
                    Console.WriteLine("Exiting the game. Thanks for playing!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
