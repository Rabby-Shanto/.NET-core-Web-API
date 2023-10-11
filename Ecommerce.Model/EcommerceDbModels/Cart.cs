using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Model.EcommerceDbModels
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public string CartId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
