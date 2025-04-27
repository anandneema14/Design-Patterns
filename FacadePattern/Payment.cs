using FacadePattern.Interfaces;

namespace FacadePattern;

public class Payment : IPayment
{
    public void MakePayment()
    {
        Console.WriteLine("Making payment...");
    }
}