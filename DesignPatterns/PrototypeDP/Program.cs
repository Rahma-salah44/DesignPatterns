
using PrototypeDP;

Console.WriteLine("***Prototype Pattern Demo***\n");



Console.WriteLine("shallow copy\n");
BasicCar car = new Firary("Red Friary Car");
BasicCar bc;

bc = car.clone();
bc.DisplayDetails();








Console.WriteLine("\t------------------------------------------------------------------\n");
Console.WriteLine("Deep copy using ctor copy\n");
Animal animal1 = new Animal("Suzy giraf", 10);
animal1.DisplayDetails();
Console.WriteLine("Copy it to new object and diaplay it\n");
Animal animal2 = new Animal(animal1);
animal2.DisplayDetails();



Console.WriteLine("Change the original and compare both again\n");
animal1.Name = "lolo monkey";
animal1.Age = 50;
Console.WriteLine("Display the original after the change\n");
animal1.DisplayDetails();
Console.WriteLine("Display the copy\n");
animal2.DisplayDetails();













