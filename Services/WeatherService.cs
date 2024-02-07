using Model;
using ServiceContracts;

namespace Services {
	public class WeatherService : IWeatherService {

		private List<CityWeather> _cityWeathers;

		public WeatherService() {
			_cityWeathers = new List<CityWeather>() {
				new CityWeather() { CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 8:00"),  TemperatureFahrenheit = 33},
				new CityWeather() { CityUniqueCode = "NYC", CityName = "New York", DateAndTime = Convert.ToDateTime("2030-01-01 3:00"),  TemperatureFahrenheit = 60},
				new CityWeather() { CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00"),  TemperatureFahrenheit = 82}
			};
		}
		public CityWeather? GetWeatherByCityCode(string CityCode) {
			CityWeather? city = _cityWeathers.Where(temp => temp.CityUniqueCode == CityCode).FirstOrDefault();
			return city;
		}

		public List<CityWeather> GetWeatherDetails() {
			return _cityWeathers;
		}
	}
}
