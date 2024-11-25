using Microsoft.AspNetCore.Mvc;
using ShopTARge23.Core.Dto.WeatherDtos;
using ShopTARge23.Core.ServiceInterface;
using ShopTARge23.Models.OpenWeathers;

namespace ShopTARge23.Controllers
{
    public class OpenWeathersController : Controller
    {
        private readonly IOpenWeathersServices _openWeathersServices;

        public OpenWeathersController
            (
                IOpenWeathersServices openWeathersServices
            )
        {
            _openWeathersServices = openWeathersServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchCity(OpenWeatherSearchViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", "OpenWeathers", new { city = model.CityName });
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult City(string city)
        {
            WeatherDataDto dto = new WeatherDataDto();
            dto.CityName = city;

            _openWeathersServices.OpenWeatherResult(dto);
            OpenWeatherViewModel vm = new OpenWeatherViewModel();

            vm.CityName = dto.CityName;
            vm.Temp = dto.Temp;
            vm.Humidity = dto.Humidity;
            vm.Description = dto.Description;
            vm.WindSpeed = dto.WindSpeed;
            vm.Pressure = dto.Pressure;

            return View(vm);
        }
    }
}
