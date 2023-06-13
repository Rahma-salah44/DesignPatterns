using CommandDP;

Console.WriteLine("***Command Pattern Q&As***");
Console.WriteLine("***A simple demo with undo supported operations * **\n");
/*Client holds both the Invoker and Command Objects*/
Invoker invoker = new Invoker();
//Testing receiver-Receiver1
IReceiver intendedreceiver = new Receiver1();
ICommand currentCmd = new AdditionCommand(intendedreceiver);
invoker.SetCommand(currentCmd);
//Executed the command 2 times
invoker.ExecuteCommand();
invoker.ExecuteCommand();
//Trying to undo 3 times
invoker.UndoCommand();
invoker.UndoCommand();
invoker.UndoCommand();
Console.WriteLine("\nTesting receiver-Receiver2");
intendedreceiver = new Receiver2();
currentCmd = new AdditionCommand(intendedreceiver);
invoker.SetCommand(currentCmd);
//Executed the command 1 time
invoker.ExecuteCommand();
//Trying to undo 2 times
invoker.UndoCommand();
invoker.UndoCommand();