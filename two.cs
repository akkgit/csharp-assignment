using System;
namespace Basics
{
    public class two
    {
        public void FirstProblem()
        {
            string empName = "Employee Name";
            Console.WriteLine(empName);
            Console.WriteLine("Enter some string");

            var inputStringFromConsole = Console.ReadLine();
            Console.WriteLine("enter your name");
            var name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("enter first name");
            var fname = Console.ReadLine();
            Console.WriteLine("enter last name");
            var lname = Console.ReadLine();
            Console.WriteLine($"Hello {fname} {lname}");

        }

        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static void PasswordProblem()
        {
            Console.WriteLine("Enter your password:");

            // Read password as a char array
            char[] passwordChars = Console.ReadLine().ToCharArray();

            // Convert char array to string
            string password = new string(passwordChars);

            // Print the output
            Console.WriteLine("Password: " + password);
        }
    }
}
