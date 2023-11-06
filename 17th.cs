using System;
using System.Collections.Generic;

namespace Basics
{
    public class _7th
    {
        // First
        // Count,Capacity,Item,IsReadOnly,Comparer
        //Second
        //Add(T item),Remove(T item),Contains(T item),Sort,Clear
        public void ThirdFourthFifth()
        {
            // Creating an empty integer list
            List<int> integerList = new List<int>();

            // Adding 5 integers to the list
            integerList.Add(10);
            integerList.Add(20);
            integerList.Add(30);
            integerList.Add(40);
            integerList.Add(50);

            // Displaying the elements of the integer list
            Console.WriteLine("Integer List Elements:");

            for (int i = 0; i < integerList.Count; i++)
            {
                Console.WriteLine(integerList[i]);
            }
            foreach (int num in integerList)
            {
                Console.WriteLine(num);
            }
        }

        public void SixToSixteen()
        {
            // Creating a string list and adding elements
            List<string> stringList = new List<string>();
            stringList.Add("Alice");
            stringList.Add("Bob");
            stringList.Add("Charlie");
            stringList.Add("David");
            stringList.Add("Eva");

            // 7. Printing string elements using for loop
            Console.WriteLine("String Elements using for loop:");
            for (int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine(stringList[i]);
            }

            // 8. Printing string elements using foreach loop
            Console.WriteLine("\nString Elements using foreach loop:");
            foreach (string name in stringList)
            {
                Console.WriteLine(name);
            }

            // 9. Counting elements in the list and printing
            int count = stringList.Count;
            Console.WriteLine("\nNumber of elements in the list: " + count);

            // 10. Clearing all elements in the list using Clear method
            stringList.Clear();
            Console.WriteLine("\nString List after clearing elements:");
            foreach (string name in stringList)
            {
                Console.WriteLine(name);
            }

            // 11. Checking if 'Kishore' is present in the list
            bool isExists = stringList.Exists(name => name == "Kishore");
            Console.WriteLine("\n'Kishore' is present in the list: " + isExists);


            // 12. Checking if 'Kishore' is present in the list using Find method
            string foundElement = stringList.Find(element => element == "Kishore");
            Console.WriteLine("'Kishore' is present in the list (using Find method): " + (foundElement != null));

            // 13. Checking if 'Kishore' is present in the list using Contains method
            bool containsKishore = stringList.Contains("Kishore");
            Console.WriteLine("'Kishore' is present in the list (using Contains method): " + containsKishore);

            // 14. Inserting an element at index 2 using Insert method
            stringList.Insert(2, "Frank");
            Console.WriteLine("List after inserting 'Frank' at index 2:");
            foreach (string name in stringList)
            {
                Console.WriteLine(name);
            }

            // 15. Reversing the list using Reverse method
            stringList.Reverse();
            Console.WriteLine("List after reversing:");
            foreach (string name in stringList)
            {
                Console.WriteLine(name);
            }

            // 16. Removing an element at index 3 using RemoveAt method
            stringList.RemoveAt(3);
            Console.WriteLine("List after removing element at index 3:");
            foreach (string name in stringList)
            {
                Console.WriteLine(name);
            }
        }

        public void SeventeenToTwentyOne()
        {
            // 17. Creating a list with Student objects
            List<Student17> studentList = new List<Student17>();

            // 18. Adding 10 Student objects to the list
            for (int i = 1; i <= 10; i++)
            {
                Student17 student = new Student17 { Name = "Student" + i, RollNumber = i };
                studentList.Add(student);
            }

            // 19. Counting elements in the list and printing
            int count = studentList.Count;
            Console.WriteLine("Number of students in the list: " + count);

            // 20. Clearing all elements in the list using Clear method
            studentList.Clear();
            Console.WriteLine("Student List after clearing elements: " + studentList.Count);

            // 21. Checking if 'Kishore' student is present in the list using Exists method
            bool existsKishore = studentList.Exists(student => student.Name == "Kishore");
            Console.WriteLine("'Kishore' student is present in the list (using Exists method): " + existsKishore);

            // 22. Checking if 'Kishore' student is present in the list using Find method
            Student17 foundStudent = studentList.Find(student => student.Name == "Kishore");
            Console.WriteLine("'Kishore' student is present in the list (using Find method): " + (foundStudent != null));

            // 23. Checking if 'Kishore' student is present in the list using Contains method
            bool containsKishore = studentList.Contains(new Student17 { Name = "Kishore", RollNumber = 11 });
            Console.WriteLine("'Kishore' student is present in the list (using Contains method): " + containsKishore);

            // 24. Inserting a Student object at index 2 using Insert method
            Student17 newStudent = new Student17 { Name = "NewStudent", RollNumber = 100 };
            studentList.Insert(2, newStudent);

            // Displaying the list after inserting the new student
            Console.WriteLine("Student List after inserting 'NewStudent' at index 2:");
            foreach (Student17 student in studentList)
            {
                Console.WriteLine("Name: " + student.Name + ", Roll Number: " + student.RollNumber);
            }
        }
       
    }

    public class Student17
    {
        public string Name { get; set; }
        public int RollNumber { get; set; }
    }
}
