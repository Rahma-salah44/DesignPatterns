using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDP
{
    internal class Employee : IEmployee
    {
        private string name;
        private string dept;
        public Employee(string name, string dept)
        {
            this.name = name;
            this.dept = dept;
        }
        public void PrintStructures()
        {
            Console.WriteLine("\t\t" + this.name + "works in" + this.dept);
        }
    }
}
