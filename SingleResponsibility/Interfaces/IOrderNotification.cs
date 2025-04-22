namespace SingleResponsibility;

public interface IOrderNotification
{
    public void SendOrderConfirmation(string orderId);
}