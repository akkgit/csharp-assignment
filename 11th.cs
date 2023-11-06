using System;
namespace Basics
{
    public class _1th
    {
        public void FirstProblem()
        {
            Employee emp = new Employee();

            // Setting employee details using the SetDetails method
            emp.SetDetails("John Doe", 101, 50000.0);

            // Displaying employee details using the DisplayDetails method
            Console.WriteLine("Employee Details:");
            emp.DisplayDetails();
        }
        public void Second()
        {
            Person person1 = new Person();
            Person person2 = new Person("Alice");
            Person person3 = new Person("Bob", 30);
        }

        public void PrintCarDetails()
        {
            var car = new Car1("white", 250);
            car.DisplayCarDetails();
        }

        public void PrintMultipleObjects()
        {
            Person person1 = new Person("Alice", 30);
            Person person2 = new Person("Bob", 25);
            Person person3 = new Person("Charlie", 35);

            // Displaying person details for each object
            Console.WriteLine("Person 1 Details:");
            person1.DisplayDetails();

            Console.WriteLine("Person 2 Details:");
            person2.DisplayDetails();

            Console.WriteLine("Person 3 Details:");
            person3.DisplayDetails();
        }
    }

    public class Employee
    {
        private string name;
        private int id;
        private double salary;

        // Method to set employee details
        public void SetDetails(string empName, int empId, double empSalary)
        {
            name = empName;
            id = empId;
            salary = empSalary;
        }

        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Salary: $" + salary);
        }
    }
}
