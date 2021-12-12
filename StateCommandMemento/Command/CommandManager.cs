using Assignment2.StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Memento
{
    public class CommandManager
    {
        public Machine Machine { get; set; }
        public CommandManager(Machine machine)
        {
            Machine = machine;
        }

        public void Execute(string userInput)
        {
            var command = new MachineCommand(Machine, userInput);
            if(Machine.MachineState is MachineStateOff)
            {
                Machine.CommandList.Add(command);
                Console.WriteLine("Saving command to memory");
            }
            else
            {
                command.Execute();
            }
        }
    }
}
