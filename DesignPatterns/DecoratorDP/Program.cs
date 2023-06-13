using DecoratorDP;

Console.WriteLine("***Decorator pattern Demo***\n");



ConcreteComponent concreteComponent = new ConcreteComponent();
AbstractDecrator decrator1 = new ConcreteDecratorEx1();
decrator1.SetTheComponent(concreteComponent);
decrator1.MakeHouse();

AbstractDecrator decrator2 = new ConcreteDecratorEx2();
decrator2.SetTheComponent(decrator1);
decrator2.MakeHouse();



