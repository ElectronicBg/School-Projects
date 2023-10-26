using System;

namespace Cube_Of_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Number is {i} and cube of the {i} is: {Math.Pow(i,3)} ");
            }
        }
    }
}
