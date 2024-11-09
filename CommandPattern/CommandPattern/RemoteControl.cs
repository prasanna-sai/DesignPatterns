using System;
namespace CommandPattern
{
    public class RemoteControl
    {
        ICommand[] OnCommands;
        ICommand[] OffCommands;
        ICommand UndoCommand;

        public RemoteControl()
        {
            OnCommands = new ICommand[7];
            OffCommands = new ICommand[7];

            for(int i = 0; i < 7; i++)
            {
                OnCommands[i] = new NoCommand();
                OffCommands[i] = new NoCommand();
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButtonPushed(int slot)
        {
            OnCommands[slot].Execute();
            UndoCommand = OnCommands[slot];
        }

        public void OffButtonPushed(int slot)
        {
            OffCommands[slot].Execute();
            UndoCommand = OffCommands[slot];
        }

        public void UndoButtonPushed()
        {
            UndoCommand.Undo();
        }
    }
}