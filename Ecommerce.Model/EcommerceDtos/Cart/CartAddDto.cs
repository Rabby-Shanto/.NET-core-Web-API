namespace Ecommerce.Model.EcommerceDtos.Cart
{
    public class CartAddDto
    {
        public string CartId { get; set; }

        public int Quantity { get; set; }

        public DateTime DateCreated { get; set; }

        public int ProductId { get; set; }


    }
}
