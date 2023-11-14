// <copyright file="WeatherForecast.cs" company="Cybertrol Software Services">
//     Copyright (c) Cybertrol Software Services. All rights reserved.
// </copyright>

namespace PossibleRegression.Data;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
