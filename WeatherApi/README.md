# WeatherApi

This is a simple ASP.NET Core WebAPI that exposes an endpoint to get the current weather for a given zip code.

## How to Run

1. Make sure you have [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed.
2. Navigate to the WeatherApi directory:
   ```bash
   cd WeatherApi
   ```
3. Run the API:
   ```bash
   dotnet run
   ```
4. The API will be available at `https://localhost:5001` or `http://localhost:5000` by default.

## Usage

- To get the weather for a zip code, send a GET request to:
  ```
  GET /weather/{zipCode}
  ```
  Example:
  ```
  curl https://localhost:5001/weather/90210 --insecure
  ```

## Notes
- The weather data is currently mocked for demonstration purposes.
- You can extend the controller to fetch real weather data from an external API.
