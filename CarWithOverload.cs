using System;

public class Car1
{
    // Private fields
    private string color;
    private int maxSpeed;

    // Constructor to initialize color and maxSpeed
    public Car1(string carColor, int carMaxSpeed)
    {
        color = carColor;
        maxSpeed = carMaxSpeed;
    }

    // Method to display car details
    public void DisplayCarDetails()
    {
        Console.WriteLine("Car Color: " + color);
        Console.WriteLine("Max Speed: " + maxSpeed + " km/h");
    }
}