using System;
namespace Basics
{
    public class Six
    {
        public void ImplicitConversion()
        {
            Console.WriteLine("Enter Int value:");
            int intValue = Convert.ToInt32(Console.ReadLine());

            // Implicit type conversion from int to long
            long longValue = intValue;

            // Print the values
            Console.WriteLine("Int value: " + intValue);
            Console.WriteLine("Long value: " + longValue);
        }
        public void ExplicitConversion()
        {
            Console.WriteLine("Enter Value of I:");
            string input = Console.ReadLine();

            // Explicitly convert the string input to an integer using int.Parse() method
            try
            {
                int i = int.Parse(input);

                // Print the converted value
                Console.WriteLine("Value of I is " + i);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        public void BuiltInTypeConversion()
        {
            Console.WriteLine("Enter string name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Integer value:");
            int intValue = Convert.ToInt32(Console.ReadLine());

            // Convert string to float using float.Parse() method
            float floatValue;
            if (float.TryParse(name, out floatValue))
            {
                Console.WriteLine("string to float - " + floatValue);
            }
            else
            {
                Console.WriteLine("Invalid input for string to float conversion.");
            }

            // Convert int to double using Convert.ToDouble() method
            double doubleValue = Convert.ToDouble(intValue);
            Console.WriteLine("int to double - " + doubleValue);
        }
        public void ValueTypesToString()
        {
            Console.WriteLine("Enter Integer value:");
            int intValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Float value:");
            float floatValue = Convert.ToSingle(Console.ReadLine());

            // Convert int and float to string using ToString() method
            string intToString = intValue.ToString();
            string floatToString = floatValue.ToString();

            // Print the converted strings
            Console.WriteLine("int.ToString() - " + intToString);
            Console.WriteLine("float.ToString() - " + floatToString);
        }
    }
}
