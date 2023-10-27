using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of years: ");
        int years = int.Parse(Console.ReadLine());

        int sheepCount = CalculateSheepCount(years);

        Console.WriteLine($"In year {years}, there will be {sheepCount} sheep.");
    }

    static int CalculateSheepCount(int years)
    {
        if (years <= 0)
        {
            return 0;
        }
        else if (years == 1 || years == 2)
        {
            return 1; 
        }
        else if (years == 3)
        {
            return 2; 
        }
        else
        {           
            return CalculateSheepCount(years - 1) + CalculateSheepCount(years - 3);
        }
    }
}
