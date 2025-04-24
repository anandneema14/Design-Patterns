namespace OpenClosedPrinciple;

public class Customer
{
    public string Name { get; set; }
    private readonly IDiscountStrategy _discountStrategy;

    public Customer(string name, IDiscountStrategy discountStrategy)
    {
        Name = name;
        _discountStrategy = discountStrategy;
    }

    public decimal GetDiscountedAmount(decimal totalAmount)
    {
        return totalAmount - _discountStrategy.GetDiscount(totalAmount);
    }
}