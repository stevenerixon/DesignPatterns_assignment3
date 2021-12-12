using Assignment2.AbstractFactory.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Factory
{
    public class CatFactory : IFactory
    {
        public IAnimal CretaeAnimal(string name)
        {
            return new Cat(name);
        }
    }
}
