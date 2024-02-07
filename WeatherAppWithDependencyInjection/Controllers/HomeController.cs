using Microsoft.AspNetCore.Mvc;
using Model;
using ServiceContracts;

namespace WeatherAppWithViewComponents.Controllers {
	public class HomeController : Controller {

		private readonly IWeatherService _weatherService;

		public HomeController(IWeatherService weatherService) {
			_weatherService = weatherService;
		}

		[Route("/")]
		public IActionResult Index() {
			List<CityWeather> cityWeatherList = _weatherService.GetWeatherDetails();
			ViewBag.Title = "Weather";
			return View(cityWeatherList);
		}

		[Route("weather/{cityCode?}")]
		public IActionResult CityWeather(string? cityCode) {
			CityWeather? city = _weatherService.GetWeatherByCityCode(cityCode);
			if (city != null) {
				ViewBag.Title = $"{city.CityName} city weather";
			}
			return View(city);
		}
	}
}
