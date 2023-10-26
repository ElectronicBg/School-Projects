using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Of_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            int currentTerm = 1; 

            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.Write(currentTerm);
                }
                else
                {
                    Console.Write(currentTerm + "+");
                }

                sum += currentTerm; 
                currentTerm = currentTerm * 10 + 1; 
            }

            Console.WriteLine();
            Console.WriteLine("Sum: " + sum);

        }
    }
}
