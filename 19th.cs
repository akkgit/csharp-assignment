using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics
{
    public class _9th
    {
        public void OneToNine()
        {
            // Creating a list of employee objects
            List<Employee19> employees = new List<Employee19>
            {
                new Employee19 { EmpId = 1, EmpName = "Alice", EmpSalary = 1500, DeptId = 1 },
                new Employee19 { EmpId = 2, EmpName = "Bob", EmpSalary = 1200, DeptId = 2 },
                new Employee19 { EmpId = 3, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
                new Employee19 { EmpId = 4, EmpName = "Kishore", EmpSalary = 1000, DeptId = 3 },
                new Employee19 { EmpId = 6, EmpName = "John", EmpSalary = 1100, DeptId = 5 },
                new Employee19 { EmpId = 7, EmpName = "Kumar", EmpSalary = 1300, DeptId = 6 },
                new Employee19 { EmpId = 8, EmpName = "Linda", EmpSalary = 1250, DeptId = 7 },
                new Employee19 { EmpId = 9, EmpName = "Michael", EmpSalary = 1350, DeptId = 8 },
                new Employee19 { EmpId = 10, EmpName = "Kishore", EmpSalary = 1000, DeptId = 9 }
            };

            var empDept4 = new Employee19 { EmpId = 5, EmpName = "Eva", EmpSalary = 1400, DeptId = 4 };
            employees.Add(empDept4);

            First(employees);
            Second(employees);
            Third(employees);
            Fourth(employees, empDept4);
            Fifth(employees);

        }

        private static void Fifth(List<Employee19> employees)
        {
            // Get distinct employee names and count using Distinct method with lambda
            int distinctEmployeeNameCount = employees.Select(employee => employee.EmpName).Distinct().Count();

            // Print the count of distinct employee names
            Console.WriteLine($"Count of distinct employee names: {distinctEmployeeNameCount}");

            // Get distinct employees based on EmpName
            var distinctEmployees = employees.GroupBy(employee => employee.EmpName)
                                             .Select(group => group.First())
                                             .ToList();

            // Print distinct employee details
            foreach (var employee in distinctEmployees)
            {
                Console.WriteLine($"EmpName: {employee.EmpName}, EmpId: {employee.EmpId}, EmpSalary: {employee.EmpSalary}, DeptId: {employee.DeptId}");
            }

            // Get the first employee using First() method
            var firstEmployee = employees.First();

            // Get the first employee using FirstOrDefault() method
            var firstEmployeeOrDefault = employees.FirstOrDefault();

            // Get the first employee using Single() method
            var firstEmployeeSingle = employees.Single();

            // Get the first employee using SingleOrDefault() method
            var firstEmployeeSingleOrDefault = employees.SingleOrDefault();

            // Sorting employees by EmpId using OrderBy() method
            var sortedEmployees = employees.OrderBy(e => e.EmpId).ToList();

            // Sorting employees by EmpName using OrderBy() method
            var sortedEmployeesOnName = employees.OrderBy(e => e.EmpName).ToList();

            // Sorting employees by EmpName in ascending order and then by EmpId in descending order
            employees.Sort(new EmployeeComparer());
        }

        private static void Fourth(List<Employee19> employees, Employee19 empDept4)
        {
            // Creating a new employee list with employees having EmpSalary greater than 2000
            List<Employee19> highSalaryEmployees = employees
                .Where(employee => employee.EmpSalary > 2000)
                .ToList();

            // Printing the count of employees with EmpSalary > 2000 and their details
            Console.WriteLine($"Number of Employees with EmpSalary > 2000: {highSalaryEmployees.Count}");
            Console.WriteLine("Details of Employees with EmpSalary > 2000:");
            foreach (var employee in highSalaryEmployees)
            {
                Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpSalary: {employee.EmpSalary}, DeptId: {employee.DeptId}");
            }

            var collection = highSalaryEmployees.Where(employee => employee.DeptId == 4).Select(employee => employee);

            if (collection != null && collection.Any())
            {
                Console.WriteLine("Employees exists with department id 4");
            }

            foreach (var employee in collection)
            {
                Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, " +
                    $"EmpSalary: {employee.EmpSalary}, DeptId: {employee.DeptId}");
            }

            employees.Contains(empDept4);
        }

        private static void Third(List<Employee19> employees)
        {
            // Creating a new employee list and copying the original list to it
            List<Employee19> newEmployees = new List<Employee19>(employees);

            // Creating a new employee list with employees having EmpName as "Kishore"
            List<Employee19> kishoreEmployeesNewList = employees
                .Where(employee => employee.EmpName == "Kishore")
                .ToList();

            // Printing the details of employees with EmpName as "Kishore"
            Console.WriteLine("Details of Employees with EmpName 'Kishore':");
            foreach (var employee in kishoreEmployeesNewList)
            {
                Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpSalary: {employee.EmpSalary}, DeptId: {employee.DeptId}");
            }
        }

        private static void Second(List<Employee19> employees)
        {
            // Check if employee with DeptId 4 is present using Select method with lambda
            var dept4Employees = employees
                .Where(employee => employee.DeptId == 4)
                .Select(employee => employee)
                .Distinct();

            // Printing distinct employees with DeptId 4
            Console.WriteLine("Distinct Employees with DeptId 4:");
            foreach (var employee in dept4Employees)
            {
                Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, " +
                    $"EmpSalary: {employee.EmpSalary}, DeptId: {employee.DeptId}");
            }
        }

        private static void First(List<Employee19> employees)
        {
            // Selecting EmpId, EmpName, EmpSalary, and DeptId of 'Kishore' employees using Select method
            var kishoreEmployees = employees
                .Select(employee => new
                {
                    EmpId = employee.EmpId,
                    EmpName = employee.EmpName,
                    EmpSalary = employee.EmpSalary,
                    DeptId = employee.DeptId
                })
                .Where(employee => employee.EmpName == "Kishore");

            // Printing EmpId, EmpName, EmpSalary, and DeptId of 'Kishore' employees
            Console.WriteLine("Details of 'Kishore' Employees:");
            foreach (var employee in kishoreEmployees)
            {
                Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpSalary: {employee.EmpSalary}, DeptId: {employee.DeptId}");
            }
        }

        public void Ten()
        {
            // Creating an integer array with 5 elements
            int[] intArray = { 1, 2, 3, 4, 5 };

            // Converting the integer array to an integer list using ToList() method
            List<int> intList = intArray.ToList();
        }
    }

    public class Employee19
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
        public int DeptId { get; set; }
    }

    public class EmployeeComparer : IComparer<Employee19>
    {
        public int Compare(Employee19 x, Employee19 y)
        {
            // First, sort by EmpName in ascending order
            int nameComparison = x.EmpName.CompareTo(y.EmpName);

            // If EmpName is the same, sort by EmpId in descending order
            if (nameComparison == 0)
            {
                return y.EmpId.CompareTo(x.EmpId);
            }

            return nameComparison;
        }
    }
}
