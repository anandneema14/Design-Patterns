using FacadePattern.Interfaces;

namespace FacadePattern;

public class OrderFacade
{
    private readonly IPayment _payment;
    private readonly IValidate _validate;
    private readonly IInventory _inventory;
    private readonly IInvoice _invoice;
    private readonly ICalculations _calculations;

    public OrderFacade(IPayment payment, IValidate validate, IInventory inventory, IInvoice invoice, ICalculations calculations)
    {
        _payment = payment;
        _validate = validate;
        _inventory = inventory;
        _invoice = invoice;
        _calculations = calculations;
    }
    
    public bool PlaceOrder()
    {
        if (_validate.ValidateOrder())
        {
            Console.WriteLine("Order is valid");
            if (_inventory.CheckInventory())
            {
                Console.WriteLine("Inventory available, processing order...");
                _inventory.UpdateInventory();
                
                _calculations.CalculateDiscounts();
                _invoice.GenerateInvoice();
                _payment.MakePayment();
            }
            return true;
        }
        else
        {
            Console.WriteLine("Order is invalid");
            return false;
        }
    }
}