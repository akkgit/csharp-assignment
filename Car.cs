using System;

public class Car
{
    // Private fields
    private string make;
    private string model;
    private string year;

    // Properties
    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    // Method to display car details
    public void DisplayCarDetails()
    {
        Console.WriteLine("Car Make: " + make);
        Console.WriteLine("Car Model: " + model);
    }
}