// See https://aka.ms/new-console-template for more information

using InterfaceSegregationPrinciple;

Console.WriteLine("Hello, World!");

HumanWorker worker = new HumanWorker();
worker.Work();
worker.Eat();

RobotWorker robotWorker = new RobotWorker();
robotWorker.Work();
