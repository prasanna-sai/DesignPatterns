using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : IPublisher
    {
        private List<IObserver> _observers;

        private WeatherElement _element;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(o => o.Update(_element));
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(WeatherElement weatherElement)
        {
            /*_element.Pressure = weatherElement.Pressure;
            _element.Temperature = weatherElement.Temperature;
            _element.Humidity = weatherElement.Humidity;*/

            _element = weatherElement;
            MeasurementsChanged();
        }
    }

    public class WeatherElement
    {
        public float Temperature { get; set; }

        public float Humidity { get; set; }

        public float Pressure { get; set; }
    }
}