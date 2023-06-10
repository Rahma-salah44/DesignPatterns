using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    internal class Product
    {
        List<string> Parts;

        public Product()
        {
            Parts = new List<string>();
        }


        public void add(string part)
        {
            Parts.Add(part);
        }

        public void remove(string part)
        {
            Parts.Remove(part);
        }

        public void show()
        {
            foreach (string part in Parts)
            {
                Console.WriteLine("{0}\n", part);
            }
        }
    }
}
