using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    internal class ConcreteDecratorEx1 : AbstractDecrator
    {
        public override void MakeHouse()
        {
            base.MakeHouse();
            Console.WriteLine("***Using a decorator***");
            //Decorating now.
            AddFloor();
        }

        private void AddFloor()
        {
            Console.WriteLine("I am making an additional floor on top of it.");
        }
    }
}
