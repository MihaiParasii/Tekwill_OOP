namespace Lesson9;

public class BankTransferMethod: IPaymentMethod
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Processing bank transfer payment...");
    }
}
