namespace SingleResponsibility;

public class OrderNotification : IOrderNotification
{
    public void SendOrderConfirmation(string orderId)
    {
        Console.WriteLine($"Order {orderId} is emaild successfully");
    }
}