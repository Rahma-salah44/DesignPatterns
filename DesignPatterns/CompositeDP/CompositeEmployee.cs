using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDP
{
    internal class CompositeEmployee : IEmployee
    {
        private string name;
        private string dept;
        //The container for child objects
        private List<IEmployee> controls;

        public CompositeEmployee(string name, string dept)
        {
            this.name = name;
            this.dept = dept;
            controls = new List<IEmployee>();
        }

        public void Add(IEmployee e)
        {
            controls.Add(e);
        }
        public void Remove(IEmployee e)
        {
            controls.Remove(e);
        }
        public void PrintStructures()
        {
            Console.WriteLine("\t" + this.name + "works in" + this.dept);
            foreach (IEmployee e in controls)
            {
                e.PrintStructures();
            }
        }
    }
}
