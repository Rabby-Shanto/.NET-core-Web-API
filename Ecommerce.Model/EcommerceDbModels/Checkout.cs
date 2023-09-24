namespace Ecommerce.Model.EcommerceDbModels
{
    public class Checkout
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public Customer customer { get; set; }
        public Product product { get; set; }

    }
}
