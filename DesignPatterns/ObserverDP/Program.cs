using ObserverDP;

Console.WriteLine("***Observer Pattern Demo***\n");
//We have 3 observers-2 of them are ObserverType1, 1 of them is of ObserverType2
IObserver myObserver1 = new ObserverType1("Roy");
IObserver myObserver2 = new ObserverType1("Kevin");
IObserver myObserver3 = new ObserverType2("Bose");
Subject subject = new Subject();
//Registering the observers-Roy,Kevin,Bose
subject.Register(myObserver1);
subject.Register(myObserver2);
subject.Register(myObserver3);
Console.WriteLine(" Setting Flag = 5 ");
subject.Flag = 5;
//Unregistering an observer(Roy))
subject.Unregister(myObserver1);
//No notification this time Roy. Since it is unregistered.
Console.WriteLine("\n Setting Flag = 50 ");
subject.Flag = 50;

//Roy is registering himself again
subject.Register(myObserver1);
Console.WriteLine("\n Setting Flag = 100 ");
subject.Flag = 100;