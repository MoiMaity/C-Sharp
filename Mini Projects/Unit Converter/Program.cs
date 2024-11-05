// See https://aka.ms/new-console-template for more information
using System;

class UnitConverter
{
    public double Convert(double value, string fromUnit, string toUnit)
    {
        fromUnit = fromUnit.ToLower();
        toUnit = toUnit.ToLower();

        if(fromUnit == "meters" || toUnit == "kilometers")
            return value/1000;

        if(fromUnit == "kilometers" || toUnit == "meters")
            return value*1000;

        if(fromUnit == "miles" || toUnit == "feet")
            return value*5280;

        if(fromUnit == "feet" || toUnit == "miles")
            return value/5280;

        if(fromUnit == "grams" || toUnit == "kilograms")
            return value/1000;

        if(fromUnit == "kilograms" || toUnit == "grams")
            return value*1000;

        if(fromUnit == "pounds" || toUnit == "ounces")
            return value*16;

        if(fromUnit == "ounces" || toUnit == "pounds")
            return value/16;

        if(fromUnit == "celcius" || toUnit == "farenheit")
            return (value*1.8)+32;

        if(fromUnit == "farenheit" || toUnit == "celcius")
            return (value-32)/1.8;

        if(fromUnit == "celcius" || toUnit == "kelvin")
            return value+273.15;

        if(fromUnit == "kelvin" || toUnit == "celcius")
            return value-273.15;

        return -1;
        
    }

    public double Convert(double value, string fromUnit)
    {
        fromUnit = fromUnit.ToLower();

        if(fromUnit == "meters" || fromUnit == "kilometers" || fromUnit == "miles" || fromUnit=="feet")
        {
            return Convert(value, fromUnit, "meters");
        }

        if(fromUnit == "grams" || fromUnit == "kilograms" || fromUnit == "ounces" || fromUnit=="pounds")
        {
            return Convert(value, fromUnit, "kilograms");
        }

        if(fromUnit == "celcius" || fromUnit == "farenheit" || fromUnit == "kelvin")
        {
            return Convert(value, fromUnit, "celcius");
        }

        return -1;
    }
}

class Program
{
    static void Main()
    {
        UnitConverter uc = new UnitConverter();
        string ch = Console.ReadLine().ToLower();
        double val = double.Parse(Console.ReadLine());
        string fu = Console.ReadLine().ToLower();
        string tu = Console.ReadLine()?.ToLower();
        double res;

        if(string.IsNullOrEmpty(ch))
        {
            res = uc.Convert(val,fu);
            if(res == -1)
            {
                return;
            }
            Console.WriteLine($"{val} {fu} is {res:F2} {GetDefaultUnit(ch)}.");
        }
        else
        {
            res = uc.Convert(val,fu,tu);
            if(res == -1)
            {
                return;
            }
            Console.WriteLine($"{val} {fu} is {res:F2} {tu}.");
        }
    }

    static string GetDefaultUnit(string type)
    {
        switch(type)
        {
            case "length": return "meters";
            case "weight": return "kilograms";
            case "temperature": return "celcius";
            default: return "true";
        }
    }
}
