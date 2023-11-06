using System;
namespace Basics
{
    public class Seven
    {
        public void PositivrOrNegetive()
        {
            Console.WriteLine("Input a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is positive or negative
            if (number > 0)
            {
                Console.WriteLine(number + " is a positive number");
            }
            else if (number < 0)
            {
                Console.WriteLine(number + " is a negative number");
            }
            else
            {
                Console.WriteLine(number + " is neither positive nor negative (it is zero)");
            }
        }
        public void IsLeapYear()
        {
            Console.WriteLine("Input a year:");
            int year = Convert.ToInt32(Console.ReadLine());

            // Check if the year is a leap year
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
        }
        public void IsVowel()
        {
            Console.WriteLine("Enter any alphabet:");
            char alphabet = Convert.ToChar(Console.ReadLine().ToLower()); // Convert to lowercase for case insensitivity

            // Check if the input is a valid alphabet
            if (Char.IsLetter(alphabet))
            {
                // Check if the alphabet is a vowel
                if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
                {
                    Console.WriteLine("The alphabet is a vowel.");
                }
                else
                {
                    Console.WriteLine("The alphabet is a consonant.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid alphabet.");
            }
        }
    }
}
