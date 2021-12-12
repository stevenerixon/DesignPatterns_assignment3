using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.State
{
    class MachineStateOff : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Machine turning On");
        }
    }
}
