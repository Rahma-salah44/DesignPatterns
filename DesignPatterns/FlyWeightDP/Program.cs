using FlyWeightDP;

RobotFactory myfactory = new RobotFactory();
Console.WriteLine("\n***Flyweight Pattern Example Modified * **\n");

Robot shape;
/*Here we are trying to get 3 Small type robots*/
for (int i = 0; i < 3; i++)
{
    shape = (Robot)myfactory.GetRobotFromFactory("Small");
    shape.SetColor(getRandomColor());
    shape.Print();
}
/*Here we are trying to get 3 Large type robots*/
for (int i = 0; i < 3; i++)
{
    shape = (Robot)myfactory.GetRobotFromFactory("Large");
    shape.SetColor(getRandomColor());
    shape.Print();
}
int NumOfDistinctRobots = myfactory.TotalObjectsCreated();
Console.WriteLine("\n Finally no of Distinct Robot objects created: " + NumOfDistinctRobots);

static string getRandomColor()
{
    Random r = new Random();
    int random = r.Next(100);
    if (random % 2 == 0)
    {
        return "red";
    }
    else
    {
        return "green";
    }
}
