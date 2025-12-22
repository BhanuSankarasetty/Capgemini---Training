// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    static void TemperatureCategory(double temp)
    {
        if (temp < 0) Console.WriteLine("Freezing");
        else if (temp >= 0 && temp < 10) Console.WriteLine("Very Cold");
        else if (temp >= 10 && temp < 20) Console.WriteLine("Cold");
        else if (temp >= 20 && temp < 30) Console.WriteLine("Warm");
        else if (temp >= 30 && temp < 40) Console.WriteLine("Hot");
        else if (temp >= 40 && temp < 50) Console.WriteLine("Very Hot");
        else if (temp >= 50) Console.WriteLine("Extremely Hot");
        else Console.WriteLine("Invalid Temperature");
    }   