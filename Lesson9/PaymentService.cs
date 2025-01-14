namespace Lesson9;

public static class PaymentService
{
    public static void ProcessPayment(IPaymentMethod paymentMethod, Order order)
    {
        paymentMethod.ProcessOrder(order);
    }
}
