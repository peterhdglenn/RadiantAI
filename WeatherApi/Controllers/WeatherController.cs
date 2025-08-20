using Microsoft.AspNetCore.Mvc;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet("{zipCode}")]
        public IActionResult GetWeatherByZip(string zipCode)
        {
            // Mock weather data for demonstration
            var weather = new
            {
                ZipCode = zipCode,
                TemperatureC = 25,
                TemperatureF = 77,
                Condition = "Sunny",
                RetrievedAt = DateTime.UtcNow
            };
            return Ok(weather);
        }
    }
}
