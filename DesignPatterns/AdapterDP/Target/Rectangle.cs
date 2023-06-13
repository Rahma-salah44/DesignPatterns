using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP.Target
{
    internal class Rectangle : IRectangle
    {
        public double Length;
        public double Width;
        public Rectangle(double l, double w)
        {
            this.Length = l;
            this.Width = w;
        }
        public double CalculateAreaOfRectangle()
        {
            return Length * Width;
        }
        public void AboutRectangle()
        {
            Console.WriteLine("Actually, I am a Rectangle");
        }
    }
}
