namespace OpenClosedPrinciple.Strategies;

public class GoldDiscount : IDiscountStrategy
{
        public decimal GetDiscount(decimal totalAmount) => 0.20m;
}