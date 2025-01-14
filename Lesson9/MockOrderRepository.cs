namespace Lesson9;

public class MockOrderRepository : IRepository<Order>
{
    private readonly List<Order> _orders = [];

    public void SaveToDatabase(Order entity)
    {
        _orders.Add(entity);
    }

    public Order? LoadFromDatabase(int orderId)
    {
        return _orders.FirstOrDefault(o => o.Id == orderId);
    }
}
