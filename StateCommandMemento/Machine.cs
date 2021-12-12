using Assignment2.StateCommandMemento.Memento;
using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class Machine : IMachineState, IMachine
    {
        public IMachineState MachineState { get; set; }
        public List<MachineCommand> CommandList { get; set; }
        public Machine()
        {
            MachineState = new MachineStateOff();
            CommandList = new List<MachineCommand>();
        }
        public void PowerSwitch()
        {
            MachineState.PowerSwitch();
            if(MachineState is MachineStateOff)
            {
                MachineState = new MachineStateOn();
            }
            else
            {
                MachineState = new MachineStateOff();
            }
        }
        public void DoTask(string word)
        {
            Console.WriteLine($"Printing:{word}");
        }
        public MachineMemento CreateMemento()
        {
            return new MachineMemento(this, CommandList);
        }
    }
}
