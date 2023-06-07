using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDP
{
    public abstract class BasicCar  //can implement Iclonable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public BasicCar()
        {
            Price = 1000;
            Name = "Car";
        }

        public abstract BasicCar clone();

        //--------------------------------------Shallow clone by MemberwiseClone() -------------------------------------------------
        //both are variable type (not reference) so it will be cloned bit by bit 
        //If there was a reference type it will only clone the address of the type








        //--------------------------------------Deep clone -------------------------------------------------
        //both are variable type (not reference) so it will be cloned bit by bit 
        //If there was a reference type it will create new reference type and clone it's data 

        public BasicCar(BasicCar car)
        {
            Name = car.Name;
            Price = car.Price;
        }


        public void DisplayDetails()
        {
            Console.WriteLine($"Name of the car is {Name}, and it's price is {Price}\n");
        }
    }


    public class Firary : BasicCar
    {
        public Firary(string name) : base()
        {
            Name = name;
            Price = base.Price + 6000;
        }

        public override BasicCar clone()
        {
            return (Firary)this.MemberwiseClone(); /*---------------------->shallow copy*/
        }
    }









    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Animal(Animal animal)
        {
            Name = animal.Name;
            Age = animal.Age;
        }


        public void DisplayDetails()
        {
            Console.WriteLine($"Name of the animal is {Name}, and it's age is {Age}\n");
        }

    }




}
