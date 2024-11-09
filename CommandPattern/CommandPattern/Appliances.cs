using System;
namespace CommandPattern
{
    public class Light
    {
        public string Name;

        public Light(string name)
        {
            this.Name = name;
        }
        public void On()
        {
            Console.WriteLine($"{Name} Light is powered on");
        }

        public void Off()
        {
            Console.WriteLine($"{Name} Light is powered off");
        }
    }

    public class CeilingFan
    {
        public string Name;
        public int Speed;

        public CeilingFan(string name)
        {
            this.Name = name;
        }
        public void On()
        {
            Console.WriteLine($"{Name} fan is powered on");
        }

        public void Off()
        {
            Console.WriteLine($"{Name} fan is powered off");
        }

        public void SetSpeed(int num)
        {
            Speed = num;
        }
    }

    public class Stereo
    {
        public string Name;
        public int Volume;
        public Stereo(string name)
        {
            Name = name;
        }

        public void On()
        {
            Console.WriteLine($"{Name} stereo is powered on");
        }

        public void Off()
        {
            Console.WriteLine($"{Name} stereo is powered on");
        }

        public void SetCD()
        {
            Console.WriteLine($"{Name}'s stereo CD is slot is set");
        }

        public void SetVolume(int num)
        {
            Volume = num;
            Console.WriteLine($"{Name}'s stereo volume is set to {num}");
        }
    }

    public class GarageDoor
    {
        public void Open()
        {
            Console.WriteLine("Garage door is opened");
        }

        public void Close()
        {
            Console.WriteLine("Garage door is closed");
        }
    }
}