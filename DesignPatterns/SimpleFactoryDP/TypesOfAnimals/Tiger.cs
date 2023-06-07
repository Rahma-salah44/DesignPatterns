using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryDP.TypesOfAnimals
{
    internal class Tiger : IAnimal
    {
        public void action()
        {
            Console.WriteLine("Tiger say halum\n");
        }

        public void speak()
        {
            Console.WriteLine("Tiger is hunting\n");
        }
    }
}
