using System;

namespace Logger.Sample
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public override string ToString()
        {
            return $"The weather at {Date} is {TemperatureC} C or {TemperatureF} F or ordinally is {Summary}";
        }
    }
}
