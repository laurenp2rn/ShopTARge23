using ShopTARge23.Core.Dto.WeatherDtos;
using System.Threading.Tasks;

namespace ShopTARge23.Core.ServiceInterface
{
    public interface IOpenWeathersServices
    {
        Task<WeatherDataDto> OpenWeatherResult(WeatherDataDto dto);
    }
}
