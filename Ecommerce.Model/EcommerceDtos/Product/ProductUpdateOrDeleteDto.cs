using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Model.EcommerceDtos.Product
{
    public class ProductUpdateOrDeleteDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? imageUrl { get; set; }
        public int StockQuantity { get; set; }
        public double Price { get; set; }
        public bool isAvailable { get; set; }
        public int? Ratings { get; set; }
    }
}
