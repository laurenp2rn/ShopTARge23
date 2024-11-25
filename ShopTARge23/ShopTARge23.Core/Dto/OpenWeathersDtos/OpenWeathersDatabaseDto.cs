namespace ShopTARge23.Core.Dto.OpenWeathersDtos
{
    public class OpenWeathersDatabaseDto
    {
        public string CityName { get; set; }
        public string WeatherDescription { get; set; }
        public double Temperature { get; set; }
        public double MinTemperature { get; set; }
        public double MaxTemperature { get; set; }
        public int Humidity { get; set; }
        public double WindSpeed { get; set; }
        public string Icon { get; set; }
        public long TimeStamp { get; set; }
    }
}
