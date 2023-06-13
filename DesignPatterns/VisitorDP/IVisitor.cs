using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDP
{
    internal interface IVisitor
    {
        void Visit(MyClass myClassElement);
    }
}
