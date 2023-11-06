using System;
namespace Basics
{
    public class Methods
    {
        public void WriteLineBoolean()
        {
            bool isTrue = true;
            bool isFalse = false;

            Console.WriteLine("Boolean variable isTrue: " + isTrue);
            Console.WriteLine("Boolean variable isFalse: " + isFalse);
        }

        // Method to calculate sum and product of two numbers
        public static void Calculate(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }

        public static void PrintNumbers(params int[] numbers)
        {
            Console.WriteLine("Numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void EntryMain()
        {
            // Calling the method with different numbers of arguments
            PrintNumbers(1, 2, 3);
            PrintNumbers(4, 5, 6, 7, 8);
            PrintNumbers(9);
        }

        public void PrintNumberOfEvenNumbers()
        {
            Console.WriteLine("Enter number:");
            int numberOfEvenNumbers = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int number = 2; // Starting from the first even number

            Console.WriteLine("Even numbers:");
            while (count < numberOfEvenNumbers)
            {
                // Check if the number is even and print it
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                    count++;
                }
                number++;
            }
        }
    }

    public class StaticClass
    {
        // Static method
        public static void StaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }

        // Instance method
        public void InstanceMethod()
        {
            Console.WriteLine("This is an instance method.");
        }

        // Main method to demonstrate static and instance methods
        public static void Entry3Main()
        {
            // Calling static method directly using the class name
            StaticClass.StaticMethod();

            // Creating an instance of ExampleClass
            StaticClass instance = new StaticClass();

            // Calling instance method using the instance of the class
            instance.InstanceMethod();
        }
    }
}
