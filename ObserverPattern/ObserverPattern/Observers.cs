using System;
namespace ObserverPattern
{
    public class CurrentConditionsElement : IDisplayElement, IObserver
    {
        private WeatherElement _weatherElement;

        public void Display()
        {
            Console.WriteLine("Displaying CurrentConditionsElement");
            Console.WriteLine($"Temperature : {_weatherElement.Temperature}, Pressure : {_weatherElement.Pressure}, Humidity : {_weatherElement.Humidity}");
        }

        public void Update(WeatherElement weatherElement)
        {
            _weatherElement = weatherElement;
            Display();
        }
    }

    public class StatisticsDisplay : IDisplayElement, IObserver
    {
        private WeatherElement _weatherElement;

        public void Display()
        {
            Console.WriteLine("Displaying StatisticsDisplay");
            Console.WriteLine($"Temperature : {_weatherElement.Temperature}, Pressure : {_weatherElement.Pressure}, Humidity : {_weatherElement.Humidity}");
        }

        public void Update(WeatherElement weatherElement)
        {
            _weatherElement = weatherElement;
            Display();
        }
    }

    public class ForecastDisplay : IDisplayElement, IObserver
    {
        private WeatherElement _weatherElement;

        public void Display()
        {
            Console.WriteLine("Displaying ForecastDisplay");
            Console.WriteLine($"Temperature : {_weatherElement.Temperature}, Pressure : {_weatherElement.Pressure}, Humidity : {_weatherElement.Humidity}");
        }

        public void Update(WeatherElement weatherElement)
        {
            _weatherElement = weatherElement;
            Display();
        }
    }
}