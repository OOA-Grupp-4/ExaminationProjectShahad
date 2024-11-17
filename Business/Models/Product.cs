namespace Business.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string? Description { get; set; } = null!;
        public bool InStock { get; set; }
        public string? Category { get; set; } = null!;
        public object? ProductId { get; set; } 

        public List<string> Images { get; set; } = [];

        public string? StockStatus { get; set; } = null!;

        public bool IsPurchased { get; set; }

    }
}
