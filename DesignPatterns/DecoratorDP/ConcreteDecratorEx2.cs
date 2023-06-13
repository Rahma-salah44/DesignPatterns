using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    internal class ConcreteDecratorEx2 : AbstractDecrator
    {
        public override void MakeHouse()
        {
            Console.WriteLine("");
            base.MakeHouse();
            Console.WriteLine("***Using another decorator***");
            //Decorating now.
            PaintTheHouse();
        }

        private void PaintTheHouse()
        {
            Console.WriteLine("Now I am painting the house.");
        }
    }
}
