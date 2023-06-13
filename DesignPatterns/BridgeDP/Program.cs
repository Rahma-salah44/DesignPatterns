using BridgeDP;

Console.WriteLine("***Bridge Pattern Demo***");
Console.WriteLine("\nDealing with a Television:");

ElectronicGoods eItem = new Television();
IState presentState = new OnState();
eItem.State = presentState;
eItem.MoveToCurrentState();

presentState = new OffState();

eItem.State = presentState;
eItem.MoveToCurrentState();
Console.WriteLine("\n \n Dealing with a VCD:");
presentState = new OnState();

eItem = new VCD();
eItem.State = presentState;
eItem.MoveToCurrentState();
presentState = new OffState();

eItem.State = presentState;
eItem.MoveToCurrentState();