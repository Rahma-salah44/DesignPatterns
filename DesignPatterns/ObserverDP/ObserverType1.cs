using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObserverDP
{
    internal class ObserverType1 : IObserver
    {
        string nameOfObserver;
        public ObserverType1(String name)
        {
            this.nameOfObserver = name;
        }
        public void Update(int i)
        {
            Console.WriteLine("{0} has received an alert: Someone has updated myValue in Subject to: {1}", nameOfObserver, i);
        }
    }
}
