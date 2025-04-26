namespace Decorator;

/// <summary>
/// Concrete Component
/// </summary>
public class SimpleCoffee : ICoffee
{
    public string GetDescription() => "Simple Coffee";

    public double GetCost() => 100;
}