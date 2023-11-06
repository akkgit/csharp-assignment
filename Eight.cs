using System;
namespace Basics
{
    public class Eight
    {
        public void FirstNNaturalNumbers()
        {
            Console.WriteLine("Enter number of natural terms do you want:");
            int n = Convert.ToInt32(Console.ReadLine());

            // Displaying the first n natural numbers and calculating their sum
            int sum = 0;
            Console.Write("The first " + n + " natural numbers are: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine("\nThe Sum of Natural Numbers up to " + n + " terms: " + sum);
        }
        public void FirstOddNaturalNumber()
        {
            Console.WriteLine("Enter number of terms:");
            int n = Convert.ToInt32(Console.ReadLine());

            // Displaying the first n odd natural numbers and calculating their sum
            int sum = 0;
            Console.Write("The odd numbers are: ");
            for (int i = 1; i <= n; i++)
            {
                int oddNumber = 2 * i - 1;
                Console.Write(oddNumber + " ");
                sum += oddNumber;
            }

            Console.WriteLine("\nThe Sum of odd Natural Numbers up to " + n + " terms: " + sum);
        }
        public void ArrayWithForAndForeachLoop()
        {
            Console.WriteLine("Enter Array (separate strings with space):");
            string[] inputArray = Console.ReadLine().Split(' ');

            // Printing the array using for loop
            Console.WriteLine("Array printing using for loop:");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i]);
            }

            Console.WriteLine(); // New line

            // Printing the array using foreach loop
            Console.WriteLine("Array printing using ForEach loop:");
            foreach (string item in inputArray)
            {
                Console.Write(item);
            }
        }
    }
}
