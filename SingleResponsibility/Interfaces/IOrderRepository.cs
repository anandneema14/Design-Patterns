namespace SingleResponsibility;

public interface IOrderRepository
{
    public void SaveOrder(string orderId);
}