using AbstractFactoryDP.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP.Products
{
    internal class PetTiger : ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Pet Tiger says: Halum.");
        }
        public void Action()
        {
            Console.WriteLine("Pet Tigers play in an animal circus.\n");
        }
    }
}
