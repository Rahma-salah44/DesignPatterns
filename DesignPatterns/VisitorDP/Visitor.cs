using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDP
{
    internal class Visitor : IVisitor
    {
        public void Visit(MyClass myClassElement)
        {
            Console.WriteLine("Visitor is trying to change the integer value.");
            myClassElement.MyInt = 100;
            Console.WriteLine("Exiting from Visitor.");
        }
    }
}
