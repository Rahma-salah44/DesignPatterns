using AdapterDP.Adaptee;
using AdapterDP.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP
{
    internal class TraingleAdapter : IRectangle
    {

        Triangle triangle;

        public TraingleAdapter(Triangle t)
        {
            this.triangle = t;
        }
        public void AboutRectangle()
        {
            triangle.AboutTriangle();
        }

        public double CalculateAreaOfRectangle()
        {
            return triangle.CalculateAreaOfTriangle();
        }
    }
}
