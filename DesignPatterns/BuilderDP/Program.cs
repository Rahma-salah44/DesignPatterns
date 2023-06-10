using BuilderDP;
using BuilderDP.ConcreteBuilders;

Console.WriteLine("***Builder Pattern Demo***");

Director director = new Director();

IBuilder b1 = new Car("Ford");
IBuilder b2 = new MotorCycle("Cycle");

// Making Car
director.Construct(b1);
Product p1 = b1.GetVehicle();
p1.show();


//Making a motor cycle 
director.Construct(b2);
Product p2 = b2.GetVehicle();
p2.show();

