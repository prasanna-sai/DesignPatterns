using System;
namespace CommandPattern
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class NoCommand : ICommand
    {
        public void Execute()
        {

        }
        public void Undo()
        {

        }
    }

    public class LightOnCommand : ICommand
    {
        public Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }
    }

    public class LightOffCommand : ICommand
    {
        public Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }

        public void Undo()
        {
            light.On();
        }
    }

    public class CeilingFanOnCommand : ICommand
    {
        public CeilingFan fan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.fan = ceilingFan;
        }

        public void Execute()
        {
            fan.On();
        }

        public void Undo()
        {
            fan.Off();
        }
    }

    public class CeilingFanOffCommand : ICommand
    {
        public CeilingFan fan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.fan = ceilingFan;
        }

        public void Execute()
        {
            fan.Off();
        }

        public void Undo()
        {
            fan.On();
        }
    }

    public class GarageDoorOpenCommand : ICommand
    {
        public GarageDoor door;

        public GarageDoorOpenCommand(GarageDoor door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Open();
        }

        public void Undo()
        {
            door.Close();
        }
    }

    public class GarageDoorCloseCommand : ICommand
    {
        public GarageDoor door;

        public GarageDoorCloseCommand(GarageDoor door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Close();
        }

        public void Undo()
        {
            door.Open();
        }
    }

    public class StereoStartCommand : ICommand
    {
        public Stereo stereo;

        public StereoStartCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(11);
        }

        public void Undo()
        {
            stereo.Off();
        }
    }

    public class StereoStopCommand : ICommand
    {
        public Stereo stereo;

        public StereoStopCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(11);
        }
    }
}