using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Memento
{
    public class MachineMemento
    {
        public Machine Machine { get; set; }
        public List<MachineCommand> CommandList { get; set; }
        public MachineMemento(Machine machine, List<MachineCommand> commandList)
        {
            Machine = machine;
            CommandList = commandList;
        }

        public void Reset()
        {
            Console.WriteLine("Turning machine off and clearint the list of all commands");
            Machine.MachineState = new MachineStateOff();
            Machine.CommandList.Clear();
        }
    }
}
