using SimpleFactoryDP;

Console.WriteLine("***Simple factory Pattern Demo***\n");


IAnimal preferedAnimal = null;
SimpleFactory simpleFactory = new SimpleFactory();
preferedAnimal = simpleFactory.createAnimal();

preferedAnimal.speak();
preferedAnimal.action();