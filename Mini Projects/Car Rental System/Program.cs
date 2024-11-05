// See https://aka.ms/new-console-template for more information
using System;

public abstract class Vehicle
{
    public string model;
    public string fueltype;
    public string color;
    public string vehicleName;

    public Vehicle(string model, string fuelType, string color)
    {
        this.model = model;
        this.fueltype = fuelType;
        this.color = color;
    }

    public abstract string Model();
    public abstract string FuelType();
    public abstract string Color();

    public void VehicleName(string VehicleName)
    {
        this.vehicleName = vehicleName;
        Console.WriteLine($"Vehicle Details : ");
    }
}

public class Car : Vehicle
{
    public Car(string model, string fuelType, string color) : base(model, fuelType, color)
    {}

    public override string Model()
    {
        return model;
    }

    public override string FuelType()
    {
        return fueltype;
    }

    public override string Color()
    {
        return color;
    }
}

class Program
{
    public static void Main()
    {
        string model = Console.ReadLine();
        string fuelType = Console.ReadLine();
        string vehicleName = Console.ReadLine();
        string color = Console.ReadLine();
        Car car = new Car(model, fuelType, color);
        car.VehicleName(vehicleName);
        Console.WriteLine($"Model - {car.Model()}");
        Console.WriteLine($"Fueltype - {car.FuelType()}");
        Console.WriteLine($"VehicleName - {vehicleName}");
        Console.WriteLine($"Color - {car.Color()}");
    }
}

