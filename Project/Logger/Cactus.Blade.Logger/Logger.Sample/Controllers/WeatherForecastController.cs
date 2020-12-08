using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logger.Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly Serilog.Core.Logger _logger;

        public WeatherForecastController()
        {
            _logger = new LoggerConfiguration()
                 .WriteTo.Console()
                 .CreateLogger();
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var range = new Random();

            var weatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = range.Next(-20, 55),
                Summary = Summaries[range.Next(Summaries.Length)]
            })
                .ToArray();

            foreach (var weatherForecast in weatherForecasts)
            {
                _logger.Fatal(weatherForecast.ToString());
            }
            return weatherForecasts;
        }
    }
}
