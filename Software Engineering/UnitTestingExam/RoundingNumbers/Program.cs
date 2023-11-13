using System;

namespace RoundingNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the numbers:");

            double[] numbers = new double[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                double number = double.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            double[] roundedNumbers = RoundNumbers(numbers);

            Console.WriteLine();
            Console.WriteLine("The result is:");
            foreach (double roundedNumber in roundedNumbers)
            {
                Console.WriteLine(roundedNumber);
            }
        }

        public static double[] RoundNumbers(double[] inputNumbers)
        {
            double[] roundedNumbers = new double[inputNumbers.Length];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                roundedNumbers[i] = Math.Round(inputNumbers[i]);
            }

            return roundedNumbers;
        }
    }
}
