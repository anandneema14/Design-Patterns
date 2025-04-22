namespace SingleResponsibility;

public class OrderRepository : IOrderRepository
{
    public void SaveOrder(string orderId)
    { 
        Console.WriteLine($"Order {orderId} has been saved.");
    }
}