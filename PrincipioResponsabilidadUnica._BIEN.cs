using System;
namespace ProductApp
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
    }       // Clase que representa un producto
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ProductService
    {
        public void LoadProduct(int id) {Console.WriteLine($"Producto: Id={id}, Name=OLED Tv");        }

        public void SaveProduct(Product product) {º
            Console.WriteLine($"Guardando en base de datos: Id={product.Id}, Name={product.Name}");
        }
    }
    public class EmailNotifier
    {
        public void NotifyClients() { Console.WriteLine("Enviando correo a los clientes"); }
    }
    public class ShoppingCart
    {
        public void AddToCart(int productId)
        {
            Console.WriteLine($"Agregando al carrito: {productId}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var productService = new ProductService();
            var emailNotifier = new EmailNotifier();
            var shoppingCart = new ShoppingCart();
            productService.LoadProduct(10);
            productService.SaveProduct(new Product { Id = 10, Name = "OLED TV" });
            emailNotifier.NotifyClients();
            shoppingCart.AddToCart(10);
        }
    }
}
