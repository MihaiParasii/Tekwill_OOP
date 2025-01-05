using System.Numerics;

namespace Lesson6;

public class MathOperations<T> where T : INumber<T>
{
    public T Add(T a, T b) => a + b;

    public T Substract(T a, T b) => a - b;

    public T Multiply(T a, T b) => a * b;

    public T Divide(T a, T b)
    {
        T result;

        try
        {
            result = a / b;
        }
        catch (DivideByZeroException)
        {
            throw new ArgumentException("Second number cannot be 0");
        }

        return result;
    }
}
