namespace SingleResponsibility;

public interface IOrderValidator
{
    public bool ValidateOrder(string orderId);
}