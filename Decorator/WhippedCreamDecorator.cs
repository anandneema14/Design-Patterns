namespace Decorator;

/// <summary>
/// Concrete Decorator
/// </summary>
public class WhippedCreamDecorator : CoffeeDecorator
{
    public WhippedCreamDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => _coffee.GetDescription() + ", Whipped Cream";
    public override double GetCost() => _coffee.GetCost() + 30;
}