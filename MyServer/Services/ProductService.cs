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
        //Represents data from the DB
        private List<Product> products = new List<Product>(new Product[] {
            new Product { Name = "Vape", Description = "It Smokes", Price = 500, Inventory = 10 },
            new Product { Name = "Mug", Description = "It's a mug", Price = 200, Inventory = 100 }
        });

        public List<Product> GetProducts()
        {
            return products;
        }

        public bool AddProduct(Product product)
        {
            products.Add(product);

            return true;
        }
    }
}
