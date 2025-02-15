using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Temperaturas en grados Celsius a Fahrenheit:");
        Console.WriteLine("Celsius   | Fahrenheit");
        Console.WriteLine("------------------------");

        for (int celsius = 0; celsius <= 100; celsius++)
        {
            double fahrenheit = CelsiusAFahrenheit(celsius);
            Console.WriteLine($"{celsius,7}   | {fahrenheit,10:F1}");
        }

        
        Console.WriteLine();

        
        Console.WriteLine("Temperaturas en grados Fahrenheit a Celsius:");
        Console.WriteLine("Fahrenheit | Celsius");
        Console.WriteLine("-----------------------");

        for (int fahrenheit = 32; fahrenheit <= 212; fahrenheit++)
        {
            double celsius = FahrenheitACelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit,10} | {celsius,7:F1}");
        }
    }

    
    static double CelsiusAFahrenheit(int celsius)
    {
        return (celsius * 9.0 / 5.0) + 32;
    }

   
    static double FahrenheitACelsius(int fahrenheit)
    {
        return (fahrenheit - 32) * 5.0 / 9.0;
    }
}
