using Ecommerce.Abstractions.BLL.Base;
using Ecommerce.Model.EcommerceDbModels;

namespace Ecommerce.Abstractions.BLL
{
    public interface IProduct : IManager<Product>
    {
        Task<List<Product>> GetListofProducts(List<int> id);
        Task<ICollection<Product>> GetFilterdProducts(string name);
    }
}
