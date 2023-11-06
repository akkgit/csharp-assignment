using System;
namespace Basics
{
    public class _6th
    {
        public void First()
        {
            // Creating an object of Student class
            Student student = new Student();

            // Setting values for public properties
            student.StudentId = 101;
            student.StudentName = "Santhi";

            // Displaying student details using the public method
            Console.WriteLine("Details of student:");
            student.DisplayStudentDetails();
        }
        public void Second()
        {
            // Creating an object of MyDerivedClass
            MyDerivedClass derivedObj = new MyDerivedClass();

            // Getting input from the user
            Console.Write("Enter value of x: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Calling the method in the derived class, which in turn calls the protected method from the base class
            derivedObj.ProcessInput(userInput);
        }
        public void Third()
        {
            // Creating an object of MyClass
            MyClass myObj = new MyClass();

            // Setting the private variable using a public method
            myObj.SetPrivateVariable(42);

            // Attempting to access the private variable directly (this will result in a compilation error)
            // myObj.privateVariable = 100; // Error: 'MyClass.privateVariable' is inaccessible due to its protection level

            // Displaying the private variable using a public method
            myObj.DisplayPrivateVariable(); // Output: Private Variable: 42
        }
        public void Fourth()
        {
            // Creating an object of MyClass
            MyClass myObj = new MyClass();

            // Accessing the internal method from the same assembly
            myObj.DisplayMessage(); // Output: This is an internal method.
        }
    }

    public class Student
    {
        // Public properties for StudentId and StudentName
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        // Public method to display student details
        public void DisplayStudentDetails()
        {
            Console.WriteLine("StudentId: " + StudentId);
            Console.WriteLine("StudentName: \"" + StudentName + "\"");
        }
    }

    // Base class with a protected method
    public class MyBaseClass
    {
        protected void DisplayMessage(int x)
        {
            Console.WriteLine("Output: " + x);
        }
    }

    // Derived class inheriting from MyBaseClass
    public class MyDerivedClass : MyBaseClass
    {
        public void ProcessInput(int x)
        {
            // Calling the protected method from the base class
            DisplayMessage(x);
        }
    }

    public class MyClass
    {
        private int privateVariable; // Private field

        // Public method to set the private variable
        public void SetPrivateVariable(int value)
        {
            privateVariable = value;
        }

        // Public method to display the private variable
        public void DisplayPrivateVariable()
        {
            Console.WriteLine("Private Variable: " + privateVariable);
        }

        // Internal method
        internal void DisplayMessage()
        {
            Console.WriteLine("This is an internal method.");
        }
    }
}
