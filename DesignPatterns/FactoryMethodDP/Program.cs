using FactoryMethodDP;
using FactoryMethodDP.ConcreteFactoriesForProducts;

Console.WriteLine("***Factory Pattern Demo***\n");

IAnimalFactory tigerFactory = new TigerFactory();
IAnimal tiger = tigerFactory.MakeAnimal();


IAnimalFactory dogFactory = new DogFactory();
IAnimal dog = dogFactory.MakeAnimal();