using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple;

public class RobotWorker : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot Working");
    }
}