namespace Lesson9;

public interface IRepository<T>
{
    void SaveToDatabase(T entity);
    T? LoadFromDatabase(int orderId);
}
