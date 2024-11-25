using ShopTARge23.Core.Dto.OpenWeathersDtos;
using System.Net;
using Newtonsoft.Json;
using ShopTARge23.Core.ServiceInterface;

namespace ShopTARge23.ApplicationServices.Services
{
    public class OpenWeathersServices : IOpenWeathersServices
    {
        public void GetOpenWeatherResult(OpenWeathersDatabaseDto dto)
        {
            string apiKey = "0ade0eb6be7877a3d6b1471046826583";  //API võti
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={dto.CityName}&appid={apiKey}&units=metric";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                dynamic weatherData = JsonConvert.DeserializeObject(json);

                dto.Temperature = weatherData.main.temp;
                dto.FeelsLike = weatherData.main.feels_like;
                dto.Humidity = weatherData.main.humidity;
                dto.Pressure = weatherData.main.pressure;
                dto.WindSpeed = weatherData.wind.speed;
                dto.WeatherCondition = weatherData.weather[0].description;
            }
        }
    }
}
