using MyServer.Models;

namespace MyServer.Services
{
    public interface IProductService
    {
        public List<Product> GetProducts();

        public bool AddProduct(Product product);
    }

    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            var products = new List<Product>();

            products.Add(new Product { Name = "Vape", Description = "It Smokes", Price = 500, Inventory = 10 });
            products.Add(new Product { Name = "Mug", Description = "It's a mug", Price = 200, Inventory = 100 });

            return products;
        }

        public bool AddProduct(Product product)
        {
            var newProduct = new Product {Name = product.Name, Description = product.Description, Price = product.Price, Inventory = product.Inventory};

            return true;
        }
    }
}
