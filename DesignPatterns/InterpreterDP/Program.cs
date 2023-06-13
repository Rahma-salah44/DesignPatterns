using InterpreterDP;

Console.WriteLine("***Interpreter Pattern Demo***\n");
string inputString;
Console.WriteLine("Enter a 3 digit number only (i.e. 100 to 999)");
inputString = Console.ReadLine();
Context context = new Context(inputString);
//Some basic validations before we proceed
//Checking whether we can parse the string as an integer
if (context.ValidateUserInputBeforeProceedings(inputString) != -9999)
{
    List<InputExpression> expTree = new
List<InputExpression>();
    expTree.Add(new HundredExpression());
    expTree.Add(new TensExpression());
    expTree.Add(new UnitExpression());
    // Interpret the valid input
    foreach (InputExpression inputExp in expTree)
    {
        inputExp.Interpret(context);
    }
    Console.WriteLine("Original Input {0} is interpreted as {1}", context.GetInput, context.SetOutput);
    Console.ReadLine();
}