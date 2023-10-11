using Ecommerce.Abstractions.Repository.Base;
using Ecommerce.Model.EcommerceDbModels;

namespace Ecommerce.Abstractions.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<Product>> GetListofProducts(List<int> id);
        Task<ICollection<Product>> GetFilterdProducts(string name);
    }
}
