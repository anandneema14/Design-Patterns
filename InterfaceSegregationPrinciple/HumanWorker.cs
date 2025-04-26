using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple;

public class HumanWorker : IWorker, IEater
{
    public void Work()
    {
        Console.WriteLine("Human Worker");
    }

    public void Eat()
    {
        Console.WriteLine("Human Eating");
    }
}