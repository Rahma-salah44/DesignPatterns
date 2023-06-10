using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP.ConcreteBuilders
{
    internal class MotorCycle : IBuilder
    {

        public string BrandName { get; set; }
        private Product Product;

        public MotorCycle(string brandName)
        {
            this.BrandName = brandName;
            Product = new Product();
        }
        public void StartUpOperations()
        { //Nothing in this case
        }
        public void BuildBody()
        {
            Product.add("This is a body of a Motorcycle");
        }
        public void InsertWheels()
        {
            Product.add("2 wheels are added");
        }
        public void AddHeadlights()
        {
            Product.add("1 Headlights are added");
        }
        public void EndOperations()
        {
            //Finishing up with brandname
            Product.add(string.Format("Motorcycle Model name :{0}",
           this.BrandName));
        }

        public Product GetVehicle()
        {
            return Product;
        }
    }
}
