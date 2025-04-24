namespace OpenClosedPrinciple.Strategies;

public class SilverDiscount : IDiscountStrategy
{
    public decimal GetDiscount(decimal totalAmount) => 0.10m;
}