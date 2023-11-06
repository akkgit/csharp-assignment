using System;
namespace Basics
{
    public class _4th
    {
       public void First()
       {
            Calculator_14 calculator = new Calculator_14();

            // Calling the Add method with different numbers of parameters
            int sum1 = calculator.Add(5, 10);             // Output: 15
            int sum2 = calculator.Add(2, 7, 11);           // Output: 20
            double sum3 = calculator.Add(3.5, 2.7);        // Output: 6.2

            Console.WriteLine("Sum 1: " + sum1);
            Console.WriteLine("Sum 2: " + sum2);
            Console.WriteLine("Sum 3: " + sum3);
        }

       public void Second()
       {
            Calculator_14 calculator = new Calculator_14();

            // Calling the Add method with different orders of parameters
            int sum1 = calculator.Add(5, 10);       // Output: 15
            int sum2 = calculator.Add(10, 5);       // Output: 15 (order of parameters reversed)
            int sum3 = calculator.Add(2, 7, 11);    // Output: 20

            Console.WriteLine("Sum 1: " + sum1);
            Console.WriteLine("Sum 2: " + sum2);
            Console.WriteLine("Sum 3: " + sum3);
        }

       public void Third()
       {
            Calculator_14 calculator = new Calculator_14();

            // Calling the Sum() function with different sets of parameters
            calculator.Sum(1, 2, 3, 4);                    // Output: Sum of Values: 10
            calculator.Sum(5, 10, 15, 20, 25);             // Output: Sum of Values: 75
            calculator.Sum(2, 4, 6, 8, 10, 12, 14, 16);    // Output: Sum of Values: 72
       }

       public void Fourth()
       {
            Calculator_14 calculator = new Calculator_14();

            // Calling the Division() function with different sets of parameters
            calculator.Division(10, 20, 30);        // Output: Divisors of 10: 1 2 5 10
                                                    //         Divisors of 20: 1 2 4 5 10 20
                                                    //         Divisors of 30: 1 2 3 5 6 10 15 30

            calculator.Division(15, 25, 35, 50);    // Output: Divisors of 15: 1 3 5 15
                                                    //         Divisors of 25: 1 5 25
                                                    //         Divisors of 35: 1 5 7 35
                                                    //         Divisors of 50: 1 2 5 10 25 50
        }
    }

    public class Calculator_14
    {
        // Method with two integer parameters
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Overloaded method with three integer parameters
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        // Overloaded method with double parameters
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Function to calculate and print the sum of values
        public void Sum(params int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            Console.WriteLine("Sum of Values: " + sum);
        }

        // Function to calculate and print divisors of values
        public void Division(params int[] values)
        {
            foreach (int value in values)
            {
                Console.Write("Divisors of " + value + ": ");
                for (int i = 1; i <= value; i++)
                {
                    if (value % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
