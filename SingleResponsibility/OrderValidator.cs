namespace SingleResponsibility;

public class OrderValidator : IOrderValidator
{
    public bool ValidateOrder(string orderId)
    {
        return true;
    }
}