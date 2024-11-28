
Celsius tempBruxelles;
tempBruxelles.temperature = 13;

Console.WriteLine($"Aujourd'hui à Bruxelles , il fait {tempBruxelles.temperature}°C");
Console.WriteLine($"Aujourd'hui à Bruxelles , il fait {tempBruxelles.Convertir(tempBruxelles.temperature)}°F");

Fahrenheit tempNewYork;
tempNewYork.temperature = 64;

Console.WriteLine($"Aujourd'hui à New York , il fait {tempNewYork.temperature}°F");
Console.WriteLine($"Aujourd'hui à New York , il fait {tempNewYork.Convertir(tempNewYork.temperature)}°C");


public struct Celsius
{
    public double temperature;

    public Far Convertir(double tempCelsius)
    {
        return tempCelsius * 9 / 5 + 32; 
    }
}

public struct Fahrenheit
{
    public double temperature;

    public double Convertir(double tempFahr)
    {
        return (tempFahr - 32) *5/9;
    }
}