using System;

public class Person
{
    private string name;
    private int age;

    // Default constructor
    public Person()
    {
        name = "Unknown";
        age = 0;
    }

    // Constructor with name parameter
    public Person(string personName)
    {
        name = personName;
        age = 0;
    }

    // Constructor with name and age parameters
    public Person(string personName, int personAge)
    {
        name = personName;
        age = personAge;
    }

    // Method to display person details
    public void DisplayDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}
