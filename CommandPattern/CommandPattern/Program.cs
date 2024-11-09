using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();
            var mainHallLight = new Light("MainHall");
            var mainHallCeilingFan = new CeilingFan("MainHall");
            var kitchenLight = new Light("Kitchen");
            var garageDoor = new GarageDoor();
            var stereo = new Stereo("Sony");
            remote.SetCommand(0, new LightOnCommand(mainHallLight), new LightOffCommand(mainHallLight));
            remote.SetCommand(1, new CeilingFanOnCommand(mainHallCeilingFan), new CeilingFanOffCommand(mainHallCeilingFan));
            remote.SetCommand(2, new LightOnCommand(kitchenLight), new LightOffCommand(kitchenLight));
            remote.SetCommand(3, new GarageDoorOpenCommand(garageDoor), new GarageDoorCloseCommand(garageDoor));
            remote.SetCommand(6, new StereoStartCommand(stereo), new StereoStopCommand(stereo));

            remote.OnButtonPushed(2);
            remote.OffButtonPushed(2);
            remote.UndoButtonPushed();
        }
    }
}
