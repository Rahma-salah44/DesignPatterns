using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryDP.TypesOfAnimals
{
    internal class Dog : IAnimal
    {
        public void action()
        {
            Console.WriteLine("Dog say hawhaw");
        }

        public void speak()
        {
            Console.WriteLine("Dog is barking");
        }
    }
}
