using AbstractFactoryDP;
using AbstractFactoryDP.AbstractProducts;
using AbstractFactoryDP.ConcreteFactoriesForProducts;

Console.WriteLine("***Abstract Factory Pattern Demo***\n");


Console.WriteLine("Wild animals group first:Dog then :Tiger\n");
IAnimalFactory wildAnimalFactory = new WildAnimalFactory();
IDog wildDog = wildAnimalFactory.GetDog();
wildDog.Speak();
wildDog.Action();

ITiger wildTiger = wildAnimalFactory.GetTiger();
wildTiger.Speak();
wildTiger.Action();

Console.WriteLine("Pet animals group first:Dog then :Tiger\n");

IAnimalFactory petAnimalFactory = new PetAnimalFactory();
IDog petDog = petAnimalFactory.GetDog();
petDog.Speak();
petDog.Action();

ITiger petTiger = petAnimalFactory.GetTiger();
petTiger.Speak();
petTiger.Action();


