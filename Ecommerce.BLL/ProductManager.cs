using Ecommerce.Abstractions.BLL;
using Ecommerce.Abstractions.Repository;
using Ecommerce.BLL.Base;
using Ecommerce.Model.EcommerceDbModels;

namespace Ecommerce.BLL
{
    public class ProductManager : Manager<Product>, IProduct
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository) :base(productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<Product>> GetListofProducts(List<int> id)
        {
            return await _productRepository.GetListofProducts(id);
            
        }
    }
}
