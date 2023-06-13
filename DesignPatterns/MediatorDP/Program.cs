using MediatorDP;

Console.WriteLine("*** Modified Mediator Pattern Demo***\n");
ConcreteMediator mediator = new ConcreteMediator();
Friend1 Amit = new Friend1(mediator, "Amit");
Friend2 Sohel = new Friend2(mediator, "Sohel");
Boss Raghu = new Boss(mediator, "Raghu");
mediator.Friend1 = Amit;
mediator.Friend2 = Sohel;
mediator.Boss = Raghu;
Amit.Send(Sohel, "Hi Sohel, can we discuss the mediator pattern?");
Sohel.Send(Amit, "Hi Amit, Yup, we can discuss now.");
Raghu.Send(Amit, "Please get back to work quickly.");
Raghu.Send(Sohel, "Please get back to work quickly.");
//Changing the status of Sohel
Sohel.Status = "Off";
Amit.Send(Sohel, "I am testing to send a message when Sohel is in Off state");
//Sohel is coming online again.
Sohel.Status = "On";
Amit.Send(Sohel, "I am testing to send a message when Sohel in On state again");
//Amit is going offline.
Amit.Status = "Off";
Raghu.Send(Amit, "Can you please come here?");
Raghu.Send(Sohel, "Can you please come here?");