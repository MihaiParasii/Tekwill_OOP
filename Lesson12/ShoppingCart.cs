namespace Lesson12;

public class ShoppingCart(IProductRepository productRepository)
{
    private readonly List<Product> _cartItems = [];

    public void AddToCart(int productId)
    {
        Product? product = productRepository.GetProductById(productId);

        if (product != null)
        {
            _cartItems.Add(product);
        }
    }

    public decimal CalculateTotal()
    {
        return _cartItems.Sum(item => item.Price);
    }
}
