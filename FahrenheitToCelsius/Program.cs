using System;

public class MainClass
{
    static decimal degreeConversion(decimal temprature) 
    {
        return ((temprature - 32) * 5 / 9);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Temprature in Fahrenheit: ");
        decimal Fahrenheit = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Temprature is {0} degree Celsius",degreeConversion(Fahrenheit));

    }

}