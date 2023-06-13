using MementoDP;

Console.WriteLine("***Memento Pattern Demo***\n");
//Originator is initialized with a state
Originator originatorObject = new Originator();
Memento mementoObject;
originatorObject.State = "Initial state";
mementoObject = originatorObject.GetTheMemento();
//Making a new state
originatorObject.State = "Intermediary state";
// Restore to the previous state
originatorObject.RevertToState(mementoObject);