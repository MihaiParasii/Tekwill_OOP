using JetBrains.Annotations;
using Lesson12;
using Moq;

namespace TestLesson12;

[TestSubject(typeof(ShoppingCart))]
public class ShoppingCartTest
{
    [Fact]
    public void Method()
    {
        // Arrange
        var productRepository = new Mock<IProductRepository>();
        var shoppingCart = new ShoppingCart(productRepository.Object);
        const int productId = 1;
        var product = new Product { Id = productId, Price = 100 };
        productRepository.Setup(r => r.GetProductById(productId)).Returns(product);

        // Act
        shoppingCart.AddToCart(productId);

        // Assert
        productRepository.Verify(() => product.Name);
    }
}
