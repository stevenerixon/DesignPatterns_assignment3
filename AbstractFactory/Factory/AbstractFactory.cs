using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Factory
{
    public class AbstractFactory
    {
        public IFactory ChooseFactory()
        {
            Console.WriteLine("What kind of pet do you want, a dog or a cat?");
            var userInput = Console.ReadLine();
            if(userInput.ToLower() == "dog")
            {
                Console.WriteLine($"You choose {userInput}, fetching a Dog for you!");
                return new DogFactory();
            }
            else if(userInput.ToLower() == "cat")
            {
                Console.WriteLine($"You choose {userInput}, fetching a Cat for you!");
                return new CatFactory();
            }
            else
            {
                Console.WriteLine($"{userInput} is not a legit choice");
                return null;
            }
        }
    }
}
