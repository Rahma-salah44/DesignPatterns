using SimpleFactoryDP.TypesOfAnimals;

namespace SimpleFactoryDP
{
    internal class SimpleFactory : IsimpleFactory
    {
        public override IAnimal createAnimal()
        {
            IAnimal createdAnimal;
            Console.WriteLine("Enter your choice(0 for Dog, 1 for Tiger)");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("You have entered {0}", input);

            switch (input)
            {
                case 0:
                    createdAnimal = new Dog();
                    break;
                case 1:
                    createdAnimal = new Tiger();
                    break;
                default:
                    Console.WriteLine("You must enter either 0 or 1");
                    throw new ApplicationException(String.Format(" Unknown Animal cannot be instantiated"));
            }

            return createdAnimal;
        }
    }
}
