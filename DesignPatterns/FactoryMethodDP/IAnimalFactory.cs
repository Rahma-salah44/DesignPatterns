using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDP
{
    internal abstract class IAnimalFactory
    {
        public IAnimal MakeAnimal()
        {
            Console.WriteLine("\n IAnimalFactory.MakeAnimal()-You cannot ignore parent rules."); //Default Implementation
            IAnimal animal = CreateAnimal();
            animal.Speak();
            animal.Action();
            return animal;
        }


        public abstract IAnimal CreateAnimal();
    }
}
