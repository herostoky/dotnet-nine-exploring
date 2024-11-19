using Microsoft.AspNetCore.Mvc;
using MigrationFix.Models;

namespace MigrationFix.Controllers;

[Controller]
[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController: ControllerBase
{
    private readonly string[] _summaries =
        ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];
    [HttpGet(Name = nameof(GetWeatherForecast))]
    public IEnumerable<WeatherForecast> GetWeatherForecast()
    {
        var forecast =  Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    _summaries[Random.Shared.Next(_summaries.Length)]
                ))
            .ToArray();
        return forecast;
    }
}