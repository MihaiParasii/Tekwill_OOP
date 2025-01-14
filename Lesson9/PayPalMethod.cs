namespace Lesson9;

public class PayPalMethod : IPaymentMethod
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Processing PayPal payment...");
    }
}
