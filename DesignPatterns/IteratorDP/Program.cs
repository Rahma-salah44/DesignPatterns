using IteratorDP;

Console.WriteLine("***Iterator Pattern Demo***");
ISubjects ScienceSubjects = new Science();
ISubjects ArtsSubjects = new Arts();
IIterator IteratorForScience = ScienceSubjects.CreateIterator();
IIterator IteratorForArts = ArtsSubjects.CreateIterator();
Console.WriteLine("\nScience subjects :");
Print(IteratorForScience);
Console.WriteLine("\nArts subjects :");
Print(IteratorForArts);
static void Print(IIterator iterator)
{
    while (!iterator.IsDone())
    {
        Console.WriteLine(iterator.Next());
    }
}

