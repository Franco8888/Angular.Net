namespace MyServer.Models
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;

        public long Price { get; set; }

        public string Description { get; set; } = string.Empty;

        public int Inventory { get; set; }
    }
}
