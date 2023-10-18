using System;

class Towers_Of_Hanoi
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of disks: ");
        int numDisks = int.Parse(Console.ReadLine());

        TowerOfHanoi(numDisks, 'A', 'C', 'B');
    }

    static void TowerOfHanoi(int n, char source, char destination, char auxiliary)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {source} to {destination}");
            return;
        }

        TowerOfHanoi(n - 1, source, auxiliary, destination);
        Console.WriteLine($"Move disk {n} from {source} to {destination}");
        TowerOfHanoi(n - 1, auxiliary, destination, source);
    }
}
