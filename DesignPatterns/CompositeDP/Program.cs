﻿using CompositeDP;

Console.WriteLine("***Composite Pattern Demo ***");


//One principle , 2 Departments  , employees(Leaf Node ==>Individual objects)


//Principal of the college
CompositeEmployee Principal = new CompositeEmployee("Dr.S.Som (Principal)", "Planning - Supervising - Managing");

//The College has 2 Head of Departments-One from Mathematics, One from Computer Sc.
CompositeEmployee hodMaths = new CompositeEmployee("Mrs.S.Das(HOD-Maths)", "Maths");
CompositeEmployee hodCompSc = new CompositeEmployee("Mr. V.Sarcar(HOD-CSE)", "Computer Sc.");

//2 other teachers works in Mathematics department
Employee mathTeacher1 = new Employee("Math Teacher-1", "Maths");
Employee mathTeacher2 = new Employee("Math Teacher-2", "Maths");

//3 other teachers works in Computer Sc. department
Employee cseTeacher1 = new Employee("CSE Teacher-1", "Computer Sc.");
Employee cseTeacher2 = new Employee("CSE Teacher-2", "Computer Sc.");
Employee cseTeacher3 = new Employee("CSE Teacher-3", "Computer Sc.");

//Teachers of Mathematics directly reports to HOD-Maths
hodMaths.Add(mathTeacher1);
hodMaths.Add(mathTeacher2);

//Teachers of Computer Sc. directly reports to HOD-CSE
hodCompSc.Add(cseTeacher1);
hodCompSc.Add(cseTeacher2);
hodCompSc.Add(cseTeacher3);

//Principal is on top of college
//HOD -Maths and Comp. Sc directly reports to him
Principal.Add(hodMaths);
Principal.Add(hodCompSc);

//Printing the leaf-nodes and branches in the same way.
//i.e. in each case, we are calling PrintStructures() method
Console.WriteLine("\n Testing the structure of a Principal object");

//Prints the complete structure
Principal.PrintStructures();
Console.WriteLine("\n Testing the structure of a HOD object:");
Console.WriteLine("Teachers working at Computer Science department: ");

//Prints the details of Computer Sc, department
hodCompSc.PrintStructures();

//Leaf node
Console.WriteLine("\n Testing the structure of a leaf node:");
mathTeacher1.PrintStructures();

//Suppose, one computer teacher is leaving now from the organization.
hodCompSc.Remove(cseTeacher2);
Console.WriteLine("\n After CSE Teacher-2 resigned, the organization has following members: ");
Principal.PrintStructures();
