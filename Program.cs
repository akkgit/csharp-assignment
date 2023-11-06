using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int empID;
            string empName;
            empID = 5;
            empName = "Puja";
            Console.WriteLine(empID);
            Console.WriteLine(empName);
        }

        static string EvenOrOdd(int number)
        {
            if(number % 2 == 0)
            {
                return "even";
            }
            return "odd";
        }

        static void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = a;

            Console.WriteLine($"{ a}, { b}");

        }
    }
}
