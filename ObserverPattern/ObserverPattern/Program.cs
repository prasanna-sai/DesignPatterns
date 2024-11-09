using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weatherElement = new WeatherElement()
            {
                Humidity = 5.3f,
                Temperature = 34,
                Pressure = 721
            };

            var weatherElementNew = new WeatherElement()
            {
                Humidity = 5.1f,
                Temperature = 33,
                Pressure = 719
            };
            var currentConditionsElement = new CurrentConditionsElement();

            var weatherData = new WeatherData();
            weatherData.SetMeasurements(weatherElement);

            weatherData.RegisterObserver(currentConditionsElement);
            weatherData.RegisterObserver(new StatisticsDisplay());

            weatherData.SetMeasurements(weatherElement);
            weatherData.RegisterObserver(new ForecastDisplay());
            weatherData.SetMeasurements(weatherElementNew);

            weatherData.RemoveObserver(currentConditionsElement);
            weatherData.SetMeasurements(weatherElement);
        }
    }
}
