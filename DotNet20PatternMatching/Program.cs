using System;

Console.WriteLine($"Enter the water temperature in Fahrenheit:");

var isNumber = int.TryParse(Console.ReadLine(), out var number);

string GetWaterState(int tempInFahrenheit) =>
    tempInFahrenheit switch
    {
        (> 32) and (< 212) => "liquid",
        < 32 => "solid",
        > 212 => "gas",
        32 => "solid/liquid transition",
        212 => "liquid / gas transition"
    };

if (isNumber)
{
    var waterState = GetWaterState(number);

    Console.WriteLine(waterState);
}
else
{
    Console.WriteLine("Invalid number");
}

Console.ReadKey();