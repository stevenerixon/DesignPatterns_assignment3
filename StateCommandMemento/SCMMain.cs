
using Assignment2.StateCommandMemento.Memento;
using Assignment2.StateCommandMemento.State;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public void Run()
        {
            Machine machine = new();
            CommandManager commandManager = new(machine);
            MachineMemento machineMemento = machine.CreateMemento();

            Console.WriteLine("******************");
            Console.WriteLine("This is a machine");
            Console.WriteLine("Q : To toogle 'ON' or 'OFF'");
            Console.WriteLine("W : Enter a word");
            Console.WriteLine("R : Reset");
            Console.WriteLine("E : Quit program");

            while (true)
            {
                var userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case 'q' or 'Q':
                        machine.PowerSwitch();
                        foreach(var command in machine.CommandList)
                        {
                            commandManager.Execute(command.Word);
                        }
                        machine.CommandList.Clear();
                        break;
                    case 'w' or 'W':
                        Console.WriteLine("Enter a word");
                        var inputWord = Console.ReadLine();
                        commandManager.Execute(inputWord);
                        break;
                    case 'r' or 'R':
                        Console.WriteLine("Reseting and turning off");
                        machineMemento.Reset();
                        break;
                    case 'e' or 'E':
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("That is not a valid choice!");
                        break;
                }
            }
        }
    }
}