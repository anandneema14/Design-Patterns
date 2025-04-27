using FacadePattern.Interfaces;

namespace FacadePattern;

public class Calculations : ICalculations
{
    public void CalculateDiscounts()
    {
        Console.WriteLine("Calculating discounts...");
    }
}