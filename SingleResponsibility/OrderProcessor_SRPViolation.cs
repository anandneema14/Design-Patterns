namespace SingleResponsibility;

public class OrderProcessor_SRPViolation
{
    //Everything in one place
    //Validation
    //Data Saving
    //Notification
    public void ProcessOrder(string orderId)
    {
        // 1. Validate the order
        Console.WriteLine($"Validating order {orderId}...");

        // 2. Save order to database
        Console.WriteLine($"Saving order {orderId} to database...");

        // 3. Send confirmation email
        Console.WriteLine($"Sending confirmation email for order {orderId}...");
    }
}