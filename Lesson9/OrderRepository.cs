namespace Lesson9;

public class OrderRepository : IRepository<Order>
{
    public void SaveToDatabase(Order entity)
    {
        // Database simulation ...
        Console.WriteLine("Saving order to database...");
    }

    public Order? LoadFromDatabase(int orderId)
    {
        Console.WriteLine("Loading order from database...");
        return new Order();
    }
}
