using VisitorDP;

Console.WriteLine("***Visitor Pattern Demo***\n");
IVisitor visitor = new Visitor();
MyClass myClass = new MyClass();
myClass.Accept(visitor);