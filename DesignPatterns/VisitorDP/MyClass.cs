using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDP
{
    internal class MyClass : IOriginal
    {
        private int myInt = 5;//Initial or default value
        public int MyInt
        {
            get
            {
                return myInt;
            }
            set
            {
                myInt = value;
            }
        }
        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("Initial value of the integer:{0}", myInt);
            visitor.Visit(this);
            Console.WriteLine("\nValue of the integer now:{0}", myInt);
        }
    }
}
