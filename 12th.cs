using System;
namespace Basics
{
    public class _2th
    {
        public void First()
        {
            // Creating an object of ExampleClass with a specific value
            ExampleClass obj1 = new ExampleClass(10);

            // Accessing the static variable through the class name
            Console.WriteLine("Static Variable Value (accessed through class name): " + ExampleClass.staticVariable);
        }

        public void Second()
        {
            // Creating an object of ExampleClass with a specific value
            // Accessing the static method through the class name
            ExampleClass.StaticMethod();

            // Creating an instance of ExampleClass
            ExampleClass instance = new ExampleClass(10);

            // Accessing the static method through the instance
            // instance.StaticMethod(); this not working 
        }
        public void Third()
        {
            var obj = new ExampleClass();
        }

        public void Fourth()
        {
            // Changing the static variable value using the method
            ExampleClass.ChangeStaticVariable(200);
            // Output: Static Variable Changed. New Value: 200

            // Accessing the static variable directly (no need for an instance)
            Console.WriteLine("Static Variable Accessed Directly: " + ExampleClass.staticVariable);
            // Output: Static Variable Accessed Directly: 200
        }
    }

    public class ExampleClass
    {
        // Static variable
        public static int staticVariable;

        // Instance variable
        private int instanceVariable;

        // Static constructor (executed only once)
        public ExampleClass()
        {
            instanceVariable = 100;
            Console.WriteLine("Instance variable Constructor Invoked. Instance Variable: " + instanceVariable);
        }

        // Constructor to initialize the static variable
        public ExampleClass(int value)
        {
            staticVariable = value;
        }

        // Static method
        public static void StaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }

        // Method to change the static variable value
        public static void ChangeStaticVariable(int newValue)
        {
            staticVariable = newValue;
            Console.WriteLine("Static Variable Changed. New Value: " + staticVariable);
        }
    }
}
