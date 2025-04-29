using System;

public class MultiUnitConverter
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nUnit Converter Menu:");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            Console.WriteLine("3. Kilometers to Miles");
            Console.WriteLine("4. Miles to Kilometers");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ConvertCelsiusToFahrenheit();
                    break;
                case "2":
                    ConvertFahrenheitToCelsius();
                    break;
                case "3":
                    ConvertKilometersToMiles();
                    break;
                case "4":
                    ConvertMilesToKilometers();
                    break;
                case "5":
                    Console.WriteLine("Exiting application.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ConvertCelsiusToFahrenheit()
    {
        Console.Write("Enter temperature in Celsius: ");
        string? input = Console.ReadLine();
        try
        {
            double celsius = double.Parse(input);
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static void ConvertFahrenheitToCelsius()
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        string? input = Console.ReadLine();
        try
        {
            double fahrenheit = double.Parse(input);
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit}°F is equal to {celsius}°C");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static void ConvertKilometersToMiles()
    {
        Console.Write("Enter distance in kilometers: ");
        string? input = Console.ReadLine();
        try
        {
            double km = double.Parse(input);
            double miles = km * 0.621371;
            Console.WriteLine($"{km} kilometers is equal to {miles} miles");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static void ConvertMilesToKilometers()
    {
        Console.Write("Enter distance in miles: ");
        string? input = Console.ReadLine();
        try
        {
            double miles = double.Parse(input);
            double km = miles * 1.60934;
            Console.WriteLine($"{miles} miles is equal to {km} kilometers");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}