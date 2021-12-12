﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.State
{
    public class MachineStateOn : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Machine turning Off");
        }        
    }
}
