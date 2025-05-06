using System;
namespace ProductApp
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
    }
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ProductBloc
    {
        public void LoadProduct(int id)
        {
            // Simulación de obtener producto
            Console.WriteLine($"Producto: Id={id}, Name=OLED Tv");
        }
        public void SaveProduct(Product product)
        {
            // Simulación de guardar en base de datos
            Console.WriteLine($"Guardando en base de datos: Id={product.Id}, Name={product.Name}");
        }
        public void NotifyClients()
        {
            Console.WriteLine("Enviando correo a los clientes");
        }
        public void OnAddToCart(int productId)
        {
            Console.WriteLine($"Agregando al carrito: {productId}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var productBloc = new ProductBloc();

            productBloc.LoadProduct(10);
            productBloc.SaveProduct(new Product { Id = 10, Name = "OLED TV" });
            productBloc.NotifyClients();
            productBloc.OnAddToCart(10);
        }
    }
}
