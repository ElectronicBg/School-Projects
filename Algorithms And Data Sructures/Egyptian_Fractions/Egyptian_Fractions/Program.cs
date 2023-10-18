using System;
using System.Collections.Generic;

class Egyptian_Fractions
{
    static void Main()
    {
        Console.Write("Enter the numerator a: ");
        int numerator = int.Parse(Console.ReadLine());
        Console.Write("Enter the denominator b: ");
        int denominator = int.Parse(Console.ReadLine());

        if (numerator >= denominator || numerator <= 0 || denominator <= 0)
        {
            Console.WriteLine("Invalid input. The numerator must be smaller than the denominator, and both numbers must be positive.");
            return;
        }

        List<int> egyptianFractions = FindEgyptianFractions(numerator, denominator);

        Console.WriteLine($"The representation of {numerator}/{denominator} as a sum of Egyptian fractions is:");
        for (int i = 0; i < egyptianFractions.Count; i++)
        {
            if (i == egyptianFractions.Count - 1)
            {
                Console.Write("1/" + egyptianFractions[i]);
            }
            else
            {
                Console.Write("1/" + egyptianFractions[i] + " + ");
            }
        }
    }

    static List<int> FindEgyptianFractions(int numerator, int denominator)
    {
        List<int> egyptianFractions = new List<int>();

        while (numerator != 0)
        {
            int nextDenominator = (denominator + numerator - 1) / numerator;
            egyptianFractions.Add(nextDenominator);

            numerator = numerator * nextDenominator - denominator;
            denominator = denominator * nextDenominator;

            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        return egyptianFractions;
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
