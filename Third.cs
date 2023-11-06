using System;
namespace Basics
{
    public class Third
    {
        public void First()
        {
            // Declare a variable of int data type
            int number = 42;

            // Print the value of the variable to the output
            Console.WriteLine("The value of the number is: " + number);
        }

        public void Second()
        {
            // Declare a variable of bool data type
            bool isTrue = true;

            // Print the value of the variable to the output
            Console.WriteLine("The value of isTrue is: " + isTrue);
        }

        public void Third1()
        {
            // Declare a variable of float data type
            float floatValue = 3.14f;

            // Convert float to decimal using explicit cast
            decimal decimalValue = (decimal)floatValue;

            // Print the decimal value to the output
            Console.WriteLine("The value in decimal is: " + decimalValue);
        }

        public void Fourth()
        {
            Console.WriteLine("Enter the first number:");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Enter the second number:");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Enter the operator (+, -, *, /):");
                    char operation = Console.ReadKey().KeyChar;

                    double result = 0;

                    switch (operation)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                        case 'x':
                            result = num1 * num2;
                            break;
                        case '/':
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                            }
                            else
                            {
                                Console.WriteLine("\nError: Division by zero is not allowed.");
                                return;
                            }
                            break;
                        default:
                            Console.WriteLine("\nError: Invalid operator.");
                            return;
                    }

                    Console.WriteLine($"\nResult: {num1} {operation} {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number.");
            }
        }

        public void Fifth()
        {
            Console.WriteLine("Enter the first letter:");
            char letter1 = Console.ReadKey().KeyChar;
            Console.WriteLine("\nEnter the second letter:");
            char letter2 = Console.ReadKey().KeyChar;
            Console.WriteLine("\nEnter the third letter:");
            char letter3 = Console.ReadKey().KeyChar;

            // Display the letters in reverse order
            Console.WriteLine($"\nLetters in reverse order: {letter3} {letter2} {letter1}");
        }

        public void Sixth()
        {

            Console.WriteLine("Enter a lowercase character:");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line after reading the character

            if (char.IsLetter(inputChar))
            {
                // Check if the input character is a vowel
                if (IsVowel(inputChar))
                {
                    Console.WriteLine("The input character is a vowel.");
                }
                else
                {
                    Console.WriteLine("The input character is a consonant.");
                }
            }
            else if (char.IsDigit(inputChar))
            {
                Console.WriteLine("The input character is a digit.");
            }
            else
            {
                Console.WriteLine("The input character is a symbol.");
            }
        }

        private bool IsVowel(char ch)
        {
            return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
        }

    }
}
