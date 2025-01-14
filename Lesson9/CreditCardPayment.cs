namespace Lesson9;

public class CreditCardPayment : IPaymentMethod
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Processing credit card payment...");
    }
}
