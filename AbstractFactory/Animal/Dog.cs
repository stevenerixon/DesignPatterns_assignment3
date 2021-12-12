using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Animal
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public Dog(string name)
        {
            Name = name;
        }
    }
}
