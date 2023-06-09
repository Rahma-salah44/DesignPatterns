﻿using SingletonDP;

//Console.WriteLine("***Singleton Pattern Demo***\n");
//Console.WriteLine("Trying to create instance s1.");
//singleton s1 = singleton.Instance;
//Console.WriteLine("Trying to create instance s2.");
//singleton s2 = singleton.Instance;
//if (s1 == s2)
//    Console.WriteLine("Only one instance exists.");
//else
//    Console.WriteLine("Different instances exist.");





//---------------------------------------Whithout useing sealed keyword -----------------------------------------------

singleton.NestedDerived s1 = new singleton.NestedDerived();
singleton.NestedDerived s2 = new singleton.NestedDerived();

if (s1 == s2)
    Console.WriteLine("Only one instance exists.");
else
    Console.WriteLine("Different instances exist.");