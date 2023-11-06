using System;
namespace Basics
{
    public class _5th
    {
       public void First()
       {
            // Creating an employee object with a read-only property
            Employee_15 employee = new Employee_15("John Doe", 12345);

            // Accessing and displaying employee details
            employee.DisplayDetails();

            // Trying to modify the read-only property (this will result in a compilation error)
            // employee.EmployeeId = 54321; // Error: Property or indexer 'Employee.EmployeeId' cannot be assigned to -- it is read-only
       }
       public void Second()
       {
            // Creating a person object
            Person_15 person = new Person_15();

            // Setting and getting values using properties
            person.Name = "Alice"; // Setting Name property
            person.Age = 30;       // Setting Age property

            // Getting and displaying values using properties
            Console.WriteLine("Name: " + person.Name); // Output: Name: Alice
            Console.WriteLine("Age: " + person.Age);   // Output: Age: 30

            // Trying to set an invalid age (outside the valid range)
            person.Age = 150; // Output: Invalid age! Age must be between 0 and 120.
        }
       public void Fourth()
       {
            // Creating an object of EmployeeModel and assigning values to properties
            EmployeeModel employee = new EmployeeModel(1, "John Doe", "john@example.com", 50000.0f, true);

            // Printing each property on the console
            Console.WriteLine("Employee ID: " + employee.EmpId);
            Console.WriteLine("Employee Name: " + employee.EmpName);
            Console.WriteLine("Email ID: " + employee.EmailId);
            Console.WriteLine("Salary: " + employee.Salary);
            Console.WriteLine("Is Employee Active: " + employee.IsEmployeeActive);
       }
       public void Fifth()
       {
            // Creating the first object of EmployeeModel and assigning values to properties
            EmployeeModel employee1 = new EmployeeModel(1, "John Doe", "john@example.com", 50000.0f, true);

            // Printing properties of the first employee
            Console.WriteLine("Employee 1 - Properties:");
            Console.WriteLine("Employee ID: " + employee1.EmpId);
            Console.WriteLine("Employee Name: " + employee1.EmpName);
            Console.WriteLine("Email ID: " + employee1.EmailId);
            Console.WriteLine("Salary: " + employee1.Salary);
            Console.WriteLine("Is Employee Active: " + employee1.IsEmployeeActive);
            Console.WriteLine();

            // Creating the second object of EmployeeModel and assigning different values to properties
            EmployeeModel employee2 = new EmployeeModel(2, "Alice Smith", "alice@example.com", 60000.0f, false);

            // Printing properties of the second employee
            Console.WriteLine("Employee 2 - Properties:");
            Console.WriteLine("Employee ID: " + employee2.EmpId);
            Console.WriteLine("Employee Name: " + employee2.EmpName);
            Console.WriteLine("Email ID: " + employee2.EmailId);
            Console.WriteLine("Salary: " + employee2.Salary);
            Console.WriteLine("Is Employee Active: " + employee2.IsEmployeeActive);
        }
    }

    public class Employee_15
    {
        private string name;
        private readonly int employeeId; // Read-only property

        // Constructor to initialize the read-only property
        public Employee_15(string name, int employeeId)
        {
            this.name = name;
            this.employeeId = employeeId;
        }

        // Read-only property to access employeeId
        public int EmployeeId
        {
            get { return employeeId; }
        }

        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee ID: " + EmployeeId);
        }
    }

    public class Person_15
    {
        private string name; // Private field for name
        private int age;     // Private field for age

        // Read-write property for Name
        public string Name
        {
            get { return name; } // Getter
            set { name = value; } // Setter
        }

        // Read-write property for Age with validation
        public int Age
        {
            get { return age; } // Getter
            set
            {
                if (value >= 0 && value <= 120) // Age validation (between 0 and 120)
                {
                    age = value; // Setter with validation
                }
                else
                {
                    Console.WriteLine("Invalid age! Age must be between 0 and 120.");
                }
            }
        }
    }

    public class EmployeeModel
    {
        // Properties of EmployeeModel class
        public int EmpId { get; set; }         // Employee ID (integer)
        public string EmpName { get; set; }     // Employee Name (string)
        public string EmailId { get; set; }     // Email ID (string)
        public float Salary { get; set; }       // Salary (float)
        public bool IsEmployeeActive { get; set; }  // Employee Active Status (boolean)

        // Constructor to initialize properties
        public EmployeeModel(int empId, string empName, string emailId, float salary, bool isEmployeeActive)
        {
            EmpId = empId;
            EmpName = empName;
            EmailId = emailId;
            Salary = salary;
            IsEmployeeActive = isEmployeeActive;
        }
    }
}
