namespace SingleResponsibility;

public class OrderProcessor_SRP(
    IOrderValidator orderValidator,
    IOrderRepository orderRepository,
    IOrderNotification orderNotification)
{
    private readonly IOrderRepository _orderRepository;
    private readonly IOrderNotification _orderNotification;
    private readonly IOrderValidator _orderValidator;

    public void ProcessOrder(string orderId)
    {
        if (_orderValidator.ValidateOrder(orderId))
        {
            _orderRepository.SaveOrder(orderId);
            _orderNotification.SendOrderConfirmation(orderId);
        }
    }
}