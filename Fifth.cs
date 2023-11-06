using System;
namespace Basics
{
    public class Fifth
    {
        public void ArthimeticOperations()
        {
            Console.WriteLine("Enter the value of a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b:");
            int b = Convert.ToInt32(Console.ReadLine());

            // Perform arithmetic operations
            int additionResult = a + b;
            int subtractionResult = a - b;
            int multiplicationResult = a * b;

            // Check if b is not zero before performing division and modulo operations
            int divisionResult = (b != 0) ? (a / b) : 0;
            int moduloResult = (b != 0) ? (a % b) : 0;

            // Print the results
            Console.WriteLine("Addition Operator: " + additionResult);
            Console.WriteLine("Subtraction Operator: " + subtractionResult);
            Console.WriteLine("Multiplication Operator: " + multiplicationResult);
            Console.WriteLine("Division Operator: " + divisionResult);
            Console.WriteLine("Modulo Operator: " + moduloResult);
        }

        public void UnaryArthimeticOperator()
        {
            Console.WriteLine("Enter a value:");
            int a = Convert.ToInt32(Console.ReadLine());

            int res = a++;

            Console.WriteLine("a is " + a + " and res after post-increment (a++) is " + res);

            res = a--;

            Console.WriteLine("a is " + a + " and res after post-decrement (a--) is " + res);

            res = ++a;

            Console.WriteLine("a is " + a + " and res after pre-increment (++a) is " + res);

            res = --a;

            Console.WriteLine("a is " + a + " and res after pre-decrement (--a) is " + res);
        }

        public void RelationalOperator()
        {
            Console.WriteLine("Enter the value of a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b:");
            int b = Convert.ToInt32(Console.ReadLine());

            // Perform relational operations
            bool equalToOperator = a == b;
            bool greaterThanOperator = a > b;
            bool lessThanOperator = a < b;
            bool greaterThanOrEqualOperator = a >= b;
            bool lessThanOrEqualOperator = a <= b;
            bool notEqualToOperator = a != b;

            // Print the results
            Console.WriteLine("Equal to Operator: " + equalToOperator);
            Console.WriteLine("Greater than Operator: " + greaterThanOperator);
            Console.WriteLine("Less than Operator: " + lessThanOperator);
            Console.WriteLine("Greater than or Equal to: " + greaterThanOrEqualOperator);
            Console.WriteLine("Lesser than or Equal to: " + lessThanOrEqualOperator);
            Console.WriteLine("Not Equal to Operator: " + notEqualToOperator);
        }
    }
}
