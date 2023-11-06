using System;
namespace Basics
{
    public class _3th
    {
       public void First()
        {
            // Creating an instance of Calculator class
            Calculator calculator = new Calculator();

            // Calling the Add method with three parameters
            int sum1 = calculator.Add(10, 20, 30);
            Console.WriteLine("Sum with three parameters: " + sum1); // Output: 60

            // Calling the Add method with two parameters
            int sum2 = calculator.Add(5, 15);
            Console.WriteLine("Sum with two parameters: " + sum2); // Output: 20
        }
       public void Second()
       {
            // Creating objects of derived classes
            Shape circle = new Circle();
            Shape rectangle = new Rectangle();

            // Invoking the Draw method using base class reference variables
            circle.Draw();    // Output: Drawing circle
            rectangle.Draw(); // Output: Drawing rectangle
        }
       public void Third()
       {
            Calculator calculator = new Calculator();

            // Calling the Add method with different parameters
            int sumIntegers = calculator.Add(5, 10);
            double sumDoubles = calculator.Add(2.5, 3.7, 1.2);
            string concatenatedStrings = calculator.Add("Hello, ", "World!");

            Console.WriteLine("Sum of integers: " + sumIntegers); // Output: 15
            Console.WriteLine("Sum of doubles: " + sumDoubles);   // Output: 7.4
            Console.WriteLine("Concatenated strings: " + concatenatedStrings); // Output: Hello, World!
        }
       public void Fourth()
        {
            Calculator calculator = new Calculator();

            // Calling the Add method with different data types
            int sumIntegers = calculator.Add(5, 10);
            double sumDoubles = calculator.Add(2.5, 3.7);
            string concatenatedStrings = calculator.Add("Hello, ", "World!");

            Console.WriteLine("Sum of integers: " + sumIntegers); // Output: 15
            Console.WriteLine("Sum of doubles: " + sumDoubles);   // Output: 6.2
            Console.WriteLine("Concatenated strings: " + concatenatedStrings); // Output: Hello, World!
        }
       public void Fifth()
       {
            Calculator calculator = new Calculator();

            // Calling the Add method with different orders of parameters
            int sum1 = calculator.Add(5, 10);       // Output: 15
            int sum2 = calculator.Add(10, 5);       // Output: 15 (order of parameters reversed)
            double sum3 = calculator.Add(3.5, 2.7);  // Output: 6.2 (order of parameters reversed)

            Console.WriteLine("Sum 1: " + sum1);
            Console.WriteLine("Sum 2: " + sum2);
            Console.WriteLine("Sum 3: " + sum3);
        }
       
    }

    public class Calculator
    {
        // Method with three parameters
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        // Method with two parameters (method overloading)
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Overloaded method with double parameters
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Method with three double parameters
        public double Add(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        // Method with two strings concatenation
        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }
    }

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing shape");
        }
    }

    // Derived class 1
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }

    // Derived class 2
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }
}
