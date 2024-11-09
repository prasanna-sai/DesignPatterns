using System;
namespace ObserverPattern
{
    public interface IPublisher
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    public interface IObserver
    {
        void Update(WeatherElement weatherElement);
    }

    public interface IDisplayElement
    {
        void Display();
    }
}