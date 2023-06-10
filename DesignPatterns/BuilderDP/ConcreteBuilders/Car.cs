using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP.ConcreteBuilders
{
    internal class Car : IBuilder
    {
        public string BrandName { get; set; }
        private Product Product;

        public Car(string brandName)
        {
            this.BrandName = brandName;
            Product = new Product();
        }

        public void AddHeadlights()
        {
            Product.add("2 Headlights are added\n");
        }

        public void BuildBody()
        {
            Product.add("This is a body of a Car");
        }

        public void EndOperations()
        {
            //Nothing
        }

        public Product GetVehicle()
        {
            return Product;
        }

        public void InsertWheels()
        {
            Product.add("4 wheels are added");
        }

        public void StartUpOperations()
        {
            Product.add(string.Format("Car Model name :{0}", this.BrandName));
        }
    }
}
