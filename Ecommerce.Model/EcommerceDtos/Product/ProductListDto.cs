namespace Ecommerce.Model.EcommerceDtos.Product
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string imageUrl { get; set; }
        public int StockQuantity { get; set; }
        public double Price { get; set; }
        public bool isAvailable { get; set; }
        public int Ratings { get; set; }
        public int CategoryId { get; set; }
    }
}