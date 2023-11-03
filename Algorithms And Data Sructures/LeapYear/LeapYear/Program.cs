using System;

public class LepYear
{
    public static int IsLeap(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            return 1; 
        }
        else
        {
            return 0; 
        }
    }

    static void Main()
    {
        int year = 4;
        int result = IsLeap(year);
        Console.WriteLine(result);
    }
}
