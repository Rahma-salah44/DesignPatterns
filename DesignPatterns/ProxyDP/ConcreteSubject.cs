using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDP
{
    internal class ConcreteSubject : AbstractSubject
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("ConcreteSubject.DoSomeWork()");
        }
    }
}
